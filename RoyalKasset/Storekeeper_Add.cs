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
    public partial class Storekeeper_Add : Form
    {
        public Storekeeper_Add()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавление видеоматериала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
           if(tbDuration.Text.Trim().Length==0|| tbAmount.Text.Trim().Length==0||tbFilmName.Text.Trim().Length==0||
                tbPrice.Text.Trim().Length==0|| tbYearOfRealese.Text.Trim().Length != 4)
           {
                MessageBox.Show("Неверно заполнены поля");
           }
           else
           {
                if(cbTypeVideo.SelectedIndex == 0)
                {
                    if (tbFirst.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Obshaya_Harakteristika](IDIzdanie,Naimenovanie,Prodoljitelnost,Janr, " +
                            $" Kolichestvo,Cena, God_Vipuska) " +
                            $"VALUES " +
                            $"({cbEdition.SelectedValue},'{tbFilmName.Text}','{tbDuration.Text}','{cbGenre.SelectedItem}', " +
                            $"'{tbAmount.Text}',{tbPrice.Text},{tbYearOfRealese.Text}) ");
                        int idPublicInfo = DataBaseHelper.GetID($"SELECT TOP (1) [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] " +
                            $"FROM[dbo].[Obshaya_Harakteristika] " +
                            $"ORDER BY [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] DESC");
                        DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Razvlekatelnaya_Programma](IDObshaya_Harakteristika,Nomer_Vipuska) " +
                            $"VALUES ({idPublicInfo},{tbFirst.Text})");
                        MessageBox.Show("Видеоматериал успешно добавлен");

                    }
                }
                if (cbTypeVideo.SelectedIndex == 1)
                {
                    if (tbFirst.Text.Trim().Length == 0 || tbSecond.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Obshaya_Harakteristika](IDIzdanie,Naimenovanie,Prodoljitelnost,Janr, " +
                            $" Kolichestvo,Cena, God_Vipuska) " +
                            $"VALUES " +
                            $"({cbEdition.SelectedValue},'{tbFilmName.Text}','{tbDuration.Text}','{cbGenre.SelectedItem}', " +
                            $"'{tbAmount.Text}',{tbPrice.Text},{tbYearOfRealese.Text}) ");
                        int idPublicInfo = DataBaseHelper.GetID($"SELECT TOP (1) [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] " +
                            $"FROM[dbo].[Obshaya_Harakteristika] " +
                            $"ORDER BY [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] DESC");
                        DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Musikalnaya_Kompoziciya](IDObshaya_Harakteristika,Ispolnitel,Avtor_Proizvedeniya) " +
                            $"VALUES ({idPublicInfo},'{tbFirst.Text}','{tbSecond.Text}')");
                        MessageBox.Show("Видеоматериал успешно добавлен");
                    }
                }
                if (cbTypeVideo.SelectedIndex == 2)
                {
                    if (tbFirst.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else
                    {
                        if((tbSecond.Text.Trim().Length == 0 && tbThird.Text.Trim().Length == 0 && tbFouth.Text.Trim().Length == 0) ||(tbSecond.Text.Trim().Length == 0 && tbThird.Text.Trim().Length == 0))
                        {
                            MessageBox.Show("Заполните информацаию о режиссере");
                        }
                        else
                        {
                            DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Obshaya_Harakteristika](IDIzdanie,Naimenovanie,Prodoljitelnost,Janr, " +
                            $" Kolichestvo,Cena, God_Vipuska) " +
                            $"VALUES " +
                            $"({cbEdition.SelectedValue},'{tbFilmName.Text}','{tbDuration.Text}','{cbGenre.SelectedItem}', " +
                            $"'{tbAmount.Text}',{tbPrice.Text},{tbYearOfRealese.Text}) ");
                            int idPublicInfo = DataBaseHelper.GetID($"SELECT TOP (1) [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] " +
                                $"FROM[dbo].[Obshaya_Harakteristika] " +
                                $"ORDER BY [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] DESC");
                            DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[Rejisser](Familiya,Imya,Otchestvo) " +
                                $"VALUES ('{tbSecond.Text}','{tbThird.Text}','{tbFouth.Text}')");
                            int idRejisser = DataBaseHelper.GetID($"SELECT TOP (1) [dbo].[Rejisser].[IDRejisser] " +
                                $"FROM[dbo].[Rejisser] " +
                                $"ORDER BY [dbo].[Rejisser].[IDRejisser] DESC");
                            DataBaseHelper.executeQuerry($"INSERT INTO [dbo].[HudIDokFilmIMultfilm](IDObshaya_Harakteristika,Nazvanie_Kinostudii,IDRejisser) " +
                            $"VALUES ({idPublicInfo},'{tbFirst.Text}',{idRejisser})");
                            MessageBox.Show("Видеоматериал успешно добавлен");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Выход на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Storekeeper_List storekeeper_List = new Storekeeper_List();
            this.Hide();
            this.Close();
            storekeeper_List.ShowDialog();
        }
        /// <summary>
        /// Выгрузка и добавление значений в комбобокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Storekeeper_Add_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(DataBaseHelper.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($" SELECT IDIzdanie as 'ID', Nazvanie_Izdaniya as 'Name' from[dbo].[Izdanie] ", sqlConnection);
            da.Fill(dataSet, "Editions");
            cbEdition.DataSource = dataSet.Tables["Editions"];
            cbEdition.DisplayMember = "Name";
            cbEdition.ValueMember = "ID";
            cbGenre.Items.Add("Ужасы");
            cbGenre.Items.Add("Драма");
            cbGenre.Items.Add("Комедия");
            cbGenre.Items.Add("Триллер");
            cbGenre.Items.Add("Боевик");
            cbGenre.Items.Add("Мелодрама");
            cbGenre.Items.Add("Детектив");
            cbGenre.Items.Add("Мюзикл");
            cbGenre.Items.Add("Приключения");
            cbGenre.Items.Add("Фантастика");
            cbGenre.SelectedIndex = 0;
            cbTypeVideo.Items.Add("Развлекательная программа");
            cbTypeVideo.Items.Add("Музыкальная композиция");
            cbTypeVideo.Items.Add("Худ/Док фильм/мультфильм");
            cbTypeVideo.SelectedIndex = 0;
            lblFirst.Text = "Номер выпуска";
            tbFirst.Visible = true;

        }
        /// <summary>
        /// Изменение видимости текстбоксов и лейблов в зависимости от выбранного элмента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbTypeVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeVideo.SelectedIndex==0)
            {
                lblFirst.Text = "Номер выпуска";
                lblFirst.Visible = true;
                tbFirst.Visible = true;
                lblSecond.Visible = false;
                tbSecond.Visible = false;
                lblThird.Visible = false;
                tbThird.Visible = false;
                lblForth.Visible = false;
                tbFouth.Visible = false;

            }
            if (cbTypeVideo.SelectedIndex == 1)
            {
                lblFirst.Text = "Исполнитель";
                lblFirst.Visible = true;
                tbFirst.Visible = true;
                lblSecond.Text = "Автор произведения";
                lblSecond.Visible = true;
                tbSecond.Visible = true;
                lblThird.Visible = false;
                tbThird.Visible = false;
                lblForth.Visible = false;
                tbFouth.Visible = false;
            }
            if (cbTypeVideo.SelectedIndex == 2)
            {
                lblFirst.Text = "Название киностудии";
                lblFirst.Visible = true;
                tbFirst.Visible = true;
                lblSecond.Text = "Фамилия режиссера";
                lblSecond.Visible = true;
                tbSecond.Visible = true;
                lblThird.Text = "Имя режиссера";
                lblThird.Visible = true;
                tbThird.Visible = true;
                lblForth.Text = "Отчество режиссера";
                lblForth.Visible = true;
                tbFouth.Visible = true;
            }
        }
    }
}
