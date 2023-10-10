namespace Client_Web_Service_COVID
{
    partial class RendezVous
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
            this.ComboBoxIdentite = new System.Windows.Forms.ComboBox();
            this.ComboBoxStructure = new System.Windows.Forms.ComboBox();
            this.ComboBoxTypeRV = new System.Windows.Forms.ComboBox();
            this.dateTimeRV = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnregistrementRV = new System.Windows.Forms.Button();
            this.labelIdentite = new System.Windows.Forms.Label();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelTypeRV = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxIdentite
            // 
            this.ComboBoxIdentite.FormattingEnabled = true;
            this.ComboBoxIdentite.Location = new System.Drawing.Point(292, 101);
            this.ComboBoxIdentite.Name = "ComboBoxIdentite";
            this.ComboBoxIdentite.Size = new System.Drawing.Size(297, 21);
            this.ComboBoxIdentite.TabIndex = 1;
            // 
            // ComboBoxStructure
            // 
            this.ComboBoxStructure.FormattingEnabled = true;
            this.ComboBoxStructure.Location = new System.Drawing.Point(292, 139);
            this.ComboBoxStructure.Name = "ComboBoxStructure";
            this.ComboBoxStructure.Size = new System.Drawing.Size(298, 21);
            this.ComboBoxStructure.TabIndex = 2;
            // 
            // ComboBoxTypeRV
            // 
            this.ComboBoxTypeRV.FormattingEnabled = true;
            this.ComboBoxTypeRV.Location = new System.Drawing.Point(292, 179);
            this.ComboBoxTypeRV.Name = "ComboBoxTypeRV";
            this.ComboBoxTypeRV.Size = new System.Drawing.Size(297, 21);
            this.ComboBoxTypeRV.TabIndex = 3;
            // 
            // dateTimeRV
            // 
            this.dateTimeRV.Location = new System.Drawing.Point(292, 218);
            this.dateTimeRV.Name = "dateTimeRV";
            this.dateTimeRV.Size = new System.Drawing.Size(297, 20);
            this.dateTimeRV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prise de rendez vous";
            // 
            // buttonEnregistrementRV
            // 
            this.buttonEnregistrementRV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEnregistrementRV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrementRV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEnregistrementRV.Location = new System.Drawing.Point(292, 280);
            this.buttonEnregistrementRV.Name = "buttonEnregistrementRV";
            this.buttonEnregistrementRV.Size = new System.Drawing.Size(297, 28);
            this.buttonEnregistrementRV.TabIndex = 6;
            this.buttonEnregistrementRV.Text = "Enregistrer le rendez vous";
            this.buttonEnregistrementRV.UseVisualStyleBackColor = false;
            this.buttonEnregistrementRV.Click += new System.EventHandler(this.buttonEnregistrementRV_Click);
            // 
            // labelIdentite
            // 
            this.labelIdentite.AutoSize = true;
            this.labelIdentite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentite.Location = new System.Drawing.Point(103, 103);
            this.labelIdentite.Name = "labelIdentite";
            this.labelIdentite.Size = new System.Drawing.Size(183, 19);
            this.labelIdentite.TabIndex = 7;
            this.labelIdentite.Text = "selectionner votre identité";
            // 
            // labelStructure
            // 
            this.labelStructure.AutoSize = true;
            this.labelStructure.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStructure.Location = new System.Drawing.Point(54, 139);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(232, 19);
            this.labelStructure.TabIndex = 8;
            this.labelStructure.Text = "Sélectionner la structure de santé";
            // 
            // labelTypeRV
            // 
            this.labelTypeRV.AutoSize = true;
            this.labelTypeRV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeRV.Location = new System.Drawing.Point(60, 181);
            this.labelTypeRV.Name = "labelTypeRV";
            this.labelTypeRV.Size = new System.Drawing.Size(226, 19);
            this.labelTypeRV.TabIndex = 9;
            this.labelTypeRV.Text = "Séléctionner le type de votre RV";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(132, 220);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(154, 19);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Donner la date du RV";
            // 
            // RendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTypeRV);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.labelIdentite);
            this.Controls.Add(this.buttonEnregistrementRV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeRV);
            this.Controls.Add(this.ComboBoxTypeRV);
            this.Controls.Add(this.ComboBoxStructure);
            this.Controls.Add(this.ComboBoxIdentite);
            this.Name = "RendezVous";
            this.Text = "RendezVous";
            this.Load += new System.EventHandler(this.RendezVous_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxIdentite;
        private System.Windows.Forms.ComboBox ComboBoxStructure;
        private System.Windows.Forms.ComboBox ComboBoxTypeRV;
        private System.Windows.Forms.DateTimePicker dateTimeRV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnregistrementRV;
        private System.Windows.Forms.Label labelIdentite;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelTypeRV;
        private System.Windows.Forms.Label labelDate;
    }
}