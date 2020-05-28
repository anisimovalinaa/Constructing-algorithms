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
    public partial class AddEvent : Form
    {
        public AddEvent(DataGridView table)
        {
            InitializeComponent();
            this.table = table;

            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            add.Font = new Font("Times New Roman", 12, add.Font.Style);
            id.Font = new Font("Times New Roman", 10, id.Font.Style);
            name.Font = new Font("Times New Roman", 10, name.Font.Style);
        }

        DataGridView table;
        private void add_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && name.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`insurance_event` (`id_types` ,`name`)" +
                "VALUES('" + id.Text + "', '" + name.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM insurance_event";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                table.Rows.Add();

                while(reader.Read())
                {
                    table["id_type", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["id_event", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["name1", table.Rows.Count - 1].Value = reader[2].ToString();
                }
                reader.Close();
                connection.Close();
            }
            else MessageBox.Show("Необходимо заполнить все поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            name.Clear();
            id.Clear();
        }
    }
}
