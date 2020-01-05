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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadComboBoxDeparture();
        }

        private void LoadComboBoxDeparture()
        {
            using (SqlConnection conn = new SqlConnection(Program.Global.strConectare))
            {
                SqlCommand querry = new SqlCommand("SELECT Plecare FROM Zboruri", conn);
                conn.Open();
                SqlDataReader sqlReader = querry.ExecuteReader();


                while (sqlReader.Read())
                {
                    if (!DepartureComboBox.Items.Contains(sqlReader["Plecare"].ToString()))
                        DepartureComboBox.Items.Add(sqlReader["Plecare"].ToString());
                }

                conn.Close();
            }

        }
        private void LoadComboBoxArrival()
        {
            using (SqlConnection conn = new SqlConnection(Program.Global.strConectare))
            {
                SqlCommand querry = new SqlCommand("SELECT Sosire FROM Zboruri where Plecare = " + "'" + DepartureComboBox.Text+ "'", conn);
                conn.Open();
                SqlDataReader sqlReader = querry.ExecuteReader();

                while (sqlReader.Read())
                {
                   if (!ArrivalComboBox.Items.Contains(sqlReader["Sosire"].ToString()))
                        ArrivalComboBox.Items.Add(sqlReader["Sosire"].ToString());
                }

                conn.Close();
            }
        }


        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 TempMainForm = new Form1();
            TempMainForm.Show();
        }

        private void DepartureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            ArrivalComboBox.Visible = true;
            ArrivalComboBox.Items.Clear();
            ArrivalComboBox.Text = "";
            LoadComboBoxArrival();
            GroupBoxDetails.Visible = false;
        }

        private void ArrivalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Global.con = new SqlConnection(Program.Global.strConectare);
            Program.Global.dataset = new DataSet();
            Program.Global.sda = new SqlDataAdapter("SELECT * FROM Zboruri WHERE Plecare = " + "'" + DepartureComboBox.Text + "'" + "and Sosire = " + "'" + ArrivalComboBox.Text + "'", Program.Global.con);
            Program.Global.sda.Fill(Program.Global.dataset, "Zboruri");
            MainGridView.DataSource = Program.Global.dataset.Tables["Zboruri"];


        }

        private void MainGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxDetails.Visible = true;
            GroupBoxDetails.Text = DepartureComboBox.Text + " -> " + ArrivalComboBox.Text + " Details";



            FlyNumberLabel.Text = MainGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            CompanyLabel.Text = MainGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            PriceLabel.Text = MainGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            LeftTimeLabel.Text = MainGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            SeatsNumberLabel.Text = MainGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            FreeSeatsLabel.Text = MainGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            GateLabel.Text = MainGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nefunctional...nu am mai avut timp...prea multe proiecte....La multi ani!");
        }
    }
}
