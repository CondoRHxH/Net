using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General
{
    public partial class InseringData : Form
    {
        public InseringData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nom = textBox2.Text;
            string prenom = textBox3.Text;

            dataGridView1.Rows.Add(id, nom, prenom);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
