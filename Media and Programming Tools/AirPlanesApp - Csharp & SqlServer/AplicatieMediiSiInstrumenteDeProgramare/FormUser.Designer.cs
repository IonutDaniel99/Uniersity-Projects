namespace AplicatieMediiSiInstrumenteDeProgramare
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartureComboBox = new System.Windows.Forms.ComboBox();
            this.ArrivalComboBox = new System.Windows.Forms.ComboBox();
            this.GroupBoxDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FlyNumberLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.LeftTimeLabel = new System.Windows.Forms.Label();
            this.SeatsNumberLabel = new System.Windows.Forms.Label();
            this.FreeSeatsLabel = new System.Windows.Forms.Label();
            this.GateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.GroupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.AllowUserToOrderColumns = true;
            this.MainGridView.AllowUserToResizeRows = false;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Location = new System.Drawing.Point(12, 60);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.Size = new System.Drawing.Size(744, 174);
            this.MainGridView.TabIndex = 0;
            this.MainGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plecare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sosire";
            this.label2.Visible = false;
            // 
            // DepartureComboBox
            // 
            this.DepartureComboBox.FormattingEnabled = true;
            this.DepartureComboBox.Location = new System.Drawing.Point(65, 21);
            this.DepartureComboBox.Name = "DepartureComboBox";
            this.DepartureComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartureComboBox.TabIndex = 3;
            this.DepartureComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartureComboBox_SelectedIndexChanged);
            // 
            // ArrivalComboBox
            // 
            this.ArrivalComboBox.FormattingEnabled = true;
            this.ArrivalComboBox.Location = new System.Drawing.Point(295, 21);
            this.ArrivalComboBox.Name = "ArrivalComboBox";
            this.ArrivalComboBox.Size = new System.Drawing.Size(121, 21);
            this.ArrivalComboBox.TabIndex = 4;
            this.ArrivalComboBox.Visible = false;
            this.ArrivalComboBox.SelectedIndexChanged += new System.EventHandler(this.ArrivalComboBox_SelectedIndexChanged);
            // 
            // GroupBoxDetails
            // 
            this.GroupBoxDetails.Controls.Add(this.LeftTimeLabel);
            this.GroupBoxDetails.Controls.Add(this.PriceLabel);
            this.GroupBoxDetails.Controls.Add(this.CompanyLabel);
            this.GroupBoxDetails.Controls.Add(this.GateLabel);
            this.GroupBoxDetails.Controls.Add(this.FreeSeatsLabel);
            this.GroupBoxDetails.Controls.Add(this.SeatsNumberLabel);
            this.GroupBoxDetails.Controls.Add(this.FlyNumberLabel);
            this.GroupBoxDetails.Controls.Add(this.button1);
            this.GroupBoxDetails.Controls.Add(this.label8);
            this.GroupBoxDetails.Controls.Add(this.label7);
            this.GroupBoxDetails.Controls.Add(this.label9);
            this.GroupBoxDetails.Controls.Add(this.label6);
            this.GroupBoxDetails.Controls.Add(this.label5);
            this.GroupBoxDetails.Controls.Add(this.label4);
            this.GroupBoxDetails.Controls.Add(this.label3);
            this.GroupBoxDetails.Location = new System.Drawing.Point(12, 240);
            this.GroupBoxDetails.Name = "GroupBoxDetails";
            this.GroupBoxDetails.Size = new System.Drawing.Size(742, 84);
            this.GroupBoxDetails.TabIndex = 5;
            this.GroupBoxDetails.TabStop = false;
            this.GroupBoxDetails.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NumarZbor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Companie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ora Plecare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numar Locuri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Locuri Libere";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pret";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Poarta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "RezervaLoc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FlyNumberLabel
            // 
            this.FlyNumberLabel.AutoSize = true;
            this.FlyNumberLabel.Location = new System.Drawing.Point(38, 43);
            this.FlyNumberLabel.Name = "FlyNumberLabel";
            this.FlyNumberLabel.Size = new System.Drawing.Size(34, 13);
            this.FlyNumberLabel.TabIndex = 2;
            this.FlyNumberLabel.Text = "#xxxx";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CompanyLabel.Location = new System.Drawing.Point(140, 44);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(34, 13);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "BluAir";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(230, 43);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(19, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "60";
            // 
            // LeftTimeLabel
            // 
            this.LeftTimeLabel.AutoSize = true;
            this.LeftTimeLabel.Location = new System.Drawing.Point(308, 43);
            this.LeftTimeLabel.Name = "LeftTimeLabel";
            this.LeftTimeLabel.Size = new System.Drawing.Size(38, 13);
            this.LeftTimeLabel.TabIndex = 2;
            this.LeftTimeLabel.Text = "XX:XX";
            // 
            // SeatsNumberLabel
            // 
            this.SeatsNumberLabel.AutoSize = true;
            this.SeatsNumberLabel.Location = new System.Drawing.Point(408, 43);
            this.SeatsNumberLabel.Name = "SeatsNumberLabel";
            this.SeatsNumberLabel.Size = new System.Drawing.Size(22, 13);
            this.SeatsNumberLabel.TabIndex = 2;
            this.SeatsNumberLabel.Text = "xxx";
            // 
            // FreeSeatsLabel
            // 
            this.FreeSeatsLabel.AutoSize = true;
            this.FreeSeatsLabel.Location = new System.Drawing.Point(508, 43);
            this.FreeSeatsLabel.Name = "FreeSeatsLabel";
            this.FreeSeatsLabel.Size = new System.Drawing.Size(22, 13);
            this.FreeSeatsLabel.TabIndex = 2;
            this.FreeSeatsLabel.Text = "xxx";
            // 
            // GateLabel
            // 
            this.GateLabel.AutoSize = true;
            this.GateLabel.Location = new System.Drawing.Point(589, 43);
            this.GateLabel.Name = "GateLabel";
            this.GateLabel.Size = new System.Drawing.Size(22, 13);
            this.GateLabel.TabIndex = 2;
            this.GateLabel.Text = "xxx";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 337);
            this.Controls.Add(this.GroupBoxDetails);
            this.Controls.Add(this.ArrivalComboBox);
            this.Controls.Add(this.DepartureComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainGridView);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.GroupBoxDetails.ResumeLayout(false);
            this.GroupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DepartureComboBox;
        private System.Windows.Forms.ComboBox ArrivalComboBox;
        private System.Windows.Forms.GroupBox GroupBoxDetails;
        private System.Windows.Forms.Label LeftTimeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label GateLabel;
        private System.Windows.Forms.Label FreeSeatsLabel;
        private System.Windows.Forms.Label SeatsNumberLabel;
        private System.Windows.Forms.Label FlyNumberLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}