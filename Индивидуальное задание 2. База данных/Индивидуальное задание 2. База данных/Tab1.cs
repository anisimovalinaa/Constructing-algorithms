using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Индивидуальное_задание_2.База_данных
{
    public partial class Tab1 : Form
    {
        public Tab1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Out_Click(object sender, EventArgs e)
        {
            string host = "127.0.0.1"; // Имя локального компьютера
            string database = "insurance company"; // Имя базы данных
            string user = "root"; // Имя пользователя

            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user;

            // Создаем соединение с базой данных
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            mysql_connection.Open();

            

            string sql1 = "SELECT id FROM client";
            MySqlCommand command1 = new MySqlCommand(sql1, mysql_connection);
            // выполняем запрос и получаем ответ
            string id = command1.ExecuteScalar().ToString();

            string sql2 = "SELECT name FROM client";
            MySqlCommand command2 = new MySqlCommand(sql2, mysql_connection);
            string name = command2.ExecuteScalar().ToString();

            string sql3 = "SELECT adress FROM client";
            MySqlCommand command3 = new MySqlCommand(sql3, mysql_connection);
            string adress = command3.ExecuteScalar().ToString();

            string sql4 = "SELECT phoneNumber FROM client";
            MySqlCommand command4 = new MySqlCommand(sql4, mysql_connection);
            string phoneNumber = command4.ExecuteScalar().ToString();

            string sql5 = "SELECT INN FROM client";
            MySqlCommand command5 = new MySqlCommand(sql5, mysql_connection);
            string inn = command5.ExecuteScalar().ToString();


            // закрываем соединение с БД
            mysql_connection.Close();

            table.Rows.Add(id,name,adress,phoneNumber,inn);
            //table["name", table.Rows.Count - 1].Value = "Kahd";
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            string host = "127.0.0.1"; // Имя локального компьютера
            string database = "insurance company"; // Имя базы данных
            string user = "root"; // Имя пользователя

            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);

            //table.Rows.Add();
            try
            {
                mysql_connection.Open();
                MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT * FROM client", Connect);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                table.DataSource = DATA;
                mysql_connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysql_connection.Close();
            }
        }
    }
}
