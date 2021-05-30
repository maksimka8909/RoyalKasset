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
    public partial class Storekeeper_DetailedView : Form
    {
        public Storekeeper_DetailedView()
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
            Storekeeper_List storekeeper_List = new Storekeeper_List();
            this.Hide();
            this.Close();
            storekeeper_List.ShowDialog();
        }
        /// <summary>
        /// Выгрузка данных из БД в текстбоксы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Storekeeper_DetailedView_Load(object sender, EventArgs e)
        {
            tbDuration.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Prodoljitelnost " +
               $"FROM [dbo].[Obshaya_Harakteristika] WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbAmount.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Kolichestvo " +
               $"FROM [dbo].[Obshaya_Harakteristika] WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbFilmName.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Naimenovanie " +
               $"FROM [dbo].[Obshaya_Harakteristika] WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbGenre.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Janr " +
               $"FROM [dbo].[Obshaya_Harakteristika] WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbYearOfRealese.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT God_Vipuska " +
               $"FROM [dbo].[Obshaya_Harakteristika] WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbPrice.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT Cena " +
               $"FROM [dbo].[Obshaya_Harakteristika] WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbEdition.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT [dbo].[Izdanie].[Nazvanie_Izdaniya] " +
               $"FROM [dbo].[Obshaya_Harakteristika] " +
               $"LEFT JOIN [dbo].[Izdanie] ON [dbo].[Izdanie].[IDIzdanie] =[dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
               $"WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
            tbTypeOfCarrier.Text = Convert.ToString(DataBaseHelper.GetField($"SELECT [dbo].[Izdanie].[Tip_Nositelya] " +
               $"FROM [dbo].[Obshaya_Harakteristika] " +
               $"LEFT JOIN [dbo].[Izdanie] ON [dbo].[Izdanie].[IDIzdanie] =[dbo].[Obshaya_Harakteristika].[IDIzdanie] " +
               $"WHERE IDObshaya_Harakteristika ={DataBaseHelper.selectedUser}"));
        }
    }
}
