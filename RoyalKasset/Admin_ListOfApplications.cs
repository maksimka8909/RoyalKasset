using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalKasset
{
    public partial class Admin_ListOfApplications : Form
    {
        public Admin_ListOfApplications()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открывает предудещую форму
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
        /// Выгружает в датагрид таблицу из БД и заполняет комбобокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_ListOfApplications_Load(object sender, EventArgs e)
        {
            cbActivity.Items.Add("не выбрано");
            cbActivity.Items.Add("активна");
            cbActivity.Items.Add("не активна");
            cbActivity.SelectedIndex = 0;
            DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
               $"[dbo].[Zayavka].[Stoimost] as 'Стоимость'," +
               $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
               $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
               $"[dbo].[Klient].[Imya] as 'Имя', " +
               $"[dbo].[Zayavka].[Data_Formirovaniya] as 'Дата формирования', " +
               $"[dbo].[Zayavka].[Data_Okanchaniya] as 'Дата окончания', " +
               $"[dbo].[Zayavka].[Zadoljennost] as 'Задолжность', " +
               $"[dbo].[Zayavka].[Activnost] as 'Активность', " +
               $"[dbo].[Zayavka].[IDZayavki] as 'ID' FROM[dbo].[Zayavka] " +
               $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
               $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
               $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie]", dgvRequestList);
            dgvRequestList.Columns[9].Visible = false;
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от выбранного элемента в комбобоксе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbActivity.SelectedIndex==0)
            {
                DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
               $"[dbo].[Zayavka].[Stoimost] as 'Стоимость'," +
               $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
               $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
               $"[dbo].[Klient].[Imya] as 'Имя', " +
               $"[dbo].[Zayavka].[Data_Formirovaniya] as 'Дата формирования', " +
               $"[dbo].[Zayavka].[Data_Okanchaniya] as 'Дата окончания', " +
               $"[dbo].[Zayavka].[Zadoljennost] as 'Задолжность', " +
               $"[dbo].[Zayavka].[Activnost] as 'Активность', " +
               $"[dbo].[Zayavka].[IDZayavki] as 'ID' FROM[dbo].[Zayavka] " +
               $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
               $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
               $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie]", dgvRequestList);
                dgvRequestList.Columns[9].Visible = false;
            }
            if (cbActivity.SelectedIndex == 1)
            {
                DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
               $"[dbo].[Zayavka].[Stoimost] as 'Стоимость'," +
               $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
               $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
               $"[dbo].[Klient].[Imya] as 'Имя', " +
               $"[dbo].[Zayavka].[Data_Formirovaniya] as 'Дата формирования', " +
               $"[dbo].[Zayavka].[Data_Okanchaniya] as 'Дата окончания', " +
               $"[dbo].[Zayavka].[Zadoljennost] as 'Задолжность', " +
               $"[dbo].[Zayavka].[Activnost] as 'Активность', " +
               $"[dbo].[Zayavka].[IDZayavki] as 'ID' FROM[dbo].[Zayavka] " +
               $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
               $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
               $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
               $"WHERE [dbo].[Zayavka].[Activnost]='активна'", dgvRequestList);
                dgvRequestList.Columns[9].Visible = false;
            }
            if (cbActivity.SelectedIndex == 2)
            {
                DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
               $"[dbo].[Zayavka].[Stoimost] as 'Стоимость'," +
               $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
               $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
               $"[dbo].[Klient].[Imya] as 'Имя', " +
               $"[dbo].[Zayavka].[Data_Formirovaniya] as 'Дата формирования', " +
               $"[dbo].[Zayavka].[Data_Okanchaniya] as 'Дата окончания', " +
               $"[dbo].[Zayavka].[Zadoljennost] as 'Задолжность', " +
               $"[dbo].[Zayavka].[Activnost] as 'Активность', " +
               $"[dbo].[Zayavka].[IDZayavki] as 'ID' FROM[dbo].[Zayavka] " +
               $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
               $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
               $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
               $"WHERE [dbo].[Zayavka].[Activnost]='не активна'", dgvRequestList);
                dgvRequestList.Columns[9].Visible = false;
            }
        }
    }
}
