namespace General
{
    public partial class WelcomeNom : Form
    {
        public WelcomeNom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // laisser vide ou ajouter du code
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
