using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalKasset
{
    public partial class Admin_ViewAndChange : Form
    {
        /// <summary>
        /// Хранение номера личного дела
        /// </summary>
        int IDPrivateBuissness;
        /// <summary>
        /// хранение ИНН
        /// </summary>
        string INN;
        public Admin_ViewAndChange()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Переход на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Admin_EmployeeViewing admin_EmployeeViewing = new Admin_EmployeeViewing();
            this.Hide();
            this.Close();
            admin_EmployeeViewing.ShowDialog();
        }
        /// <summary>
        /// Выгрузка значений из БД в косбобоксы и текстбоксы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_ViewAndChange_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(DataBaseHelper.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"Select* from[dbo].[Doljnost] " +
                $"WHERE IDDoljnosti != 1 ", sqlConnection);
            da.Fill(dataSet, "Roles");
            da = new SqlDataAdapter($"Select IDObekta as 'ID', Naimenovanie as 'Name' from[dbo].[Obekt] ", sqlConnection);
            da.Fill(dataSet, "Objects");
            cbRole.DataSource = dataSet.Tables["Roles"];
            cbRole.DisplayMember = "Naimenovanie";
            cbRole.ValueMember = "IDDoljnosti";
            cbWorkObject.DataSource = dataSet.Tables["Objects"];
            cbWorkObject.DisplayMember = "Name";
            cbWorkObject.ValueMember = "ID";
            IDPrivateBuissness = DataBaseHelper.GetID($"SELECT IDLichnogo_Dela " +
                    $"FROM [dbo].[Sotrudnik] " +
                    $"WHERE IDSotrudnika={DataBaseHelper.selectedUser}");
            tbName.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Imya " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}")) ;
            tbSurname.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Familiya " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}"));
            tbMiddleName.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Otchestvo " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}"));
            mtbINN.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT INN " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}"));
            INN = mtbINN.Text;
            mtbSeriaNumberOfPassport.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Seria_Pasporta " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}")) + 
                Convert.ToString(DataBaseHelper.GetField($"SELECT Nomer_Pasporta " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}")); 
            dateTimePicker1.Value = Convert.ToDateTime(DataBaseHelper.GetField($"SELECT Data_Vidachi " +
                $"FROM [dbo].[Lichnoe_Delo] WHERE IDLichnogo_Dela ={IDPrivateBuissness}"));
            cbRole.SelectedValue = DataBaseHelper.GetID($"SELECT IDDoljnosti" +
                $" FROM [dbo].[Lichnoe_Delo] WHERE [IDLichnogo_Dela]={IDPrivateBuissness}");
            cbWorkObject.SelectedValue = DataBaseHelper.GetID($"SELECT IDObekta FROM [dbo].[Sotrudnik] " +
                $"WHERE IDSotrudnika={DataBaseHelper.selectedUser}");
        }
        /// <summary>
        /// Изменение данных о сотруднике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text.Trim().Length == 0 || tbName.Text.Trim().Length == 0 || 
                mtbINN.Text.Length != 12 || mtbSeriaNumberOfPassport.Text.Length != 10)
            {
                MessageBox.Show("Ошибка, не все поля заполненны коректно");
            }
            else
            {
                    if (DataBaseHelper.isHere($"SELECT INN FROM [dbo].[Lichnoe_Delo] WHERE INN = '{mtbINN.Text}'")&& mtbINN.Text!=INN)
                    {
                        MessageBox.Show("Ошибка, пользователь с таким ИНН уже существует");
                    }
                    else
                    {
                        string MiddleName = "отсутствует";
                        if (tbMiddleName.Text.Trim().Length != 0)
                        {
                            MiddleName = tbMiddleName.Text;
                        }

                        DataBaseHelper.executeQuerry($"UPDATE [dbo].[Lichnoe_Delo] " +
                            $"SET IDDoljnosti={cbRole.SelectedValue}, " +
                            $"Familiya='{tbSurname.Text}', " +
                            $"Imya='{tbName.Text}', " +
                            $"Otchestvo='{MiddleName}', " +
                            $"Seria_Pasporta={mtbSeriaNumberOfPassport.Text.Substring(0,4)}, " +
                            $"Nomer_Pasporta={mtbSeriaNumberOfPassport.Text.Substring(4,6)}, " +
                            $"INN={mtbINN.Text}, " +
                            $"Data_Vidachi='{dateTimePicker1.Value}' " +
                            $"WHERE IDLichnogo_Dela={IDPrivateBuissness}");
                        DataBaseHelper.executeQuerry($"UPDATE [dbo].[Sotrudnik] " +
                            $"SET IDObekta={cbWorkObject.SelectedValue} " +
                            $"WHERE IDSotrudnika={DataBaseHelper.selectedUser}");
                        MessageBox.Show("Данные успешно обновлены");
                    }
                
            }
        }
    }
}
