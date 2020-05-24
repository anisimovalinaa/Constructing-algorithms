using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Индивидуальное_задание_2.База_данных
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());          
        }

        public static MySqlConnection Conn ()
        {
            string host = "127.0.0.1"; // Имя локального компьютера
            string database = "insurance company"; // Имя базы данных
            string user = "root"; // Имя пользователя

            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            return mysql_connection;
        }
    }
}
