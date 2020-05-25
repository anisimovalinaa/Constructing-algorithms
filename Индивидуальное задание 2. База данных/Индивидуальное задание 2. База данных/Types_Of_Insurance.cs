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
    public partial class Types_Of_Insurance : Form
    {
        public Types_Of_Insurance()
        {
            InitializeComponent();
            table.Font = new Font("Times New Roman", 10, table.Font.Style);
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM type_of_insurance";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["id", table.Rows.Count - 1].Value = reader[0].ToString();
                table["name", table.Rows.Count - 1].Value = reader[1].ToString();
            }
            reader.Close();
            connection.Close();
        }
    }
}
