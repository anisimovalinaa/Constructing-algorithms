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
    public partial class Passports : Form
    {
        public Passports()
        {
            InitializeComponent();
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM passport";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["id_passport", table.Rows.Count - 1].Value = reader[0].ToString();
                table["series", table.Rows.Count - 1].Value = reader[1].ToString();
                table["number", table.Rows.Count - 1].Value = reader[2].ToString();
                table["issued", table.Rows.Count - 1].Value = reader[3].ToString();
                table["birthplace", table.Rows.Count - 1].Value = reader[4].ToString();
                table["code", table.Rows.Count - 1].Value = reader[5].ToString();
                table["date", table.Rows.Count - 1].Value = reader[6].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM passport";
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
                        table["id_passport", table.Rows.Count - 1].Value = reader[0].ToString();
                        table["series", table.Rows.Count - 1].Value = reader[1].ToString();
                        table["number", table.Rows.Count - 1].Value = reader[2].ToString();
                        table["issued", table.Rows.Count - 1].Value = reader[3].ToString();
                        table["birthplace", table.Rows.Count - 1].Value = reader[4].ToString();
                        table["code", table.Rows.Count - 1].Value = reader[5].ToString();
                        table["date", table.Rows.Count - 1].Value = reader[6].ToString();
                }
            }
            reader.Close();
            connection.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddPassport form = new AddPassport();
            form.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (num1.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if ((table["id_passport", i].Value.ToString() == num1.Text) && !check)
                    {
                        table.Rows.RemoveAt(i);
                        string com = "DELETE FROM passport WHERE id_passport = '" + num1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        num1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if ((table["id_passport", i].Value.ToString() == num2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (box.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE passport SET series = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["series", i].Value = value.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE passport SET number = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["number", i].Value = value.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE passport SET issued = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["issued", i].Value = value.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE passport SET birthplace = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["birthplace", i].Value = value.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE passport SET code = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["code", i].Value = value.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE passport SET date = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["date", i].Value = value.Text; break;
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
