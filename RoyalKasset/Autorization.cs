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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Полный выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        /// <summary>
        /// Осуществляет проверку на наличия пользователя и дальнейшего его распределения по формам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(DataBaseHelper.Connection);
            string query =  $" SELECT [dbo].[Lichnoe_Delo].[IDDoljnosti] FROM [dbo].[Sotrudnik] " +
                $"LEFT JOIN[dbo].[Lichnoe_Delo] ON[dbo].[Lichnoe_Delo].[IDLichnogo_Dela] = [dbo].[Sotrudnik].[IDSotrudnika] " +
                $"WHERE[dbo].[Sotrudnik].[Login]='{txtbxLogin.Text}' " +
                $"AND[dbo].[Sotrudnik].[Parol]=HASHBYTES('MD5','{txtbxPassword.Text}') ";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            switch (Convert.ToInt32(sqlCommand.ExecuteScalar()))
            {
                case 1:
                    Admin_EmployeeViewing admin_EmployeeViewing = new Admin_EmployeeViewing();
                    this.Hide();
                    admin_EmployeeViewing.ShowDialog();
                    break;
                case 2:
                    DataBaseHelper.idCurrentCassir = DataBaseHelper.GetID($"SELECT IDSotrudnika " +
                        $"FROM [dbo].[Sotrudnik] " +
                        $"WHERE Login='{txtbxLogin.Text}'");
                    Cashier_Ordering cashier_Ordering = new Cashier_Ordering();
                    this.Hide();
                    cashier_Ordering.ShowDialog();
                    break;
                case 3:
                    Storekeeper_List storekeeper_List = new Storekeeper_List();
                    this.Hide();
                    storekeeper_List.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Неверный логин или пароль. Повторите попытку");
                    break;

            }
            sqlConnection.Close();
        }
    }
}
