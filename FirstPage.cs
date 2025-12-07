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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            
        }
        public static List<string[]> users = new List<string[]>() {
            new string[] { "coco@example.com", "1234" } 
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string mdp = textBox2.Text;

            foreach (var u in users)
                if (u[0] == textBox1.Text && u[1] == textBox2.Text)
                {
                    new WelcomePage().Show(); this.Hide(); return;
                }
            new Register().Show(); this.Hide();

        }
    }
}
