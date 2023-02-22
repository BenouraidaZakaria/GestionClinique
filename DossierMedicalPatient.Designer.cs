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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.congrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtall = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtassu = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgenre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgPatient = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAffPat = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GerEmp = new System.Windows.Forms.Button();
            this.AffEmp = new System.Windows.Forms.Button();
            this.btnEmployes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAffCon = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congrid)).BeginInit();
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
            this.groupBox4.Controls.Add(this.congrid);
            this.groupBox4.Location = new System.Drawing.Point(1494, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1293, 1448);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultations";
            // 
            // congrid
            // 
            this.congrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.congrid.Location = new System.Drawing.Point(43, 82);
            this.congrid.Name = "congrid";
            this.congrid.RowHeadersWidth = 102;
            this.congrid.RowTemplate.Height = 40;
            this.congrid.Size = new System.Drawing.Size(1226, 1334);
            this.congrid.TabIndex = 0;
            this.congrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.congrid_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtall);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtassu);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtadd);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txttel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtmail);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtgenre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtprenom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.imgPatient);
            this.groupBox2.Location = new System.Drawing.Point(102, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 1467);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infos";
            // 
            // txtall
            // 
            this.txtall.AutoSize = true;
            this.txtall.Location = new System.Drawing.Point(401, 1232);
            this.txtall.Name = "txtall";
            this.txtall.Size = new System.Drawing.Size(128, 39);
            this.txtall.TabIndex = 18;
            this.txtall.Text = "label18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 1232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 39);
            this.label17.TabIndex = 17;
            this.label17.Text = "Allergies :";
            // 
            // txtassu
            // 
            this.txtassu.AutoSize = true;
            this.txtassu.Location = new System.Drawing.Point(401, 1096);
            this.txtassu.Name = "txtassu";
            this.txtassu.Size = new System.Drawing.Size(128, 39);
            this.txtassu.TabIndex = 16;
            this.txtassu.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 1096);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 39);
            this.label15.TabIndex = 15;
            this.label15.Text = "Assurance :";
            // 
            // txtadd
            // 
            this.txtadd.AutoSize = true;
            this.txtadd.Location = new System.Drawing.Point(401, 966);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(128, 39);
            this.txtadd.TabIndex = 14;
            this.txtadd.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 966);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 39);
            this.label13.TabIndex = 13;
            this.label13.Text = "Adresse :";
            // 
            // txttel
            // 
            this.txttel.AutoSize = true;
            this.txttel.Location = new System.Drawing.Point(401, 849);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(128, 39);
            this.txttel.TabIndex = 12;
            this.txttel.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 849);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 39);
            this.label11.TabIndex = 11;
            this.label11.Text = "Telephone :";
            // 
            // txtmail
            // 
            this.txtmail.AutoSize = true;
            this.txtmail.Location = new System.Drawing.Point(401, 717);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(128, 39);
            this.txtmail.TabIndex = 10;
            this.txtmail.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 717);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 39);
            this.label9.TabIndex = 9;
            this.label9.Text = "Email :";
            // 
            // txtgenre
            // 
            this.txtgenre.AutoSize = true;
            this.txtgenre.Location = new System.Drawing.Point(401, 601);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(109, 39);
            this.txtgenre.TabIndex = 8;
            this.txtgenre.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sexe :";
            // 
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Location = new System.Drawing.Point(401, 465);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(109, 39);
            this.txtdate.TabIndex = 6;
            this.txtdate.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Naissance :";
            // 
            // txtprenom
            // 
            this.txtprenom.AutoSize = true;
            this.txtprenom.Location = new System.Drawing.Point(739, 285);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(109, 39);
            this.txtprenom.TabIndex = 4;
            this.txtprenom.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom :";
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Location = new System.Drawing.Point(739, 93);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(109, 39);
            this.txtnom.TabIndex = 2;
            this.txtnom.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // imgPatient
            // 
            this.imgPatient.Image = global::GestionClinique.Properties.Resources.user;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.GerEmp);
            this.panel2.Controls.Add(this.AffEmp);
            this.panel2.Controls.Add(this.btnEmployes);
            this.panel2.Location = new System.Drawing.Point(8, 273);
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
            this.panel3.Controls.Add(this.btnAffCon);
            this.panel3.Controls.Add(this.btnConsultation);
            this.panel3.Location = new System.Drawing.Point(8, 416);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel3.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 132);
            this.panel3.TabIndex = 1;
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
            this.btnRendezVous.Location = new System.Drawing.Point(8, 562);
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
            this.btnReglage.Location = new System.Drawing.Point(8, 690);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DossierMedicalPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.congrid)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView congrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAffPat;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GerEmp;
        private System.Windows.Forms.Button AffEmp;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAffCon;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnReglage;
        private System.Windows.Forms.Label txtall;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtassu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtadd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txttel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtgenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.Label label1;
    }
}