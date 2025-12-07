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
    public partial class ChangingPlaces : Form
    {
        public ChangingPlaces()
        {
            InitializeComponent();
        }

        private void ChangingPlaces_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("La Liste est Vide.");
            }
            else if (listBox1.SelectedItem != null)
            {
                {
                    //listBox2.Items.Add(listBox1.Items[0]);
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("La Liste est Vide!!!");
            }

            else if (listBox2.SelectedItem != null)
            {
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Liste est Vide !!!");
            }
            else
                while (listBox1.Items.Count > 0)
                {
                    listBox2.Items.Add(listBox1.Items[0]);
                    listBox1.Items.Remove(listBox1.Items[0]);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.Items.Count == 0)
            {
                MessageBox.Show("Liste est Vide !!!");
            }
            else
            {
                while(listBox2.Items.Count > 0)
                {
                    listBox1.Items.Add(listBox2.Items[0]);
                    listBox2.Items.Remove(listBox2.Items[0]);
                }
            }
        }
    }
}
