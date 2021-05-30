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
    public partial class Storekeeper_List : Form
    {
        /// <summary>
        /// Запрос в БД
        /// </summary>
        string request = $"SELECT " +
            $"[dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
            $"[dbo].[Obshaya_Harakteristika].[Cena] as 'Стоимость', " +
            $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
            $"[dbo].[Obshaya_Harakteristika].[Janr] as 'Жанр', " +
            $"[dbo].[Izdanie].[Nazvanie_Izdaniya] as 'Издание', " +
            $"[dbo].[Obshaya_Harakteristika].[God_Vipuska] as 'Год выпуска', " +
            $"[dbo].[Obshaya_Harakteristika].[Kolichestvo] as 'Количество', " +
            $"[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] as 'ID' " +
            $"FROM[dbo].[Obshaya_Harakteristika] " +
            $"LEFT JOIN[dbo].[Izdanie] ON [dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
            $"WHERE 1=1"; 
        public Storekeeper_List()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выход на предыдущую форму
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
        /// Выгрузка данных из БД в датагрид и комбобоксы, заполнение комбобоксов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Storekeeper_List_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(DataBaseHelper.Connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"Select 0 as 'ID', 'Все издания' as 'Name' " +
                $" UNION SELECT IDIzdanie, Nazvanie_Izdaniya from[dbo].[Izdanie] ", sqlConnection);
            da.Fill(dataSet, "Editions");
            da = new SqlDataAdapter($"SELECT 0 as 'Year' " +
                $"UNION SELECT God_Vipuska FROM [dbo].[Obshaya_Harakteristika] ", sqlConnection);
            da.Fill(dataSet, "Years");
            cbEdition.DataSource = dataSet.Tables["Editions"];
            cbEdition.DisplayMember = "Name";
            cbEdition.ValueMember = "Name";
            List<string> lYears = new List<string>();
            lYears.Add("Все года");
            for (int i = 1; i < dataSet.Tables["Years"].Rows.Count; i++)
            {
                lYears.Add(dataSet.Tables["Years"].Rows[i][0].ToString());
            }
            cbYearOfRealese.DataSource = lYears;
            cbTypeOfCarrier.Items.Add("Все типы");
            cbTypeOfCarrier.Items.Add("DVD");
            cbTypeOfCarrier.Items.Add("CD");
            cbTypeOfCarrier.Items.Add("VHS");
            cbGenge.Items.Add("Все жанры");
            cbGenge.Items.Add("Ужасы");
            cbGenge.Items.Add("Драма");
            cbGenge.Items.Add("Комедия");
            cbGenge.Items.Add("Триллер");
            cbGenge.Items.Add("Боевик");
            cbGenge.Items.Add("Мелодрама");
            cbGenge.Items.Add("Детектив");
            cbGenge.Items.Add("Мюзикл");
            cbGenge.Items.Add("Приключения");
            cbGenge.Items.Add("Фантастика");
            cbGenge.SelectedIndex = 0;
            cbEdition.SelectedIndex = 0;
            cbYearOfRealese.SelectedIndex = 0;
            cbTypeOfCarrier.SelectedIndex = 0;
            DataBaseHelper.GetList(request,dgvListEmployers);
            dgvListEmployers.Columns[7].Visible = false;
        }
        /// <summary>
        /// Переход на новую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Storekeeper_Add storekeeper_Add = new Storekeeper_Add();
            this.Hide();
            this.Close();
            storekeeper_Add.ShowDialog();
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от выбранного элемента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbGenge_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter=request;
                if (cbGenge.SelectedIndex > 0)
                {
                    filter += $" AND [dbo].[Obshaya_Harakteristika].[Janr] ='{cbGenge.SelectedItem.ToString()}' ";
                }
                if (cbEdition.SelectedIndex > 0)
                {
                    filter += $" AND [dbo].[Izdanie].[Nazvanie_Izdaniya] ='{cbEdition.SelectedValue}' ";
                }
                if (cbTypeOfCarrier.SelectedIndex > 0)
                {
                    filter += $" AND [dbo].[Izdanie].[Tip_Nositelya] ='{cbTypeOfCarrier.SelectedItem.ToString()}' ";
                }
                if (cbYearOfRealese.SelectedIndex > 0)
                {
                    filter += $" AND [dbo].[Obshaya_Harakteristika].[God_Vipuska] ='{cbYearOfRealese.SelectedItem.ToString()}' ";
                }

                DataBaseHelper.GetList(filter, dgvListEmployers);
           
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от выбранного элемента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = request;
            if (cbGenge.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Obshaya_Harakteristika].[Janr] ='{cbGenge.SelectedItem.ToString()}' ";
            }
            if (cbEdition.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Izdanie].[Nazvanie_Izdaniya] ='{cbEdition.SelectedValue}' ";
            }
            if (cbTypeOfCarrier.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Izdanie].[Tip_Nositelya] ='{cbTypeOfCarrier.SelectedItem.ToString()}' ";
            }
            if (cbYearOfRealese.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Obshaya_Harakteristika].[God_Vipuska] ='{cbYearOfRealese.SelectedItem.ToString()}' ";
            }

            DataBaseHelper.GetList(filter, dgvListEmployers);
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от выбранного элемента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbYearOfRealese_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = request;
            if (cbGenge.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Obshaya_Harakteristika].[Janr] ='{cbGenge.SelectedItem.ToString()}' ";
            }
            if (cbEdition.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Izdanie].[Nazvanie_Izdaniya] ='{cbEdition.SelectedValue}' ";
            }
            if (cbTypeOfCarrier.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Izdanie].[Tip_Nositelya] ='{cbTypeOfCarrier.SelectedItem.ToString()}' ";
            }
            if (cbYearOfRealese.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Obshaya_Harakteristika].[God_Vipuska] ='{cbYearOfRealese.SelectedItem.ToString()}' ";
            }

            DataBaseHelper.GetList(filter, dgvListEmployers);
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от выбранного элемента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbTypeOfCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = request;
            if (cbGenge.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Obshaya_Harakteristika].[Janr] ='{cbGenge.SelectedItem.ToString()}' ";
            }
            if (cbEdition.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Izdanie].[Nazvanie_Izdaniya] ='{cbEdition.SelectedValue}' ";
            }
            if (cbTypeOfCarrier.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Izdanie].[Tip_Nositelya] ='{cbTypeOfCarrier.SelectedItem.ToString()}' ";
            }
            if (cbYearOfRealese.SelectedIndex > 0)
            {
                filter += $" AND [dbo].[Obshaya_Harakteristika].[God_Vipuska] ='{cbYearOfRealese.SelectedItem.ToString()}' ";
            }
            DataBaseHelper.GetList(filter, dgvListEmployers);
        }
        /// <summary>
        /// Открытие новой формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoreInfo_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvListEmployers.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                DataBaseHelper.selectedUser = Convert.ToInt32(dgvListEmployers.CurrentRow.Cells[7].Value.ToString());
                Storekeeper_DetailedView storekeeper_DetailedView = new Storekeeper_DetailedView();
                this.Hide();
                this.Close();
                storekeeper_DetailedView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку");
            }
        }
        /// <summary>
        /// Удаление видеоматериала с БД если выбрана запись в датагрид
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
                    DataBaseHelper.executeQuerry($"DELETE [dbo].[HudIDokFilmIMultfilm]  " +
                        $"WHERE [dbo].[HudIDokFilmIMultfilm].[IDObshaya_Harakteristika] ={dgvListEmployers.CurrentRow.Cells[7].Value.ToString()} " +
                        $"DELETE [dbo].[Musikalnaya_Kompoziciya] " +
                        $"WHERE [dbo].[Musikalnaya_Kompoziciya].[IDObshaya_Harakteristika] ={dgvListEmployers.CurrentRow.Cells[7].Value.ToString()} " +
                        $"DELETE [dbo].[Razvlekatelnaya_Programma] " +
                        $"WHERE [dbo].[Razvlekatelnaya_Programma].[IDObshaya_Harakteristika] = {dgvListEmployers.CurrentRow.Cells[7].Value.ToString()} " +
                        $"DELETE [dbo].[Obshaya_Harakteristika] " +
                        $"WHERE [dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = {dgvListEmployers.CurrentRow.Cells[7].Value.ToString()}");
                    DataBaseHelper.GetList(request, dgvListEmployers);
                    MessageBox.Show("Видеоматериал успешно удален");
                }
                else
                {
                    MessageBox.Show("Вы не выбрали строку");
                }
            }
            catch
            {
                MessageBox.Show("Удаление невозможно, видеоматериал находится в использовании");
            }
        }
    }
}
