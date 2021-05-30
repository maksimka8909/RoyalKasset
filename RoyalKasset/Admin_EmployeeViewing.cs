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
    public partial class Admin_EmployeeViewing : Form
    {
        public Admin_EmployeeViewing()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Autorization autorization = new Autorization();
            autorization.ShowDialog();
        }
        /// <summary>
        /// Метод, в котором осуществляется загрузка в датагрид таблицы из БД и
        /// заполняются комбобоксы с необходимымы значениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_EmployeeViewing_Load(object sender, EventArgs e)
        {
            DataBaseHelper.GetList($"SELECT " +
                $"[dbo].[Lichnoe_Delo].[Familiya] as 'Фамилия', " +
                $"[dbo].[Lichnoe_Delo].[Imya] as 'Имя', " +
                $"[dbo].[Lichnoe_Delo].[Otchestvo] as 'Отчество', " +
                $"[dbo].[Doljnost].[Naimenovanie] as 'Должность', " +
                $"[dbo].[Sotrudnik].[Login] as 'Логин', " +
                $"[dbo].[Sotrudnik].[Parol] as 'Пароль', " +
                $"[dbo].[Sotrudnik].[IDSotrudnika], " +
                $"[dbo].[Sotrudnik].[IDObekta] " +
                $"FROM[dbo].[Sotrudnik] " +
                $"LEFT JOIN[dbo].[Lichnoe_Delo] " +
                $"ON [dbo].[Lichnoe_Delo].[IDLichnogo_Dela] = [dbo].[Sotrudnik].[IDLichnogo_Dela] " +
                $"LEFT JOIN[dbo].[Doljnost] " +
                $"ON [dbo].[Doljnost].[IDDoljnosti] = [dbo].[Lichnoe_Delo].[IDDoljnosti]",dgvListEmployers);
            dgvListEmployers.Columns[6].Visible = false;
            dgvListEmployers.Columns[7].Visible = false;
            SqlConnection sqlConnection = new SqlConnection(DataBaseHelper.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT 0 as 'ID', " +
                $"'Все объекты' AS 'Name' " +
                $"UNION " +
                $"SELECT IDObekta,Naimenovanie " +
                $"from [dbo].[Obekt] ", sqlConnection);
            da.Fill(dataSet, "Objects");
            cbObjectOfWork.DataSource = dataSet.Tables["Objects"];
            cbObjectOfWork.DisplayMember = "Name";
            cbObjectOfWork.ValueMember = "ID";
        }
        /// <summary>
        /// Метод, при котором меняется содержимое датагрида в зависимости от выбранного элемента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbObjectOfWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbObjectOfWork.SelectedIndex==0)
            {
                DataBaseHelper.GetList($"SELECT " +
                $"[dbo].[Lichnoe_Delo].[Familiya] as 'Фамилия', " +
                $"[dbo].[Lichnoe_Delo].[Imya] as 'Имя', " +
                $"[dbo].[Lichnoe_Delo].[Otchestvo] as 'Отчество', " +
                $"[dbo].[Doljnost].[Naimenovanie] as 'Должность', " +
                $"[dbo].[Sotrudnik].[Login] as 'Логин', " +
                $"[dbo].[Sotrudnik].[Parol] as 'Пароль', " +
                $"[dbo].[Sotrudnik].[IDSotrudnika], " +
                $"[dbo].[Sotrudnik].[IDObekta] " +
                $"FROM[dbo].[Sotrudnik] " +
                $"LEFT JOIN[dbo].[Lichnoe_Delo] " +
                $"ON [dbo].[Lichnoe_Delo].[IDLichnogo_Dela] = [dbo].[Sotrudnik].[IDLichnogo_Dela] " +
                $"LEFT JOIN[dbo].[Doljnost] " +
                $"ON [dbo].[Doljnost].[IDDoljnosti] = [dbo].[Lichnoe_Delo].[IDDoljnosti]", dgvListEmployers);
            }
            else
            {
                DataBaseHelper.GetList($"SELECT " +
                $"[dbo].[Lichnoe_Delo].[Familiya] as 'Фамилия', " +
                $"[dbo].[Lichnoe_Delo].[Imya] as 'Имя', " +
                $"[dbo].[Lichnoe_Delo].[Otchestvo] as 'Отчество', " +
                $"[dbo].[Doljnost].[Naimenovanie] as 'Должность', " +
                $"[dbo].[Sotrudnik].[Login] as 'Логин', " +
                $"[dbo].[Sotrudnik].[Parol] as 'Пароль', " +
                $"[dbo].[Sotrudnik].[IDSotrudnika], " +
                $"[dbo].[Sotrudnik].[IDObekta] " +
                $"FROM[dbo].[Sotrudnik] " +
                $"LEFT JOIN[dbo].[Lichnoe_Delo] " +
                $"ON [dbo].[Lichnoe_Delo].[IDLichnogo_Dela] = [dbo].[Sotrudnik].[IDLichnogo_Dela] " +
                $"LEFT JOIN[dbo].[Doljnost] " +
                $"ON [dbo].[Doljnost].[IDDoljnosti] = [dbo].[Lichnoe_Delo].[IDDoljnosti] " +
                $"WHERE [dbo].[Sotrudnik].[IDObekta] = {cbObjectOfWork.SelectedValue}", dgvListEmployers);
            }
        }
        /// <summary>
        /// Открывает новую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Admin_AddingEmployee admin_AddingEmployee = new Admin_AddingEmployee();
            this.Hide();
            this.Close();
            admin_AddingEmployee.ShowDialog();
        }
        /// <summary>
        /// Удаляет выбранный в датагриде элемент из Базы Данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dgvListEmployers.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (dgvListEmployers.CurrentRow.Cells[3].Value.ToString() == "Администратор")
                    {
                        MessageBox.Show("Администратора нельзя удалить");
                    }
                    else
                    {
                        int IDPrivateBuissness = DataBaseHelper.GetID($"SELECT IDLichnogo_Dela " +
                            $"FROM [dbo].[Sotrudnik] " +
                            $"WHERE IDSotrudnika={dgvListEmployers.CurrentRow.Cells[6].Value.ToString()}");
                        DataBaseHelper.executeQuerry($"DELETE FROM [dbo].[Sotrudnik] " +
                            $"WHERE IDSotrudnika={dgvListEmployers.CurrentRow.Cells[6].Value.ToString()}");
                        DataBaseHelper.executeQuerry($"DELETE FROM [dbo].[Lichnoe_Delo] " +
                            $"WHERE IDLichnogo_Dela={IDPrivateBuissness}");
                        cbObjectOfWork.SelectedIndex = 0;
                        DataBaseHelper.GetList($"SELECT " +
                        $"[dbo].[Lichnoe_Delo].[Familiya] as 'Фамилия', " +
                        $"[dbo].[Lichnoe_Delo].[Imya] as 'Имя', " +
                        $"[dbo].[Lichnoe_Delo].[Otchestvo] as 'Отчество', " +
                        $"[dbo].[Doljnost].[Naimenovanie] as 'Должность', " +
                        $"[dbo].[Sotrudnik].[Login] as 'Логин', " +
                        $"[dbo].[Sotrudnik].[Parol] as 'Пароль', " +
                        $"[dbo].[Sotrudnik].[IDSotrudnika], " +
                        $"[dbo].[Sotrudnik].[IDObekta] " +
                        $"FROM[dbo].[Sotrudnik] " +
                        $"LEFT JOIN[dbo].[Lichnoe_Delo] " +
                        $"ON [dbo].[Lichnoe_Delo].[IDLichnogo_Dela] = [dbo].[Sotrudnik].[IDLichnogo_Dela] " +
                        $"LEFT JOIN[dbo].[Doljnost] " +
                        $"ON [dbo].[Doljnost].[IDDoljnosti] = [dbo].[Lichnoe_Delo].[IDDoljnosti]", dgvListEmployers);
                        MessageBox.Show("Сотрудник удален");
                    }

                }
                else
                {
                    MessageBox.Show("Сотрудник для удаления не выбран");
                }
            }
            catch
            {
                MessageBox.Show("Удаление невозможно, сотрудник используется в договорах и не может быть удален");
            }
        }
        /// <summary>
        /// Открывает новую форму если выбран сотрудник в датагрид
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoreInfo_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvListEmployers.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (dgvListEmployers.CurrentRow.Cells[3].Value.ToString() != "Администратор")
                {
                    DataBaseHelper.selectedUser = Convert.ToInt32(dgvListEmployers.CurrentRow.Cells[6].Value.ToString());
                    Admin_ViewAndChange admin_ViewAndChange = new Admin_ViewAndChange();
                    this.Hide();
                    this.Close();
                    admin_ViewAndChange.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Функция измения данных об администраторах недоступна");
                }
            }
            else
            {
                MessageBox.Show("Сотрудник для изменения не выбран");
            }
        }
        /// <summary>
        /// Переход на другую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListOfChecks_Click(object sender, EventArgs e)
        {
            Admin_CheckList admin_CheckList = new Admin_CheckList();
            this.Hide();
            this.Close();
            admin_CheckList.ShowDialog();
        }
        /// <summary>
        /// Переход на другую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListOfRequest_Click(object sender, EventArgs e)
        {
            Admin_ListOfApplications admin_ListOfApplications = new Admin_ListOfApplications();
            this.Hide();
            this.Close();
            admin_ListOfApplications.ShowDialog();
        }
    }
}
