namespace AplicatieMediiSiInstrumenteDeProgramare
{
    partial class FormAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.AddFlyGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GateTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.ArrivalTextBox = new System.Windows.Forms.TextBox();
            this.FreeNumberTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTextBox = new System.Windows.Forms.TextBox();
            this.SeatsNumberTextBox = new System.Windows.Forms.TextBox();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.FlighNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.AddFlyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adauga Zbor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Location = new System.Drawing.Point(13, 13);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.Size = new System.Drawing.Size(588, 241);
            this.MainGridView.TabIndex = 1;
            this.MainGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridView_CellClick);
            this.MainGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridView_CellValueChanged);
            // 
            // AddFlyGroupBox
            // 
            this.AddFlyGroupBox.Controls.Add(this.button2);
            this.AddFlyGroupBox.Controls.Add(this.GateTextBox);
            this.AddFlyGroupBox.Controls.Add(this.PriceTextBox);
            this.AddFlyGroupBox.Controls.Add(this.label5);
            this.AddFlyGroupBox.Controls.Add(this.TimeTextBox);
            this.AddFlyGroupBox.Controls.Add(this.ArrivalTextBox);
            this.AddFlyGroupBox.Controls.Add(this.FreeNumberTextBox);
            this.AddFlyGroupBox.Controls.Add(this.DepartureTextBox);
            this.AddFlyGroupBox.Controls.Add(this.SeatsNumberTextBox);
            this.AddFlyGroupBox.Controls.Add(this.CompanyTextBox);
            this.AddFlyGroupBox.Controls.Add(this.FlighNumberTextBox);
            this.AddFlyGroupBox.Controls.Add(this.label9);
            this.AddFlyGroupBox.Controls.Add(this.label8);
            this.AddFlyGroupBox.Controls.Add(this.label4);
            this.AddFlyGroupBox.Controls.Add(this.label7);
            this.AddFlyGroupBox.Controls.Add(this.label3);
            this.AddFlyGroupBox.Controls.Add(this.label6);
            this.AddFlyGroupBox.Controls.Add(this.label2);
            this.AddFlyGroupBox.Controls.Add(this.label1);
            this.AddFlyGroupBox.Location = new System.Drawing.Point(13, 290);
            this.AddFlyGroupBox.Name = "AddFlyGroupBox";
            this.AddFlyGroupBox.Size = new System.Drawing.Size(588, 148);
            this.AddFlyGroupBox.TabIndex = 2;
            this.AddFlyGroupBox.TabStop = false;
            this.AddFlyGroupBox.Text = "Adauga Zbor Panel";
            this.AddFlyGroupBox.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(558, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Incarca Zbor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GateTextBox
            // 
            this.GateTextBox.Location = new System.Drawing.Point(474, 84);
            this.GateTextBox.Name = "GateTextBox";
            this.GateTextBox.Size = new System.Drawing.Size(100, 20);
            this.GateTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(474, 54);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ora Pecare";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(275, 54);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeTextBox.TabIndex = 1;
            // 
            // ArrivalTextBox
            // 
            this.ArrivalTextBox.Location = new System.Drawing.Point(275, 24);
            this.ArrivalTextBox.Name = "ArrivalTextBox";
            this.ArrivalTextBox.Size = new System.Drawing.Size(100, 20);
            this.ArrivalTextBox.TabIndex = 1;
            // 
            // FreeNumberTextBox
            // 
            this.FreeNumberTextBox.Location = new System.Drawing.Point(474, 24);
            this.FreeNumberTextBox.Name = "FreeNumberTextBox";
            this.FreeNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.FreeNumberTextBox.TabIndex = 1;
            // 
            // DepartureTextBox
            // 
            this.DepartureTextBox.Location = new System.Drawing.Point(79, 84);
            this.DepartureTextBox.Name = "DepartureTextBox";
            this.DepartureTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartureTextBox.TabIndex = 1;
            // 
            // SeatsNumberTextBox
            // 
            this.SeatsNumberTextBox.Location = new System.Drawing.Point(275, 84);
            this.SeatsNumberTextBox.Name = "SeatsNumberTextBox";
            this.SeatsNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.SeatsNumberTextBox.TabIndex = 1;
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Location = new System.Drawing.Point(79, 54);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(100, 20);
            this.CompanyTextBox.TabIndex = 1;
            // 
            // FlighNumberTextBox
            // 
            this.FlighNumberTextBox.Location = new System.Drawing.Point(79, 24);
            this.FlighNumberTextBox.Name = "FlighNumberTextBox";
            this.FlighNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.FlighNumberTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Poarta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sosire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Locuri Libere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pleare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numar Locuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Companie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumarZbor";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(141, 261);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(117, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh GridView";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sterge Zborul Selectat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddFlyGroupBox);
            this.Controls.Add(this.MainGridView);
            this.Controls.Add(this.button1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.AddFlyGroupBox.ResumeLayout(false);
            this.AddFlyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.GroupBox AddFlyGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox GateTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox ArrivalTextBox;
        private System.Windows.Forms.TextBox FreeNumberTextBox;
        private System.Windows.Forms.TextBox DepartureTextBox;
        private System.Windows.Forms.TextBox SeatsNumberTextBox;
        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.TextBox FlighNumberTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button button3;
    }
}