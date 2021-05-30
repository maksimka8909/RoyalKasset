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
    public partial class Cashier_Execution : Form
    {
        public Cashier_Execution()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Заполняет датагрид
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cashier_Execution_Load(object sender, EventArgs e)
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
                $"WHERE [dbo].[Zayavka].[Activnost] = 'не активна'", dgvListRequest);
            dgvListRequest.Columns[9].Visible = false;
        }
        /// <summary>
        /// Переход на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Cashier_Ordering cashier_Ordering = new Cashier_Ordering();
            this.Hide();
            this.Close();
            cashier_Ordering.ShowDialog();
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от наличия флажка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFilter.Checked == true)
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
                $"WHERE [dbo].[Zayavka].[Data_Formirovaniya] = '{dtpData.Value}' AND [dbo].[Zayavka].[Activnost] = 'не активна'", dgvListRequest);
            }
            else
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
                $"WHERE [dbo].[Zayavka].[Activnost] = 'не активна'", dgvListRequest);
            }
        }
        /// <summary>
        /// Фильтрует таблицу из датагрид в зависимости от выбранного элемента в дататаймпикеры и наличия флажка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpData_ValueChanged(object sender, EventArgs e)
        {
            if (cbFilter.Checked == true)
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
                $"WHERE [dbo].[Zayavka].[Data_Formirovaniya] = '{dtpData.Value}' AND [dbo].[Zayavka].[Activnost] = 'не активна'", dgvListRequest);
            }
        }
        /// <summary>
        /// Осуществляется запись чека и изменение статуса заявки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseRequest_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvListRequest.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                    DataBaseHelper.executeQuerry($"INSERT INTO Chek(IDZayavki,Data_Formirovania,Summa) " +
                        $"VALUES " +
                        $"({dgvListRequest.CurrentRow.Cells[9].Value},'{DateTime.Today}','{dgvListRequest.CurrentRow.Cells[1].Value}')" +
                        $"UPDATE [dbo].[Zayavka]" +
                        $"SET Activnost='активна' " +
                        $"WHERE IDZayavki={dgvListRequest.CurrentRow.Cells[9].Value}");
                    cbFilter.Checked = false;
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
                    $"WHERE [dbo].[Zayavka].[Activnost] = 'не активна'", dgvListRequest);

                    MessageBox.Show("Заявка закрыта");
                
            }
            else
            {
                MessageBox.Show("Вы не выбрали заявку");
            }
        }
    }
}
