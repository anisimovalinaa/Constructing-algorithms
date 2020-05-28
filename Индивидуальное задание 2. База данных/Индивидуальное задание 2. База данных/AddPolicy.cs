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
    public partial class AddPolicy : Form
    {
        public AddPolicy(DataGridView table)
        {
            InitializeComponent();
            this.table = table;
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            label6.Font = new Font("Times New Roman", 10, label6.Font.Style);
            label7.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label8.Font = new Font("Times New Roman", 10, label8.Font.Style);
            label9.Font = new Font("Times New Roman", 10, label9.Font.Style);
            add.Font = new Font("Times New Roman", 12, add.Font.Style);
            customer.Font = new Font("Times New Roman", 10, customer.Font.Style);
            insEvent.Font = new Font("Times New Roman", 10, insEvent.Font.Style);
            begin.Font = new Font("Times New Roman", 10, begin.Font.Style);
            end.Font = new Font("Times New Roman", 10, end.Font.Style);
            agent.Font = new Font("Times New Roman", 10, agent.Font.Style);
            amount.Font = new Font("Times New Roman", 10, amount.Font.Style);
            payments.Font = new Font("Times New Roman", 10, payments.Font.Style);
            status.Font = new Font("Times New Roman", 10, status.Font.Style);
            date.Font = new Font("Times New Roman", 10, date.Font.Style);
        }
        DataGridView table;
        private void add_Click(object sender, EventArgs e)
        {
            if (customer.Text != "" && insEvent.Text != "" && begin.Text != "" && end.Text != "" && agent.Text != "" && 
                amount.Text != "" && payments.Text != "" && status.Text != "" && date.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`insurance_policy` (`customer` ,`insurance_event` ,`begin`, `end` ,`agent` ,`amount`,'payments','date','status')" +
                "VALUES('" + customer.Text + "', '" + insEvent.Text + "', '" + begin.Text + "', '" + end.Text + "', '" + agent.Text +
                "', '" + amount.Text + "', '" + payments.Text + "', '" + date.Text + "', '" + status.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM insurance_policy";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                table.Rows.Add();

                while (reader.Read())
                {
                    table["number", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["customer", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["insEvent", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["begin", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["end", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["agent", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["amount", table.Rows.Count - 1].Value = reader[6].ToString();
                    table["payments", table.Rows.Count - 1].Value = reader[7].ToString();
                    table["date", table.Rows.Count - 1].Value = reader[8].ToString();
                    table["status", table.Rows.Count - 1].Value = reader[9].ToString();
                }
                reader.Close();
                connection.Close();
                customer.Clear();
                insEvent.Clear();
                begin.Clear();
                end.Clear();
                agent.Clear();
                amount.Clear();
                payments.Clear();
                date.Clear();
                status.Clear();
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
