namespace Client_Web_Service_COVID
{
    partial class MainApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nosStructuresDeSantéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localiserSurMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prendreUnRendezVoussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suivreMonRendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterMesRendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherStructureDeSantéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherRendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosStructuresDeSantéToolStripMenuItem,
            this.rendezVousToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.deconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nosStructuresDeSantéToolStripMenuItem
            // 
            this.nosStructuresDeSantéToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.nosStructuresDeSantéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localiserSurMapsToolStripMenuItem});
            this.nosStructuresDeSantéToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosStructuresDeSantéToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nosStructuresDeSantéToolStripMenuItem.Name = "nosStructuresDeSantéToolStripMenuItem";
            this.nosStructuresDeSantéToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.nosStructuresDeSantéToolStripMenuItem.Text = "Nos Structures de Santé";
            this.nosStructuresDeSantéToolStripMenuItem.Click += new System.EventHandler(this.nosStructuresDeSantéToolStripMenuItem_Click);
            // 
            // localiserSurMapsToolStripMenuItem
            // 
            this.localiserSurMapsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.localiserSurMapsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.localiserSurMapsToolStripMenuItem.Name = "localiserSurMapsToolStripMenuItem";
            this.localiserSurMapsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.localiserSurMapsToolStripMenuItem.Text = "localiser sur maps";
            this.localiserSurMapsToolStripMenuItem.Click += new System.EventHandler(this.localiserSurMapsToolStripMenuItem_Click);
            // 
            // rendezVousToolStripMenuItem
            // 
            this.rendezVousToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.rendezVousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prendreUnRendezVoussToolStripMenuItem,
            this.suivreMonRendezVousToolStripMenuItem,
            this.consulterMesRendezVousToolStripMenuItem});
            this.rendezVousToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendezVousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rendezVousToolStripMenuItem.Name = "rendezVousToolStripMenuItem";
            this.rendezVousToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.rendezVousToolStripMenuItem.Text = "Rendez vous";
            // 
            // prendreUnRendezVoussToolStripMenuItem
            // 
            this.prendreUnRendezVoussToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.prendreUnRendezVoussToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prendreUnRendezVoussToolStripMenuItem.Name = "prendreUnRendezVoussToolStripMenuItem";
            this.prendreUnRendezVoussToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.prendreUnRendezVoussToolStripMenuItem.Text = "Prendre un rendez vouss";
            this.prendreUnRendezVoussToolStripMenuItem.Click += new System.EventHandler(this.prendreUnRendezVoussToolStripMenuItem_Click);
            // 
            // suivreMonRendezVousToolStripMenuItem
            // 
            this.suivreMonRendezVousToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.suivreMonRendezVousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.suivreMonRendezVousToolStripMenuItem.Name = "suivreMonRendezVousToolStripMenuItem";
            this.suivreMonRendezVousToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.suivreMonRendezVousToolStripMenuItem.Text = "suivre mon rendez vous";
            this.suivreMonRendezVousToolStripMenuItem.Click += new System.EventHandler(this.suivreMonRendezVousToolStripMenuItem_Click);
            // 
            // consulterMesRendezVousToolStripMenuItem
            // 
            this.consulterMesRendezVousToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.consulterMesRendezVousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.consulterMesRendezVousToolStripMenuItem.Name = "consulterMesRendezVousToolStripMenuItem";
            this.consulterMesRendezVousToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.consulterMesRendezVousToolStripMenuItem.Text = "Consulter les rendez vous";
            this.consulterMesRendezVousToolStripMenuItem.Click += new System.EventHandler(this.consulterMesRendezVousToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.rechercherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherStructureDeSantéToolStripMenuItem,
            this.rechercherRendezVousToolStripMenuItem,
            this.rechercherUtilisateurToolStripMenuItem});
            this.rechercherToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // rechercherStructureDeSantéToolStripMenuItem
            // 
            this.rechercherStructureDeSantéToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.rechercherStructureDeSantéToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rechercherStructureDeSantéToolStripMenuItem.Name = "rechercherStructureDeSantéToolStripMenuItem";
            this.rechercherStructureDeSantéToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.rechercherStructureDeSantéToolStripMenuItem.Text = "Rechercher structure de santé";
            // 
            // rechercherRendezVousToolStripMenuItem
            // 
            this.rechercherRendezVousToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.rechercherRendezVousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rechercherRendezVousToolStripMenuItem.Name = "rechercherRendezVousToolStripMenuItem";
            this.rechercherRendezVousToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.rechercherRendezVousToolStripMenuItem.Text = "Rechercher rendez vous";
            // 
            // rechercherUtilisateurToolStripMenuItem
            // 
            this.rechercherUtilisateurToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.rechercherUtilisateurToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rechercherUtilisateurToolStripMenuItem.Name = "rechercherUtilisateurToolStripMenuItem";
            this.rechercherUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.rechercherUtilisateurToolStripMenuItem.Text = "Rechercher utilisateur";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.deconnexionToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconnexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 192);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(110, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des structures de santé, cliquez sur la structure de santé pour voir les dé" +
    "tails";
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApplication";
            this.Text = "MainApplication";
            this.Load += new System.EventHandler(this.MainApplication_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nosStructuresDeSantéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prendreUnRendezVoussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterMesRendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherStructureDeSantéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherRendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localiserSurMapsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem suivreMonRendezVousToolStripMenuItem;
    }
}