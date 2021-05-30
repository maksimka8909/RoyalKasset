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
    public partial class Cashier_Ordering : Form
    {
        public Cashier_Ordering()
        {
            InitializeComponent();
        }
        /// <summary>
        /// переход на новую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseRequest_Click(object sender, EventArgs e)
        {
            Cashier_Execution cashier_Execution = new Cashier_Execution();
            this.Hide();
            this.Close();
            cashier_Execution.ShowDialog();
        }
        /// <summary>
        /// оформление заявки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length == 0 || tbSurname.Text.Trim().Length == 0 || mtbSeriaNumberOfPassport.Text.Length != 10 
                || cbEdition.SelectedItem == null || cbNameOfFilm.SelectedItem == null)
            {
                MessageBox.Show("Ошибка, поля заполнены некорректно");
            }
            else
            {
                string MiddleName = "отсутствует";
                if (tbMiddleName.Text.Trim().Length!=0)
                {
                    MiddleName = tbMiddleName.Text;
                }
                if (DataBaseHelper.isHere($"SELECT IDObshaya_Harakteristika FROM [dbo].[Obshaya_Harakteristika] " +
                    $"WHERE IDObshaya_Harakteristika={cbNameOfFilm.SelectedValue} AND IDIzdanie={cbEdition.SelectedValue} "))
                {
                    DataBaseHelper.executeQuerry($" INSERT INTO [dbo].[Klient](Familiya,Imya,Otchestvo,Telefon,Seria_Pasporta,Nomer_Pasporta) " +
                        $"VALUES " +
                        $"('{tbSurname.Text}','{tbName.Text}','{MiddleName}','отсутствует'," +
                        $"'{mtbSeriaNumberOfPassport.Text.Substring(0,4)}','{mtbSeriaNumberOfPassport.Text.Substring(4,6)}')");
                   int idClient = DataBaseHelper.GetID($"SELECT TOP (1) [dbo].[Klient].[IDKlienta] " +
                                $"FROM [dbo].[Klient] " +
                                $"ORDER BY [dbo].[Klient].[IDKlienta] DESC");
                    decimal price = DataBaseHelper.GetPrice($"SELECT Cena FROM [dbo].[Obshaya_Harakteristika] " +
                        $"WHERE IDObshaya_Harakteristika = {cbNameOfFilm.SelectedValue}");
                    DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Zayavka](IDObshaya_Harakteristika, IDSotrudnika, IDKlienta, " +
                        $"Data_Formirovaniya,Data_Okanchaniya,Zadoljennost,Stoimost,Activnost) " +
                        $"VALUES " +
                        $"({cbNameOfFilm.SelectedValue},{DataBaseHelper.idCurrentCassir},{idClient},'{DateTime.Today}','{DateTime.Today.AddDays(7)}', " +
                        $"'отсутствует','{price}','не активна')");
                    MessageBox.Show("Заявка оформлена на рассмотрение");
                }
                else
                {
                    MessageBox.Show("Фильм с таким изданием отсутствует, извините");
                }
            }
        }
        /// <summary>
        /// переход на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            this.Hide();
            this.Close();
            autorization.ShowDialog();
        }
        /// <summary>
        /// Выгрузка таблицы из бд в датагрид
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cashier_Ordering_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(DataBaseHelper.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($" SELECT IDIzdanie as 'ID', Nazvanie_Izdaniya as 'Name' from[dbo].[Izdanie] ", sqlConnection);
            da.Fill(dataSet, "Editions");
            cbEdition.DataSource = dataSet.Tables["Editions"];
            cbEdition.DisplayMember = "Name";
            cbEdition.ValueMember = "ID";
            da = new SqlDataAdapter($" SELECT IDObshaya_Harakteristika as 'ID', " +
                $"Naimenovanie as 'Film' " +
                $"from [dbo].[Obshaya_Harakteristika] ", sqlConnection);
            da.Fill(dataSet, "Films");
            cbNameOfFilm.DataSource = dataSet.Tables["Films"];
            cbNameOfFilm.DisplayMember = "Film";
            cbNameOfFilm.ValueMember = "ID";
        }

    }
}
