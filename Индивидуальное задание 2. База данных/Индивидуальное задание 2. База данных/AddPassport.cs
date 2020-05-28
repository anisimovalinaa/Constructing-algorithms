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
    public partial class AddPassport : Form
    {
        public AddPassport(DataGridView table)
        {
            InitializeComponent();
            this.table = table;
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            label6.Font = new Font("Times New Roman", 10, label6.Font.Style);
            add.Font = new Font("Times New Roman", 12, add.Font.Style);
            series.Font = new Font("Times New Roman", 10, series.Font.Style);
            number.Font = new Font("Times New Roman", 10, number.Font.Style);
            code.Font = new Font("Times New Roman", 10, code.Font.Style);
            issued.Font = new Font("Times New Roman", 10, issued.Font.Style);
            birthplace.Font = new Font("Times New Roman", 10, birthplace.Font.Style);
            date.Font = new Font("Times New Roman", 10, date.Font.Style);
        }

        DataGridView table;
        private void add_Click(object sender, EventArgs e)
        {
            if (series.Text != "" && number.Text != "" && issued.Text != "" && birthplace.Text != "" && code.Text != "" && date.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`passport` (`series` ,`number` ,`issued` ,`birthplace` ,`code` ,`date`)" +
                "VALUES('" + series.Text + "', '" + number.Text + "', '" + issued.Text + "', '" + birthplace.Text + "', '" + code.Text +
                "', '" + date.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM passport";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                table.Rows.Add();

                while (reader.Read())
                {
                    table["id_passport", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["series", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["number1", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["issued", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["birthplace", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["code", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["date1", table.Rows.Count - 1].Value = reader[6].ToString();
                }

                reader.Close();
                connection.Close();
                series.Clear();
                number.Clear();
                issued.Clear();
                birthplace.Clear();
                code.Clear();
                date.Clear();
            }
            else MessageBox.Show("Необходимо заполнить все поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
