namespace Client_Web_Service_COVID
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.Button();
            this.inscription = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.AcceptsReturn = true;
            this.textBox_email.AcceptsTab = true;
            this.textBox_email.Location = new System.Drawing.Point(258, 211);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(279, 20);
            this.textBox_email.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(206, 212);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 19);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(183, 250);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "password";
            // 
            // connexion
            // 
            this.connexion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexion.Location = new System.Drawing.Point(258, 297);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(106, 39);
            this.connexion.TabIndex = 4;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click_1);
            // 
            // inscription
            // 
            this.inscription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscription.Location = new System.Drawing.Point(419, 297);
            this.inscription.Name = "inscription";
            this.inscription.Size = new System.Drawing.Size(118, 39);
            this.inscription.TabIndex = 5;
            this.inscription.Text = "S\'inscrire";
            this.inscription.UseVisualStyleBackColor = true;
            this.inscription.Click += new System.EventHandler(this.inscription_Click_1);
            // 
            // textBox_Password
            // 
            this.textBox_Password.AcceptsReturn = true;
            this.textBox_Password.AcceptsTab = true;
            this.textBox_Password.Location = new System.Drawing.Point(258, 247);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(279, 20);
            this.textBox_Password.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.inscription);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.Button inscription;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

