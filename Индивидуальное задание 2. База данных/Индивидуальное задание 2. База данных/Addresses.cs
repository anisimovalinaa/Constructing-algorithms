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
    public partial class Addresses : Form
    {
        public Addresses()
        {
            InitializeComponent();
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM address";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["id_address", table.Rows.Count - 1].Value = reader[0].ToString();
                table["country", table.Rows.Count - 1].Value = reader[1].ToString();
                table["city", table.Rows.Count - 1].Value = reader[2].ToString();
                table["street", table.Rows.Count - 1].Value = reader[3].ToString();
                table["number", table.Rows.Count - 1].Value = reader[4].ToString();
                table["flat", table.Rows.Count - 1].Value = reader[5].ToString();
                table["postcode", table.Rows.Count - 1].Value = reader[6].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM address";
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
                    table["id_address", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["country", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["city", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["street", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["number", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["flat", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["postcode", table.Rows.Count - 1].Value = reader[6].ToString();
                }
            }
            reader.Close();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (num1.Text == "") MessageBox.Show("Введите ID адреса!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if ((table["id_address", i].Value.ToString() == num1.Text) && !check)
                    {
                        table.Rows.RemoveAt(i);
                        string com = "DELETE FROM address WHERE id_address = '" + num1.Text + "'";

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
            if (num2.Text == "") MessageBox.Show("Введите ID адреса!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    com = "UPDATE address SET country = '" + value.Text + "' WHERE id_address = '" + num2.Text + "'";
                                    table["country", i].Value = value.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE address SET city = '" + value.Text + "' WHERE id_address = '" + num2.Text + "'";
                                    table["city", i].Value = value.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE address SET street = '" + value.Text + "' WHERE id_address = '" + num2.Text + "'";
                                    table["street", i].Value = value.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE address SET number = '" + value.Text + "' WHERE id_address = '" + num2.Text + "'";
                                    table["number", i].Value = value.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE address SET flat = '" + value.Text + "' WHERE id_address = '" + num2.Text + "'";
                                    table["flat", i].Value = value.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE address SET postcode = '" + value.Text + "' WHERE id_address = '" + num2.Text + "'";
                                    table["postcode", i].Value = value.Text; break;
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

        private void add_Click(object sender, EventArgs e)
        {
            AddAddress form = new AddAddress();
            form.Show();
        }
    }
}
