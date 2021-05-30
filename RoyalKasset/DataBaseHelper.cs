using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalKasset
{
    class DataBaseHelper
    {
        /// <summary>
        /// переменная, хранящая номер текущего сотрудника
        /// </summary>
        public static int idCurrentCassir;
        /// <summary>
        /// переменная, хранящая номер выбрнанного сотрудника
        /// </summary>
        public static int selectedUser = 0;
        /// <summary>
        /// переменная, хранящая строку подключения к базе данных
        /// </summary>
        public static string Connection = @"Data Source=LAPTOP-4QTGR1HP\JARVIS;Initial Catalog=royalekassetDB;Integrated Security=True";
        /*
         * public static string _Connection;
        public static string Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string configConnectionString = ConfigurationManager.ConnectionStrings["DataBaseSQL"].ConnectionString.Replace("$HOST$",Environment.MachineName);
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(configConnectionString);
                    _Connection = builder.ConnectionString;
                }
                return _Connection;
            }
        }
         * */
        /// <summary>
        /// Метод, делающий проверку на наличие записи в базе данных
        /// </summary>
        /// <param name="query">Параметр, в котором хранится запрос базы данных</param>
        /// <returns>Булевое значение</returns>
        public static bool isHere(string query)
        {
            bool check = false;
            SqlConnection sqlConnection = new SqlConnection(Connection);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteScalar() != null)
            {
                check = true;
            }
            sqlConnection.Close();
            return check;
        }
        /// <summary>
        /// Метод, предназнчен для выполнения запроса в базе данных
        /// </summary>
        /// <param name="query">Параметр, хранящий запрос базы данных</param>
        public static void executeQuerry(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection);
            sqlConnection.Open();
            new SqlCommand(query, sqlConnection).ExecuteNonQuery();
            sqlConnection.Close();
        }
        /// <summary>
        /// Метод, предназнчен для выполнения единичного запроса в базе данных
        /// </summary>
        /// <param name="query">Параметр, хранящий запрос базы данных</param>
        public static void executeScalar(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(Connection);
            sqlConnection.Open();
            new SqlCommand(query, sqlConnection).ExecuteScalar();
            sqlConnection.Close();
        }
        /// <summary>
        /// Метод, предназначенный для выгрузки таблицы из базы данных в датагрид
        /// </summary>
        /// <param name="query">Запрос БД</param>
        /// <param name="gridView">DataGridView, в который будет выгружена таблица  </param>
        public static void GetList(String query, DataGridView gridView)
        {
            SqlConnection con = new SqlConnection(Connection);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Contract");
            gridView.DataSource = ds.Tables["Contract"];
            con.Close();
        }
        /// <summary>
        /// Метод, получающий ИД записи
        /// </summary>
        /// <param name="query">Запрос в БД</param>
        /// <returns>Номер записи</returns>
        public static int GetID(String query)
        {
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            con.Close();
            return id;
        }
        /// <summary>
        /// Метод, получающий поле из БД типа decimal
        /// </summary>
        /// <param name="query">Запрос в БД</param>
        /// <returns>Переменную типа decimal</returns>
        public static decimal GetPrice(String query)
        {
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            decimal id = Convert.ToDecimal(sqlCommand.ExecuteScalar());
            con.Close();
            return id;
        }
        /// <summary>
        /// Метод, получающий поле из БД строкового типа
        /// </summary>
        /// <param name="query">Запрос в БД</param>
        /// <returns>Переменную типа string, в которой хранится значение запрашеваемого поля</returns>
        public static string GetField(String query)
        {
            SqlConnection con = new SqlConnection(Connection);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            string id = Convert.ToString(sqlCommand.ExecuteScalar());
            con.Close();
            return id;
        }
    }
}
