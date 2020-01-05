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

namespace AplicatieMediiSiInstrumenteDeProgramare
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data source=DESKTOP-B63QKOS\BAZADEDATESGBD; Initial Catalog=AppAvioane; Integrated Security=SSPI"))
            {
                con.Open();
                try
                {
                    using (var cmd = new SqlCommand("INSERT INTO Users (Nume, Username, Password, IsAdmin) VALUES (@Nume,@Username,@Password,@IsAdmin)"))
                    {

                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Nume", NumeTextBox.Text);
                        cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@IsAdmin", IsAdminCheckBox.Checked);

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
                con.Close();
            }
        }
    }
}
