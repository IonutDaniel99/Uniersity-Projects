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
    public partial class FormAdmin : Form
    {
        public string RowIndexSelected;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadGridViewFunction();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 TempMainForm = new Form1();
            TempMainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.Global.strConectare))
            {
                try
                {

                    using (var cmd = new SqlCommand("INSERT INTO Zboruri (NumarZbor, Companie, Plecare, Sosire, OraPlecare,NumarLocuri,LocuriLibere,Pret,Poarta) VALUES (@FlighNumberTextBox,@CompanyTextBox,@DepartureTextBox,@ArrivalTextBox, @TimeTextBox,@SeatsNumberTextBox,@FreeNumberTextBox,@PriceTextBox,@GateTextBox)"))
                    {

                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@FlighNumberTextBox", FlighNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@CompanyTextBox", CompanyTextBox.Text);
                        cmd.Parameters.AddWithValue("@DepartureTextBox", DepartureTextBox.Text);
                        cmd.Parameters.AddWithValue("@ArrivalTextBox", ArrivalTextBox.Text);
                        cmd.Parameters.AddWithValue("@TimeTextBox", TimeTextBox.Text);
                        cmd.Parameters.AddWithValue("@SeatsNumberTextBox", SeatsNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@FreeNumberTextBox", FreeNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@PriceTextBox", PriceTextBox.Text);
                        cmd.Parameters.AddWithValue("@GateTextBox", GateTextBox.Text);



                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Record inserted");
                            LoadGridViewFunction();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddFlyGroupBox.Visible == false)
            {
                AddFlyGroupBox.Visible = true;
                return;
            }

            if (AddFlyGroupBox.Visible == true)
            {
                AddFlyGroupBox.Visible = false;
                return;
            }
        }

        public void LoadGridViewFunction()
        {
            Program.Global.con = new SqlConnection(Program.Global.strConectare);
            Program.Global.dataset = new DataSet();
            Program.Global.sda = new SqlDataAdapter("select * from Zboruri", Program.Global.con);
            Program.Global.sda.Fill(Program.Global.dataset, "Zboruri");
            MainGridView.DataSource = Program.Global.dataset.Tables["Zboruri"];
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadGridViewFunction();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi aceasta linie?", "Advertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(Program.Global.strConectare))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM Zboruri WHERE ID = '" + RowIndexSelected + "'", con))
                        {
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
                LoadGridViewFunction();
            }
        }

        private void MainGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MainGridView.SelectedCells.Count >= 0)
            {
                int selectedrowindex = MainGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = MainGridView.Rows[selectedrowindex];
                RowIndexSelected = Convert.ToString(selectedRow.Cells["ID"].Value);
            }
            this.Text = RowIndexSelected.ToString();
        }

        private void MainGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Program.Global.con.Open();
            bool UpdateFailed = false;
            foreach (DataGridViewRow row in MainGridView.Rows)
            {
                if (MainGridView.Rows.Count > 0)
                {
                    int nRowIndex = MainGridView.Rows.Count-1;

                    if (MainGridView.Rows[nRowIndex].Cells[0].Value != null)
                    {

                        using (SqlCommand cmd = new SqlCommand("update Zboruri set " +
                            "NumarZbor = @FlighNumberTextBox," +
                            "Companie = @CompanyTextBox," +
                            "Plecare = @DepartureTextBox," +
                            "Sosire = @ArrivalTextBox," +
                            "OraPlecare = @TimeTextBox," +
                            "NumarLocuri=@SeatsNumberTextBox," +
                            "LocuriLibere=@FreeNumberTextBox," +
                            "Pret=@PriceTextBox," +
                            "Poarta=@GateTextBox " +
                            "where ID =" + RowIndexSelected + "", Program.Global.con)) //NumarZbor, Companie, Plecare, Sosire, OraPlecare,NumarLocuri,LocuriLibere,Pret,Poarta
                        {
                            cmd.Parameters.AddWithValue("@FlighNumberTextBox", row.Cells[1].Value);
                            cmd.Parameters.AddWithValue("@CompanyTextBox", row.Cells[2].Value);
                            cmd.Parameters.AddWithValue("@DepartureTextBox", row.Cells[3].Value);
                            cmd.Parameters.AddWithValue("@ArrivalTextBox", row.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@TimeTextBox", row.Cells[5].Value);
                            cmd.Parameters.AddWithValue("@SeatsNumberTextBox", row.Cells[6].Value);
                            cmd.Parameters.AddWithValue("@FreeNumberTextBox", row.Cells[7].Value);
                            cmd.Parameters.AddWithValue("@PriceTextBox", row.Cells[8].Value);
                            cmd.Parameters.AddWithValue("@GateTextBox", row.Cells[9].Value);



                            if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                                UpdateFailed = true;
                        }


                    }
                }
            }
            if (!UpdateFailed)
                MessageBox.Show("Updated Successfully", "OUTPUT", MessageBoxButtons.OK,
                                                              MessageBoxIcon.Information);
            Program.Global.con.Close();
        }
    }
}
