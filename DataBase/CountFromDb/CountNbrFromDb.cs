using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace CountFromDb

{
    public partial class CountNbrFromDb : Form
    {
        public CountNbrFromDb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-R2SM92D\SQLEXPRESS;
                   Initial Catalog=Tp.netCount;
                   Trusted_Connection=True;
                   Encrypt=False";

            using (SqlConnection cn = new SqlConnection(con))
            {

                cn.Open();

                string req = "INSERT INTO Professeur(Id_Prof, Nom_Prof, Ville_Prof) VALUES(@id, @nom, @ville)";

                using (SqlCommand camd = new SqlCommand(req, cn))
                {
                    camd.Parameters.AddWithValue("@id", textBox1.Text);
                    camd.Parameters.AddWithValue("@nom", textBox2.Text);
                    camd.Parameters.AddWithValue("@ville", textBox3.Text);


                    camd.ExecuteNonQuery();

                    textBox1.Clear();
                    textBox2.Clear();
                }


                string query = "SELECT COUNT(*) FROM Professeur";
                SqlCommand cmd = new SqlCommand(query, cn);

                int count = (int)cmd.ExecuteScalar();
                cn.Close();
                MessageBox.Show("Nombre des Prof : " + count);
                label5.Text = count.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
