namespace GestionClinique
{
    partial class DossierMedicalPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DossierMedicalPatient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.imgPatient = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGerPat = new System.Windows.Forms.Button();
            this.btnAffPat = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GerEmp = new System.Windows.Forms.Button();
            this.AffEmp = new System.Windows.Forms.Button();
            this.btnEmployes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGerCon = new System.Windows.Forms.Button();
            this.btnAffCon = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPatient)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(674, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2845, 1655);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dossier Medical";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(1494, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1293, 1448);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultations";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(1226, 1334);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(103, 893);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1233, 721);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendez-vous";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tel);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.age);
            this.groupBox2.Controls.Add(this.prenom);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Controls.Add(this.imgPatient);
            this.groupBox2.Location = new System.Drawing.Point(102, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 598);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infos";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(410, 465);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(244, 54);
            this.tel.TabIndex = 4;
            this.tel.Text = "Telephone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(410, 336);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(139, 54);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(410, 219);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(106, 54);
            this.age.TabIndex = 3;
            this.age.Text = "Age";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(693, 92);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(187, 54);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prenom";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(410, 93);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(122, 54);
            this.nom.TabIndex = 1;
            this.nom.Text = "Nom";
            // 
            // imgPatient
            // 
            this.imgPatient.Image = ((System.Drawing.Image)(resources.GetObject("imgPatient.Image")));
            this.imgPatient.Location = new System.Drawing.Point(42, 82);
            this.imgPatient.Name = "imgPatient";
            this.imgPatient.Size = new System.Drawing.Size(258, 254);
            this.imgPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPatient.TabIndex = 0;
            this.imgPatient.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.flowLayoutPanel1.TabIndex = 14;
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
            this.panel1.Controls.Add(this.btnGerPat);
            this.panel1.Controls.Add(this.btnAffPat);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Location = new System.Drawing.Point(8, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel1.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 130);
            this.panel1.TabIndex = 1;
            // 
            // btnGerPat
            // 
            this.btnGerPat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerPat.Location = new System.Drawing.Point(-3, 207);
            this.btnGerPat.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGerPat.Name = "btnGerPat";
            this.btnGerPat.Size = new System.Drawing.Size(581, 83);
            this.btnGerPat.TabIndex = 3;
            this.btnGerPat.Text = "Gerer Patient";
            this.btnGerPat.UseVisualStyleBackColor = false;
            this.btnGerPat.Click += new System.EventHandler(this.btnGerPat_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.GerEmp);
            this.panel2.Controls.Add(this.AffEmp);
            this.panel2.Controls.Add(this.btnEmployes);
            this.panel2.Location = new System.Drawing.Point(8, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel2.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 129);
            this.panel2.TabIndex = 2;
            // 
            // GerEmp
            // 
            this.GerEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GerEmp.Location = new System.Drawing.Point(0, 210);
            this.GerEmp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GerEmp.Name = "GerEmp";
            this.GerEmp.Size = new System.Drawing.Size(581, 83);
            this.GerEmp.TabIndex = 5;
            this.GerEmp.Text = "Gerer Employes";
            this.GerEmp.UseVisualStyleBackColor = false;
            this.GerEmp.Click += new System.EventHandler(this.GerEmp_Click);
            // 
            // AffEmp
            // 
            this.AffEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AffEmp.Location = new System.Drawing.Point(0, 129);
            this.AffEmp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AffEmp.Name = "AffEmp";
            this.AffEmp.Size = new System.Drawing.Size(581, 83);
            this.AffEmp.TabIndex = 4;
            this.AffEmp.Text = "Liste des Employes";
            this.AffEmp.UseVisualStyleBackColor = false;
            this.AffEmp.Click += new System.EventHandler(this.AffEmp_Click);
            // 
            // btnEmployes
            // 
            this.btnEmployes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployes.Location = new System.Drawing.Point(0, 7);
            this.btnEmployes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(581, 114);
            this.btnEmployes.TabIndex = 2;
            this.btnEmployes.Text = "Employes";
            this.btnEmployes.UseVisualStyleBackColor = true;
            this.btnEmployes.Click += new System.EventHandler(this.btnEmployes_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGerCon);
            this.panel3.Controls.Add(this.btnAffCon);
            this.panel3.Controls.Add(this.btnConsultation);
            this.panel3.Location = new System.Drawing.Point(8, 422);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel3.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 128);
            this.panel3.TabIndex = 1;
            // 
            // btnGerCon
            // 
            this.btnGerCon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerCon.Location = new System.Drawing.Point(0, 210);
            this.btnGerCon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGerCon.Name = "btnGerCon";
            this.btnGerCon.Size = new System.Drawing.Size(581, 83);
            this.btnGerCon.TabIndex = 7;
            this.btnGerCon.Text = "Gerer Consultation";
            this.btnGerCon.UseVisualStyleBackColor = false;
            this.btnGerCon.Click += new System.EventHandler(this.btnGerCon_Click);
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
            // btnRendezVous
            // 
            this.btnRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezVous.Location = new System.Drawing.Point(8, 564);
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
            this.btnReglage.Location = new System.Drawing.Point(8, 692);
            this.btnReglage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReglage.Name = "btnReglage";
            this.btnReglage.Size = new System.Drawing.Size(581, 114);
            this.btnReglage.TabIndex = 5;
            this.btnReglage.Text = "Reglages";
            this.btnReglage.UseVisualStyleBackColor = true;
            // 
            // DossierMedicalPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3653, 1786);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DossierMedicalPatient";
            this.Text = "DossierMedicalPatient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPatient)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgPatient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerPat;
        private System.Windows.Forms.Button btnAffPat;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GerEmp;
        private System.Windows.Forms.Button AffEmp;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGerCon;
        private System.Windows.Forms.Button btnAffCon;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnReglage;
    }
}