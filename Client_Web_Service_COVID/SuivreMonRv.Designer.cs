namespace Client_Web_Service_COVID
{
    partial class SuivreMonRv
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(292, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suivi de mes rendez vous";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(269, 77);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(279, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Text = "donner votre email ici";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.MouseEnter += new System.EventHandler(this.survol_Email);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(125, 77);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(138, 19);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Donner votre email";
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEnvoyer.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnvoyer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEnvoyer.Location = new System.Drawing.Point(269, 128);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(279, 29);
            this.buttonEnvoyer.TabIndex = 4;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = false;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // SuivreMonRv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuivreMonRv";
            this.Text = "SuivreMonRv";
            this.Load += new System.EventHandler(this.SuivreMonRv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonEnvoyer;
    }
}