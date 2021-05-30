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
    public partial class Admin_AddingEmployee : Form
    {
        public Admin_AddingEmployee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, возвращающий пользователя на предыдущую форму
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
        /// Метод, добавляющий сотрудника в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text.Trim().Length == 0 || tbName.Text.Trim().Length == 0 || tbLogin.Text.Trim().Length == 0 ||
                tbPassword.Text.Trim().Length == 0 || mtbINN.Text.Length != 12 || mtbSeriaNomerOfPassport.Text.Length != 10)
            {
                MessageBox.Show("Ошибка, необходимо заполнить все поля." +
                    " Логин должен иметь длину минимум 6 символов. Пароль должен содержать хотя бы один спецсимвол(*_-) и иметь длину минимум 6 символов.");
            }
            else
            {
                if (DataBaseHelper.isHere($"SELECT Login FROM [dbo].[Sotrudnik] WHERE Login = '{tbLogin.Text}'"))
                {
                    MessageBox.Show("Ошибка, такой логин уже существует");
                }
                else
                {
                    if (DataBaseHelper.isHere($"SELECT INN FROM [dbo].[Lichnoe_Delo] WHERE INN = '{mtbINN.Text}'"))
                    {
                        MessageBox.Show("Ошибка, пользователь с таким ИНН уже существует");
                    }
                    else
                    {
                        bool isNumber;
                        int isSymbol = 0;
                        bool isUpper;
                        if ((tbPassword.Text.Count(Char.IsSymbol) >= 1) || (tbPassword.Text.Count(Char.IsSeparator) >= 1)
                        || (tbPassword.Text.Count(Char.IsSurrogate) >= 1) || (tbPassword.Text.Count(Char.IsPunctuation) >= 1))
                        {
                            isSymbol++;
                        }
                        isNumber = tbPassword.Text.Count(Char.IsDigit) >= 1;
                        isUpper = tbPassword.Text.Count(Char.IsUpper) >= 1;
                        if (tbPassword.Text.Length < 6 || isNumber == false || isUpper == false || isSymbol == 0 || tbLogin.Text.Length<6)
                        {
                            MessageBox.Show("Ошибка. Логин должен иметь длину минимум 6 символов. " +
                                "Пароль должен содержать хотя бы один спецсимвол(*_-) и иметь длину минимум 6 символов.");
                        }
                        else
                        {
                            string MiddleName = "отсутствует";
                            if (tbMiddleName.Text.Trim().Length != 0)
                            {
                                MiddleName = tbMiddleName.Text;
                            }

                         DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Lichnoe_Delo] (IDDoljnosti,Familiya,Imya,Otchestvo,Seria_Pasporta,Nomer_Pasporta,Data_Vidachi,INN) " +
                         $"VALUES " +
                         $"({cbRole.SelectedValue},'{tbSurname.Text}','{tbName.Text}','{MiddleName}',{mtbSeriaNomerOfPassport.Text.Substring(0, 4)}," +
                         $"{mtbSeriaNomerOfPassport.Text.Substring(4, 6)},'{dateTimePicker1.Value}',{mtbINN.Text})");
                            int idPrivateBuissness = DataBaseHelper.GetID($"SELECT IDLichnogo_Dela FROM [dbo].[Lichnoe_Delo] " +
                                $"WHERE INN={mtbINN.Text}");
                            DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Sotrudnik](IDObekta,IDLichnogo_Dela,Login,Parol) " +
                                $"VALUES " +
                                $"({cbWorkObject.SelectedValue},{idPrivateBuissness},'{tbLogin.Text}',HASHBYTES('MD5','{tbPassword.Text}'))");
                            Admin_EmployeeViewing admin_EmployeeViewing = new Admin_EmployeeViewing();
                            this.Hide();
                            this.Close();
                            admin_EmployeeViewing.ShowDialog();
                        }

                    }
                }
            }
        }
        /// <summary>
        /// Метод, в котором осуществляется загрузка в датагрид таблицы из БД и
        /// заполняются комбобоксы с необходимымы значениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_AddingEmployee_Load(object sender, EventArgs e)
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
        }
    }
}
