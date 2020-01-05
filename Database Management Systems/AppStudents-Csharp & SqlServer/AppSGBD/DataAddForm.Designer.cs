namespace AppSGBD
{
    partial class DataAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumeTextBox = new System.Windows.Forms.TextBox();
            this.PrenumeTextBox = new System.Windows.Forms.TextBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.VarstaTextBox = new System.Windows.Forms.TextBox();
            this.OrasTextBox = new System.Windows.Forms.TextBox();
            this.EnglezaBox = new System.Windows.Forms.CheckBox();
            this.FrancezaBox = new System.Windows.Forms.CheckBox();
            this.SendDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Varsta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oras";
            // 
            // NumeTextBox
            // 
            this.NumeTextBox.Location = new System.Drawing.Point(83, 20);
            this.NumeTextBox.Name = "NumeTextBox";
            this.NumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeTextBox.TabIndex = 1;
            // 
            // PrenumeTextBox
            // 
            this.PrenumeTextBox.Location = new System.Drawing.Point(83, 60);
            this.PrenumeTextBox.Name = "PrenumeTextBox";
            this.PrenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrenumeTextBox.TabIndex = 1;
            // 
            // SexComboBox
            // 
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Nespecificat"});
            this.SexComboBox.Location = new System.Drawing.Point(83, 100);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(121, 21);
            this.SexComboBox.TabIndex = 2;
            // 
            // VarstaTextBox
            // 
            this.VarstaTextBox.Location = new System.Drawing.Point(83, 140);
            this.VarstaTextBox.Name = "VarstaTextBox";
            this.VarstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.VarstaTextBox.TabIndex = 1;
            // 
            // OrasTextBox
            // 
            this.OrasTextBox.Location = new System.Drawing.Point(83, 180);
            this.OrasTextBox.Name = "OrasTextBox";
            this.OrasTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrasTextBox.TabIndex = 1;
            // 
            // EnglezaBox
            // 
            this.EnglezaBox.AutoSize = true;
            this.EnglezaBox.Location = new System.Drawing.Point(12, 217);
            this.EnglezaBox.Name = "EnglezaBox";
            this.EnglezaBox.Size = new System.Drawing.Size(64, 17);
            this.EnglezaBox.TabIndex = 3;
            this.EnglezaBox.Text = "Engleza";
            this.EnglezaBox.UseVisualStyleBackColor = true;
            // 
            // FrancezaBox
            // 
            this.FrancezaBox.AutoSize = true;
            this.FrancezaBox.Location = new System.Drawing.Point(124, 217);
            this.FrancezaBox.Name = "FrancezaBox";
            this.FrancezaBox.Size = new System.Drawing.Size(70, 17);
            this.FrancezaBox.TabIndex = 4;
            this.FrancezaBox.Text = "Franceza";
            this.FrancezaBox.UseVisualStyleBackColor = true;
            // 
            // SendDataBtn
            // 
            this.SendDataBtn.Location = new System.Drawing.Point(83, 254);
            this.SendDataBtn.Name = "SendDataBtn";
            this.SendDataBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SendDataBtn.Size = new System.Drawing.Size(75, 23);
            this.SendDataBtn.TabIndex = 5;
            this.SendDataBtn.Text = "Incarca";
            this.SendDataBtn.UseVisualStyleBackColor = true;
            this.SendDataBtn.Click += new System.EventHandler(this.SendDataBtn_Click);
            // 
            // DataAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 289);
            this.Controls.Add(this.SendDataBtn);
            this.Controls.Add(this.FrancezaBox);
            this.Controls.Add(this.EnglezaBox);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.OrasTextBox);
            this.Controls.Add(this.VarstaTextBox);
            this.Controls.Add(this.PrenumeTextBox);
            this.Controls.Add(this.NumeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DataAddForm";
            this.Text = "DataAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumeTextBox;
        private System.Windows.Forms.TextBox PrenumeTextBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.TextBox VarstaTextBox;
        private System.Windows.Forms.TextBox OrasTextBox;
        private System.Windows.Forms.CheckBox EnglezaBox;
        private System.Windows.Forms.CheckBox FrancezaBox;
        private System.Windows.Forms.Button SendDataBtn;
    }
}