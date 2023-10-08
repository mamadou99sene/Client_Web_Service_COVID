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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nosStructuresDeSantéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prendreUnRendezVoussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterMesRendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosStructuresDeSantéToolStripMenuItem,
            this.rendezVousToolStripMenuItem,
            this.deconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nosStructuresDeSantéToolStripMenuItem
            // 
            this.nosStructuresDeSantéToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.nosStructuresDeSantéToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nosStructuresDeSantéToolStripMenuItem.Name = "nosStructuresDeSantéToolStripMenuItem";
            this.nosStructuresDeSantéToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.nosStructuresDeSantéToolStripMenuItem.Text = "Nos Structures de Santé";
            this.nosStructuresDeSantéToolStripMenuItem.Click += new System.EventHandler(this.nosStructuresDeSantéToolStripMenuItem_Click);
            // 
            // rendezVousToolStripMenuItem
            // 
            this.rendezVousToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.rendezVousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prendreUnRendezVoussToolStripMenuItem,
            this.toolStripMenuItem2,
            this.consulterMesRendezVousToolStripMenuItem});
            this.rendezVousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rendezVousToolStripMenuItem.Name = "rendezVousToolStripMenuItem";
            this.rendezVousToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.rendezVousToolStripMenuItem.Text = "Rendez vous";
            // 
            // prendreUnRendezVoussToolStripMenuItem
            // 
            this.prendreUnRendezVoussToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.prendreUnRendezVoussToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prendreUnRendezVoussToolStripMenuItem.Name = "prendreUnRendezVoussToolStripMenuItem";
            this.prendreUnRendezVoussToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.prendreUnRendezVoussToolStripMenuItem.Text = "Prendre un rendez vouss";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // consulterMesRendezVousToolStripMenuItem
            // 
            this.consulterMesRendezVousToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.consulterMesRendezVousToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.consulterMesRendezVousToolStripMenuItem.Name = "consulterMesRendezVousToolStripMenuItem";
            this.consulterMesRendezVousToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.consulterMesRendezVousToolStripMenuItem.Text = "Consulter mes rendez vous";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.deconnexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 192);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consulterMesRendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}