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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserRegisterButton_Click(object sender, EventArgs e)
        {
            AddUser AddUserForm = new AddUser();
            AddUserForm.Show();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.Global.strConectare);
            SqlCommand cmd = new SqlCommand("Select * from Users where Username = '" + UsernameTextBox.Text + "'and Password ='" + PasswordTextBox.Text + "'", con);

            con.Open();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
               SqlCommand role = new SqlCommand("Select Isadmin from Users where Username = '" + UsernameTextBox.Text + "'and Password ='" + PasswordTextBox.Text + "'", con);
               var IsAdmin = role.ExecuteScalar();
               if(IsAdmin.ToString() == "True")
                {
                    FormAdmin FormAdminTemp = new FormAdmin();
                    FormAdminTemp.Show();
                    this.Hide();
                }
                else
                {
                    FormUser FormUserTemp = new FormUser();
                    FormUserTemp.Show();
                    this.Hide();
                }
                        
            }
            else
            {
                MessageBox.Show("Username and password are wrong!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var TempConn = new SqlConnection(Program.Global.strConectare))
            {
                try
                {
                    TempConn.Open();
                    MessageBox.Show("Conexiuan cu baza de data s-a realizat cu succes");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Conexiuan cu baza de data nu s-a putut realiza");

                }
            }
        }
    }
}
