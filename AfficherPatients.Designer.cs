
namespace GestionClinique
{
    partial class AfficherPatients
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouterPatient = new System.Windows.Forms.Button();
            this.btnListPatients = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDocteur = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAjoutConsultation = new System.Windows.Forms.Button();
            this.btnListConsultation = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.btnAccueil);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnRendezVous);
            this.flowLayoutPanel1.Controls.Add(this.btnReglage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(595, 1791);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.panel1.Controls.Add(this.btnAjouterPatient);
            this.panel1.Controls.Add(this.btnListPatients);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Location = new System.Drawing.Point(8, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel1.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 124);
            this.panel1.TabIndex = 1;
            // 
            // btnAjouterPatient
            // 
            this.btnAjouterPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouterPatient.Location = new System.Drawing.Point(-3, 207);
            this.btnAjouterPatient.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAjouterPatient.Name = "btnAjouterPatient";
            this.btnAjouterPatient.Size = new System.Drawing.Size(581, 83);
            this.btnAjouterPatient.TabIndex = 3;
            this.btnAjouterPatient.Text = "Ajouter Patient";
            this.btnAjouterPatient.UseVisualStyleBackColor = false;
            this.btnAjouterPatient.Click += new System.EventHandler(this.btnAjouterPatient_Click);
            // 
            // btnListPatients
            // 
            this.btnListPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListPatients.Location = new System.Drawing.Point(-3, 126);
            this.btnListPatients.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnListPatients.Name = "btnListPatients";
            this.btnListPatients.Size = new System.Drawing.Size(581, 83);
            this.btnListPatients.TabIndex = 2;
            this.btnListPatients.Text = "Liste des Patients";
            this.btnListPatients.UseVisualStyleBackColor = false;
            this.btnListPatients.Click += new System.EventHandler(this.btnListPatients_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnDocteur);
            this.panel2.Location = new System.Drawing.Point(8, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel2.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 124);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(0, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(581, 83);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(0, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(581, 83);
            this.button2.TabIndex = 4;
            this.button2.Text = "Liste des Patients";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDocteur
            // 
            this.btnDocteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocteur.Location = new System.Drawing.Point(0, 7);
            this.btnDocteur.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDocteur.Name = "btnDocteur";
            this.btnDocteur.Size = new System.Drawing.Size(581, 114);
            this.btnDocteur.TabIndex = 2;
            this.btnDocteur.Text = "Docteurs";
            this.btnDocteur.UseVisualStyleBackColor = true;
            this.btnDocteur.Click += new System.EventHandler(this.btnDocteur_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjoutConsultation);
            this.panel3.Controls.Add(this.btnListConsultation);
            this.panel3.Controls.Add(this.btnConsultation);
            this.panel3.Location = new System.Drawing.Point(8, 411);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel3.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 124);
            this.panel3.TabIndex = 1;
            // 
            // btnAjoutConsultation
            // 
            this.btnAjoutConsultation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjoutConsultation.Location = new System.Drawing.Point(0, 210);
            this.btnAjoutConsultation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAjoutConsultation.Name = "btnAjoutConsultation";
            this.btnAjoutConsultation.Size = new System.Drawing.Size(581, 83);
            this.btnAjoutConsultation.TabIndex = 7;
            this.btnAjoutConsultation.Text = "Ajouter Consultation";
            this.btnAjoutConsultation.UseVisualStyleBackColor = false;
            this.btnAjoutConsultation.Click += new System.EventHandler(this.btnAjoutConsultation_Click);
            // 
            // btnListConsultation
            // 
            this.btnListConsultation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListConsultation.Location = new System.Drawing.Point(0, 129);
            this.btnListConsultation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnListConsultation.Name = "btnListConsultation";
            this.btnListConsultation.Size = new System.Drawing.Size(581, 83);
            this.btnListConsultation.TabIndex = 6;
            this.btnListConsultation.Text = "Liste des Consultations";
            this.btnListConsultation.UseVisualStyleBackColor = false;
            this.btnListConsultation.Click += new System.EventHandler(this.btnListConsultation_Click);
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
            // btnRendezVous
            // 
            this.btnRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezVous.Location = new System.Drawing.Point(8, 549);
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
            this.btnReglage.Location = new System.Drawing.Point(8, 677);
            this.btnReglage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReglage.Name = "btnReglage";
            this.btnReglage.Size = new System.Drawing.Size(581, 114);
            this.btnReglage.TabIndex = 5;
            this.btnReglage.Text = "Reglages";
            this.btnReglage.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.ForeColor = System.Drawing.Color.Gray;
            this.txtRecherche.Location = new System.Drawing.Point(1336, 33);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(804, 52);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.Text = "search";
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            this.txtRecherche.Leave += new System.EventHandler(this.txtRecherche_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 95);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patients";
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Location = new System.Drawing.Point(642, 261);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.RowHeadersWidth = 102;
            this.PatientsGrid.RowTemplate.Height = 40;
            this.PatientsGrid.Size = new System.Drawing.Size(2969, 1248);
            this.PatientsGrid.TabIndex = 7;
            // 
            // AfficherPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3437, 1786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AfficherPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Patients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AfficherPatients_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouterPatient;
        private System.Windows.Forms.Button btnListPatients;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDocteur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAjoutConsultation;
        private System.Windows.Forms.Button btnListConsultation;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnReglage;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PatientsGrid;
    }
}