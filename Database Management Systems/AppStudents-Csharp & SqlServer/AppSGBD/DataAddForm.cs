using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSGBD
{
    public partial class DataAddForm : Form
    {
        public DataAddForm()
        {
            InitializeComponent();
        }

        private void SendDataBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data source=DESKTOP-B63QKOS\BAZADEDATESGBD; Initial Catalog=SGBD2k20; Integrated Security=SSPI")) ;
            {
                try
                {

                    using (var cmd = new SqlCommand("INSERT INTO Studenti (Nume, Prenume, Sex, Varsta, Oras,Engleza,Franceza) VALUES (@Nume,@Prenume,@Sex,@Varsta, @Oras,@Engleza,@Franceza)"))
                    {

                        cmd.Connection = Global.con;
                        cmd.Parameters.AddWithValue("@Nume", NumeTextBox.Text);
                        cmd.Parameters.AddWithValue("@Prenume", PrenumeTextBox.Text);
                        cmd.Parameters.AddWithValue("@Sex", SexComboBox.Text);
                        cmd.Parameters.AddWithValue("@Varsta", VarstaTextBox.Text);
                        cmd.Parameters.AddWithValue("@Oras", OrasTextBox.Text);
                        cmd.Parameters.AddWithValue("@Engleza", EnglezaBox.Checked);
                        cmd.Parameters.AddWithValue("@Franceza", FrancezaBox.Checked);


                        Global.con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Record inserted");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Record failed");
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during insert: " + ex.Message);
                }
                Global.con.Close();
            }
            
        }
    }
}
