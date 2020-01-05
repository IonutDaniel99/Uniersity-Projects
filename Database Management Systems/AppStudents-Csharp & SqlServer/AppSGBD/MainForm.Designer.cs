namespace AppSGBD
{
    partial class MainForm
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
            this.GridViewMain = new System.Windows.Forms.DataGridView();
            this.DataAddButton = new System.Windows.Forms.Button();
            this.RefreshGridViewButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.DbVerificationBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewMain
            // 
            this.GridViewMain.AllowUserToAddRows = false;
            this.GridViewMain.AllowUserToDeleteRows = false;
            this.GridViewMain.AllowUserToOrderColumns = true;
            this.GridViewMain.AllowUserToResizeColumns = false;
            this.GridViewMain.AllowUserToResizeRows = false;
            this.GridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMain.Location = new System.Drawing.Point(12, 12);
            this.GridViewMain.Name = "GridViewMain";
            this.GridViewMain.Size = new System.Drawing.Size(860, 284);
            this.GridViewMain.TabIndex = 0;
            this.GridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMain_CellClick);
            this.GridViewMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMain_CellValueChanged);
            // 
            // DataAddButton
            // 
            this.DataAddButton.Location = new System.Drawing.Point(878, 41);
            this.DataAddButton.Name = "DataAddButton";
            this.DataAddButton.Size = new System.Drawing.Size(101, 23);
            this.DataAddButton.TabIndex = 1;
            this.DataAddButton.Text = "Adauga Date";
            this.DataAddButton.UseVisualStyleBackColor = true;
            this.DataAddButton.Click += new System.EventHandler(this.DataAddButton_Click);
            // 
            // RefreshGridViewButton
            // 
            this.RefreshGridViewButton.Location = new System.Drawing.Point(878, 12);
            this.RefreshGridViewButton.Name = "RefreshGridViewButton";
            this.RefreshGridViewButton.Size = new System.Drawing.Size(101, 23);
            this.RefreshGridViewButton.TabIndex = 2;
            this.RefreshGridViewButton.Text = "Refresh GridView";
            this.RefreshGridViewButton.UseVisualStyleBackColor = true;
            this.RefreshGridViewButton.Click += new System.EventHandler(this.RefreshGridViewButton_Click);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(878, 70);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(101, 23);
            this.DeleteRowButton.TabIndex = 3;
            this.DeleteRowButton.Text = "Sterge Linie";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // DbVerificationBtn
            // 
            this.DbVerificationBtn.Location = new System.Drawing.Point(879, 100);
            this.DbVerificationBtn.Name = "DbVerificationBtn";
            this.DbVerificationBtn.Size = new System.Drawing.Size(100, 58);
            this.DbVerificationBtn.TabIndex = 4;
            this.DbVerificationBtn.Text = "Verifica Conexiunea Cu Baza De Date";
            this.DbVerificationBtn.UseVisualStyleBackColor = true;
            this.DbVerificationBtn.Click += new System.EventHandler(this.DbVerificationBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 304);
            this.Controls.Add(this.DbVerificationBtn);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.RefreshGridViewButton);
            this.Controls.Add(this.DataAddButton);
            this.Controls.Add(this.GridViewMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewMain;
        private System.Windows.Forms.Button DataAddButton;
        private System.Windows.Forms.Button RefreshGridViewButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button DbVerificationBtn;
    }
}

