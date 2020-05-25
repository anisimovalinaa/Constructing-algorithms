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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passports_Click(object sender, EventArgs e)
        {
            Passports tab = new Passports();
            tab.Show();
        }

        private void types_Click(object sender, EventArgs e)
        {
            Types_Of_Insurance form = new Types_Of_Insurance();
            form.Show();
        }

        private void events_Click(object sender, EventArgs e)
        {
            Insurance_Events form = new Insurance_Events();
            form.Show();
        }
    }
}
