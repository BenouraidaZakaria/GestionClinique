namespace GestionClinique
{
    partial class AcceuilDoctors
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
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAffPat = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAffCon = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Location = new System.Drawing.Point(659, 246);
            this.PatientsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.RowHeadersWidth = 102;
            this.PatientsGrid.RowTemplate.Height = 40;
            this.PatientsGrid.Size = new System.Drawing.Size(2619, 375);
            this.PatientsGrid.TabIndex = 23;
            this.PatientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsGrid_CellClick);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.Location = new System.Drawing.Point(8, 7);
            this.btnAccueil.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(581, 114);
            this.btnAccueil.TabIndex = 0;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAffPat);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Location = new System.Drawing.Point(8, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel1.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 124);
            this.panel1.TabIndex = 1;
            // 
            // btnAffPat
            // 
            this.btnAffPat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAffPat.Location = new System.Drawing.Point(-3, 126);
            this.btnAffPat.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAffPat.Name = "btnAffPat";
            this.btnAffPat.Size = new System.Drawing.Size(581, 83);
            this.btnAffPat.TabIndex = 2;
            this.btnAffPat.Text = "Liste des Patients";
            this.btnAffPat.UseVisualStyleBackColor = false;
            this.btnAffPat.Click += new System.EventHandler(this.btnAffPat_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(0, 7);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(581, 114);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 95);
            this.label3.TabIndex = 26;
            this.label3.Text = "Patients";
            // 
            // btnAffCon
            // 
            this.btnAffCon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAffCon.Location = new System.Drawing.Point(0, 129);
            this.btnAffCon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAffCon.Name = "btnAffCon";
            this.btnAffCon.Size = new System.Drawing.Size(581, 83);
            this.btnAffCon.TabIndex = 6;
            this.btnAffCon.Text = "Liste des Consultations";
            this.btnAffCon.UseVisualStyleBackColor = false;
            this.btnAffCon.Click += new System.EventHandler(this.btnAffCon_Click);
            // 
            // btnConsultation
            // 
            this.btnConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultation.Location = new System.Drawing.Point(0, 7);
            this.btnConsultation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(581, 114);
            this.btnConsultation.TabIndex = 3;
            this.btnConsultation.Text = "Consultations";
            this.btnConsultation.UseVisualStyleBackColor = true;
            this.btnConsultation.Click += new System.EventHandler(this.btnConsultation_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAffCon);
            this.panel3.Controls.Add(this.btnConsultation);
            this.panel3.Location = new System.Drawing.Point(8, 273);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel3.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 124);
            this.panel3.TabIndex = 1;
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezVous.Location = new System.Drawing.Point(8, 411);
            this.btnRendezVous.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(581, 114);
            this.btnRendezVous.TabIndex = 4;
            this.btnRendezVous.Text = "Rendez-Vous";
            this.btnRendezVous.UseVisualStyleBackColor = true;
            // 
            // btnReglage
            // 
            this.btnReglage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReglage.Location = new System.Drawing.Point(8, 539);
            this.btnReglage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReglage.Name = "btnReglage";
            this.btnReglage.Size = new System.Drawing.Size(581, 114);
            this.btnReglage.TabIndex = 5;
            this.btnReglage.Text = "Reglages";
            this.btnReglage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Controls.Add(this.btnAccueil);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnRendezVous);
            this.flowLayoutPanel1.Controls.Add(this.btnReglage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(595, 1307);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // AcceuilDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3472, 1326);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AcceuilDoctors";
            this.Text = "AcceuilDoctors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AcceuilDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsGrid;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAffPat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAffCon;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnReglage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPatients;
    }
}