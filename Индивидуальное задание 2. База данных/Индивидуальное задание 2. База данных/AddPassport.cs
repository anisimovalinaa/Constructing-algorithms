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
        public AddPassport()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr =
            "INSERT INTO `insurance company`.`passport` (`series` ,`number` ,`issued` ,`birthplace` ,`code` ,`date`)" + 
            "VALUES('" + series.Text + "', '" + number.Text + "', '" + issued.Text + "', '" + birthplace.Text + "', '" + code.Text + 
            "', '" + date.Text + "')";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            com.ExecuteNonQuery();

            connection.Close();
        }
    }
}
