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
    public partial class MainForm : Form
    {
        public string RowIndexSelected;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridViewFunction();
        }

        public void LoadGridViewFunction()
        {
            Global.con = new SqlConnection(Global.strConectare);
            Global.dataset = new DataSet();
            Global.sda = new SqlDataAdapter("select * from Studenti", Global.con);
            Global.sda.Fill(Global.dataset, "Studenti");
            GridViewMain.DataSource = Global.dataset.Tables["Studenti"];
        }

        private void DataAddButton_Click(object sender, EventArgs e)
        {
            DataAddForm dataAddForm = new DataAddForm();
            dataAddForm.Show();
        }

        private void RefreshGridViewButton_Click(object sender, EventArgs e)
        {
            LoadGridViewFunction();
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi aceasta linie?", "Advertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(Global.strConectare))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM Studenti WHERE ID = '" + RowIndexSelected + "'", con))
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
  
        private void GridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewMain.SelectedCells.Count > 0)
            {
                int selectedrowindex = GridViewMain.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridViewMain.Rows[selectedrowindex];
                RowIndexSelected = Convert.ToString(selectedRow.Cells["ID"].Value);
            }
        }

        private void GridViewMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Global.con.Open();
            bool UpdateFailed = false;
            foreach (DataGridViewRow row in GridViewMain.Rows)
            {
                if (GridViewMain.Rows.Count > 0)
                {
                    int nRowIndex = GridViewMain.Rows.Count - 2;

                    if (GridViewMain.Rows[nRowIndex].Cells[0].Value != null)
                    {

                        using (SqlCommand cmd11 = new SqlCommand("update Studenti set " +
                            "Nume = @nume, Prenume = @prenume, Sex = @sex, Varsta = @varsta, Oras = @oras, Engleza=@engleza,Franceza=@franceza " +
                            "where ID =" +RowIndexSelected + "",Global.con))
                        {
                        cmd11.Parameters.AddWithValue("@nume", row.Cells[1].Value);
                        cmd11.Parameters.AddWithValue("@prenume", row.Cells[2].Value);
                        cmd11.Parameters.AddWithValue("@sex", row.Cells[3].Value);
                        cmd11.Parameters.AddWithValue("@varsta", row.Cells[4].Value);
                        cmd11.Parameters.AddWithValue("@oras", row.Cells[5].Value);
                        cmd11.Parameters.AddWithValue("@engleza", row.Cells[6].Value);
                        cmd11.Parameters.AddWithValue("@franceza", row.Cells[7].Value);


                            if (Convert.ToInt32(cmd11.ExecuteNonQuery()) > 0)
                            UpdateFailed = true;
                        }


                    }
                }
            }
             if(!UpdateFailed)
               MessageBox.Show("Updated Successfully", "OUTPUT", MessageBoxButtons.OK,
                                                             MessageBoxIcon.Information);
            Global.con.Close();
        }

        private void DbVerificationBtn_Click(object sender, EventArgs e)
        {
            using (var TempConn = new SqlConnection(Global.strConectare))
            {
                try
                {
                    TempConn.Open();
                    MessageBox.Show("Conexiunea cu baza de data s-a realizat cu succes");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Conexiunea cu baza de data nu s-a putut realiza");

                }
            }
        }
    }
}
