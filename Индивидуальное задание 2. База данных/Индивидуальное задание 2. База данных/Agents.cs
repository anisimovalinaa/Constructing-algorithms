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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            table.Font = new Font("Times New Roman", 10, table.Font.Style);
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            show.Font = new Font("Times New Roman", 10, show.Font.Style);
            add.Font = new Font("Times New Roman", 10, add.Font.Style);
            delete.Font = new Font("Times New Roman", 10, delete.Font.Style);
            update.Font = new Font("Times New Roman", 10, update.Font.Style);
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            num1.Font = new Font("Times New Roman", 10, num1.Font.Style);
            num2.Font = new Font("Times New Roman", 10, num2.Font.Style);
            value.Font = new Font("Times New Roman", 10, value.Font.Style);
            box.Font = new Font("Times New Roman", 10, box.Font.Style);

            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM agents";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["surname", table.Rows.Count - 1].Value = reader[0].ToString();
                table["name", table.Rows.Count - 1].Value = reader[1].ToString();
                table["middle_name", table.Rows.Count - 1].Value = reader[2].ToString();
                table["sex", table.Rows.Count - 1].Value = reader[3].ToString();
                table["date", table.Rows.Count - 1].Value = reader[4].ToString();
                table["passport", table.Rows.Count - 1].Value = reader[5].ToString();
                table["phone_number", table.Rows.Count - 1].Value = reader[6].ToString();
                table["id_address", table.Rows.Count - 1].Value = reader[7].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM agents";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                    if (table["id_passport", i].Value.ToString() == reader[0].ToString()) check = true;
                if (!check)
                {
                    table.Rows.Add();
                    table["surname", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["name", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["middle_name", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["sex", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["date", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["passport", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["phone_number", table.Rows.Count - 1].Value = reader[6].ToString();
                    table["id_address", table.Rows.Count - 1].Value = reader[7].ToString();
                }
            }
            reader.Close();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (num1.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if ((table["passport", i].Value.ToString() == num1.Text) && !check)
                    {
                        table.Rows.RemoveAt(i);
                        string com = "DELETE FROM agents WHERE passport = '" + num1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        num1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num1.Clear();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (num2.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (value.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (box.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table.Rows.Count; i++)
                    if ((table["id_address", i].Value.ToString() == num2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (box.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE address SET surname = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["surname", i].Value = value.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE address SET name = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["name", i].Value = value.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE address SET middle_name = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["middle_name", i].Value = value.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE address SET sex = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["sex", i].Value = value.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE address SET date = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["date", i].Value = value.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE address SET passport = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["passport", i].Value = value.Text; break;
                                }
                            case 6:
                                {
                                    com = "UPDATE address SET phone_number = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["phone_number", i].Value = value.Text; break;
                                }
                            case 7:
                                {
                                    com = "UPDATE address SET id_address = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["id_address", i].Value = value.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                num2.Clear();
                value.Clear();
            }
        }
    }
}
