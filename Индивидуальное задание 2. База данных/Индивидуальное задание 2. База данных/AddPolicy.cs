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
                "INSERT INTO `insurance company`.`insurance_policy` (`customer` ,`insurance_event` ,`begin`, `end` ,`agent` ,`amount`,`payments`,`date`,`status`)" +
                "VALUES('" + customer.Text + "', '" + insEvent.Text + "', '" + begin.Text + "', '" + end.Text + "', '" + agent.Text +
                "', '" + amount.Text + "', '" + payments.Text + "', '" + date.Text + "', '" + status.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM insurance_policy";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                table.Rows.Add();
                string id = "";
                while (reader.Read())
                {
                    id = reader[0].ToString();
                }
                reader.Close();

                string comStr1 = "SELECT a.number, b.series, b.number, e.name, a.begin, a.end, p.series, p.number, a.amount, a.payments, a.date, a.status " +
                    "FROM `insurance_policy` a " +
                    "LEFT OUTER JOIN `passport` b ON b.id_passport = a.customer " +
                    "LEFT OUTER JOIN `passport` p ON p.id_passport = a.agent " +
                    "LEFT OUTER JOIN `insurance_event` e ON e.id_event = a.insurance_event " +
                    "WHERE a.number = " + id;
                MySqlCommand com1 = new MySqlCommand(comStr1, connection);
                MySqlDataReader reader1 = com1.ExecuteReader();

                while (reader1.Read())
                {
                    table["number", table.Rows.Count - 1].Value = reader1[0].ToString();
                    table["series1", table.Rows.Count - 1].Value = reader1[1].ToString();
                    table["number11", table.Rows.Count - 1].Value = reader1[2].ToString();
                    table["insEvent", table.Rows.Count - 1].Value = reader1[3].ToString();
                    table["begin", table.Rows.Count - 1].Value = reader1[4].ToString();
                    table["end", table.Rows.Count - 1].Value = reader1[5].ToString();
                    table["series2", table.Rows.Count - 1].Value = reader1[6].ToString();
                    table["number22", table.Rows.Count - 1].Value = reader1[7].ToString();
                    table["amount", table.Rows.Count - 1].Value = reader1[8].ToString();
                    table["payments", table.Rows.Count - 1].Value = reader1[9].ToString();
                    table["date", table.Rows.Count - 1].Value = reader1[10].ToString();
                    table["status", table.Rows.Count - 1].Value = reader1[11].ToString();
                }
                reader1.Close();
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
