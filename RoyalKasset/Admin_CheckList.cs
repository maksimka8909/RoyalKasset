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
    public partial class Admin_CheckList : Form
    {
        public Admin_CheckList()
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
        ///  Метод, в котором осуществляется загрузка в датагрид таблицы из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_CheckList_Load(object sender, EventArgs e)
        {
            DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
                $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
                $"[dbo].[Zayavka].[Stoimost] as 'Стоимость', " +
                $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
                $"[dbo].[Klient].[Imya] as 'Имя', " +
                $"[dbo].[Chek].[Data_Formirovania] as 'Дата' " +
                $"FROM[dbo].[Chek] " +
                $"LEFT JOIN[dbo].[Zayavka] ON[dbo].[Zayavka].[IDZayavki] = [dbo].[Chek].[IDZayavki] " +
                $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
                $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
                $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie]",dgvCheckList);
        }
        /// <summary>
        /// Метод, изменяющий содержимое датагрида по дате через наличия или отсутствие флажка  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilter.Checked==true)
            {
                DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
                $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
                $"[dbo].[Zayavka].[Stoimost] as 'Стоимость', " +
                $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
                $"[dbo].[Klient].[Imya] as 'Имя', " +
                $"[dbo].[Chek].[Data_Formirovania] as 'Дата' " +
                $"FROM[dbo].[Chek] " +
                $"LEFT JOIN[dbo].[Zayavka] ON[dbo].[Zayavka].[IDZayavki] = [dbo].[Chek].[IDZayavki] " +
                $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
                $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
                $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
                $"WHERE [dbo].[Chek].[Data_Formirovania]='{dtpData.Value}'", dgvCheckList);
            }
            else
            {
                DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
                $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
                $"[dbo].[Zayavka].[Stoimost] as 'Стоимость', " +
                $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
                $"[dbo].[Klient].[Imya] as 'Имя', " +
                $"[dbo].[Chek].[Data_Formirovania] as 'Дата' " +
                $"FROM[dbo].[Chek] " +
                $"LEFT JOIN[dbo].[Zayavka] ON[dbo].[Zayavka].[IDZayavki] = [dbo].[Chek].[IDZayavki] " +
                $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
                $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
                $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie]", dgvCheckList);
            }
        }
        /// <summary>
        /// Метод, изменяющий содержимое датагрида по дате через если есть флажок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpData_ValueChanged(object sender, EventArgs e)
        {
            if (cbFilter.Checked == true)
            {
                DataBaseHelper.GetList($"SELECT [dbo].[Obshaya_Harakteristika].[Naimenovanie] as 'Название фильма', " +
                $"[dbo].[Izdanie].[Tip_Nositelya] as 'Носитель', " +
                $"[dbo].[Zayavka].[Stoimost] as 'Стоимость', " +
                $"[dbo].[Klient].[Familiya] as 'Фамилия', " +
                $"[dbo].[Klient].[Imya] as 'Имя', " +
                $"[dbo].[Chek].[Data_Formirovania] as 'Дата' " +
                $"FROM[dbo].[Chek] " +
                $"LEFT JOIN[dbo].[Zayavka] ON[dbo].[Zayavka].[IDZayavki] = [dbo].[Chek].[IDZayavki] " +
                $"LEFT JOIN[dbo].[Klient] ON[dbo].[Klient].[IDKlienta] = [dbo].[Zayavka].[IDKlienta] " +
                $"LEFT JOIN[dbo].[Obshaya_Harakteristika] ON[dbo].[Obshaya_Harakteristika].[IDObshaya_Harakteristika] = [dbo].[Zayavka].[IDObshaya_Harakteristika] " +
                $"LEFT JOIN[dbo].[Izdanie] ON[dbo].[Izdanie].[IDIzdanie] = [dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
                $"WHERE [dbo].[Chek].[Data_Formirovania]='{dtpData.Value}'", dgvCheckList);
            }
           
        }
    }
}
