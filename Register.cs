using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace General
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstPage.users.Add(new string[] { textBox1.Text, textBox2.Text });
            MessageBox.Show("You are now registered!!!");
            new FirstPage().Show(); this.Hide();

            FirstPage f1 = new FirstPage();
            f1.Show(); 
            this.Hide();
        }
    }
}
