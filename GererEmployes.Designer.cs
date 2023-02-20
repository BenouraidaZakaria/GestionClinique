namespace GestionClinique
{
    partial class GererEmployes
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.imageEmp = new System.Windows.Forms.PictureBox();
            this.imageText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.eopen = new System.Windows.Forms.PictureBox();
            this.eclosed = new System.Windows.Forms.PictureBox();
            this.Specmb = new System.Windows.Forms.ComboBox();
            this.Mdptxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Pretxt = new System.Windows.Forms.TextBox();
            this.Nomtxt = new System.Windows.Forms.TextBox();
            this.rbSec = new System.Windows.Forms.RadioButton();
            this.rbDoc = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Desactiver = new System.Windows.Forms.Button();
            this.Activer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.datpickNaissance = new System.Windows.Forms.DateTimePicker();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eopen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eclosed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.cmbSexe);
            this.groupbox1.Controls.Add(this.datpickNaissance);
            this.groupbox1.Controls.Add(this.label9);
            this.groupbox1.Controls.Add(this.label8);
            this.groupbox1.Controls.Add(this.imageEmp);
            this.groupbox1.Controls.Add(this.imageText);
            this.groupbox1.Controls.Add(this.label7);
            this.groupbox1.Controls.Add(this.eopen);
            this.groupbox1.Controls.Add(this.eclosed);
            this.groupbox1.Controls.Add(this.Specmb);
            this.groupbox1.Controls.Add(this.Mdptxt);
            this.groupbox1.Controls.Add(this.Mailtxt);
            this.groupbox1.Controls.Add(this.Pretxt);
            this.groupbox1.Controls.Add(this.Nomtxt);
            this.groupbox1.Controls.Add(this.rbSec);
            this.groupbox1.Controls.Add(this.rbDoc);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.groupBox2);
            this.groupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F);
            this.groupbox1.Location = new System.Drawing.Point(624, 143);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(2000, 1648);
            this.groupbox1.TabIndex = 31;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Informations de l\'employe";
            // 
            // imageEmp
            // 
            this.imageEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageEmp.Location = new System.Drawing.Point(635, 362);
            this.imageEmp.Name = "imageEmp";
            this.imageEmp.Size = new System.Drawing.Size(355, 229);
            this.imageEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageEmp.TabIndex = 48;
            this.imageEmp.TabStop = false;
            this.imageEmp.Click += new System.EventHandler(this.imageEmp_Click);
            // 
            // imageText
            // 
            this.imageText.Location = new System.Drawing.Point(635, 430);
            this.imageText.Name = "imageText";
            this.imageText.Size = new System.Drawing.Size(100, 61);
            this.imageText.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 46);
            this.label7.TabIndex = 47;
            this.label7.Text = "Image";
            // 
            // eopen
            // 
            this.eopen.Image = global::GestionClinique.Properties.Resources.open;
            this.eopen.Location = new System.Drawing.Point(1339, 1086);
            this.eopen.Name = "eopen";
            this.eopen.Size = new System.Drawing.Size(100, 71);
            this.eopen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eopen.TabIndex = 46;
            this.eopen.TabStop = false;
            this.eopen.Click += new System.EventHandler(this.eopen_Click);
            // 
            // eclosed
            // 
            this.eclosed.Image = global::GestionClinique.Properties.Resources.closed;
            this.eclosed.Location = new System.Drawing.Point(1339, 1086);
            this.eclosed.Name = "eclosed";
            this.eclosed.Size = new System.Drawing.Size(100, 71);
            this.eclosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eclosed.TabIndex = 46;
            this.eclosed.TabStop = false;
            this.eclosed.Visible = false;
            this.eclosed.Click += new System.EventHandler(this.eclosed_Click);
            // 
            // Specmb
            // 
            this.Specmb.FormattingEnabled = true;
            this.Specmb.Location = new System.Drawing.Point(635, 1488);
            this.Specmb.Name = "Specmb";
            this.Specmb.Size = new System.Drawing.Size(644, 62);
            this.Specmb.TabIndex = 45;
            // 
            // Mdptxt
            // 
            this.Mdptxt.Location = new System.Drawing.Point(635, 1086);
            this.Mdptxt.Name = "Mdptxt";
            this.Mdptxt.PasswordChar = '*';
            this.Mdptxt.ReadOnly = true;
            this.Mdptxt.Size = new System.Drawing.Size(644, 61);
            this.Mdptxt.TabIndex = 44;
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(635, 949);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.ReadOnly = true;
            this.Mailtxt.Size = new System.Drawing.Size(644, 61);
            this.Mailtxt.TabIndex = 43;
            // 
            // Pretxt
            // 
            this.Pretxt.Location = new System.Drawing.Point(635, 802);
            this.Pretxt.Name = "Pretxt";
            this.Pretxt.Size = new System.Drawing.Size(644, 61);
            this.Pretxt.TabIndex = 42;
            this.Pretxt.TextChanged += new System.EventHandler(this.Pretxt_TextChanged);
            // 
            // Nomtxt
            // 
            this.Nomtxt.Location = new System.Drawing.Point(635, 660);
            this.Nomtxt.Name = "Nomtxt";
            this.Nomtxt.Size = new System.Drawing.Size(644, 61);
            this.Nomtxt.TabIndex = 41;
            this.Nomtxt.TextChanged += new System.EventHandler(this.Nomtxt_TextChanged);
            // 
            // rbSec
            // 
            this.rbSec.AutoSize = true;
            this.rbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSec.Location = new System.Drawing.Point(1100, 205);
            this.rbSec.Name = "rbSec";
            this.rbSec.Size = new System.Drawing.Size(209, 43);
            this.rbSec.TabIndex = 40;
            this.rbSec.Text = "Secretaire";
            this.rbSec.UseVisualStyleBackColor = true;
            // 
            // rbDoc
            // 
            this.rbDoc.AutoSize = true;
            this.rbDoc.Checked = true;
            this.rbDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbDoc.Location = new System.Drawing.Point(635, 205);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(173, 43);
            this.rbDoc.TabIndex = 39;
            this.rbDoc.TabStop = true;
            this.rbDoc.Text = "Docteur";
            this.rbDoc.UseVisualStyleBackColor = true;
            this.rbDoc.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(89, 1504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 46);
            this.label6.TabIndex = 38;
            this.label6.Text = "Specialite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(89, 1101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 46);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(89, 959);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 46);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(89, 817);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 46);
            this.label3.TabIndex = 35;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(89, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(89, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type Employe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(2726, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 776);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(169, 570);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(553, 85);
            this.button7.TabIndex = 3;
            this.button7.Text = "Actualiser";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(169, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(553, 85);
            this.button6.TabIndex = 2;
            this.button6.Text = "Supprimer";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(169, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(553, 85);
            this.button5.TabIndex = 1;
            this.button5.Text = "Modifier";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(169, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(553, 85);
            this.button4.TabIndex = 0;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.Desactiver);
            this.groupBox3.Controls.Add(this.Activer);
            this.groupBox3.Controls.Add(this.Modifier);
            this.groupBox3.Controls.Add(this.Ajouter);
            this.groupBox3.Location = new System.Drawing.Point(2726, 505);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(892, 776);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3207, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(411, 69);
            this.comboBox1.TabIndex = 34;
            // 
            // Desactiver
            // 
            this.Desactiver.Location = new System.Drawing.Point(169, 559);
            this.Desactiver.Name = "Desactiver";
            this.Desactiver.Size = new System.Drawing.Size(553, 85);
            this.Desactiver.TabIndex = 2;
            this.Desactiver.Text = "Desactiver";
            this.Desactiver.UseVisualStyleBackColor = true;
            this.Desactiver.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Activer
            // 
            this.Activer.Location = new System.Drawing.Point(169, 434);
            this.Activer.Name = "Activer";
            this.Activer.Size = new System.Drawing.Size(553, 85);
            this.Activer.TabIndex = 2;
            this.Activer.Text = "Activer";
            this.Activer.UseVisualStyleBackColor = true;
            this.Activer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Enabled = false;
            this.Modifier.Location = new System.Drawing.Point(169, 298);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(553, 85);
            this.Modifier.TabIndex = 1;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(169, 162);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(553, 85);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2715, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(466, 61);
            this.label10.TabIndex = 35;
            this.label10.Text = "Selection Employe";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(3413, 280);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(205, 81);
            this.select.TabIndex = 36;
            this.select.Text = "selectionner";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
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
            this.flowLayoutPanel1.TabIndex = 37;
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
            this.panel1.Size = new System.Drawing.Size(581, 128);
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
            this.panel2.Location = new System.Drawing.Point(8, 277);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel2.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 133);
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
            this.panel3.Location = new System.Drawing.Point(8, 424);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.MaximumSize = new System.Drawing.Size(581, 296);
            this.panel3.MinimumSize = new System.Drawing.Size(581, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 124);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 1254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 46);
            this.label8.TabIndex = 50;
            this.label8.Text = "Sexe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 1377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 46);
            this.label9.TabIndex = 51;
            this.label9.Text = "Date de Naissance";
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(635, 1254);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(635, 62);
            this.cmbSexe.TabIndex = 53;
            // 
            // datpickNaissance
            // 
            this.datpickNaissance.Location = new System.Drawing.Point(635, 1368);
            this.datpickNaissance.Name = "datpickNaissance";
            this.datpickNaissance.Size = new System.Drawing.Size(635, 61);
            this.datpickNaissance.TabIndex = 52;
            // 
            // GererEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1912);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox1);
            this.Name = "GererEmployes";
            this.Text = "GererEmployes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GererEmployes_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eopen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eclosed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Activer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Specmb;
        private System.Windows.Forms.TextBox Mdptxt;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox Pretxt;
        private System.Windows.Forms.TextBox Nomtxt;
        private System.Windows.Forms.RadioButton rbSec;
        private System.Windows.Forms.RadioButton rbDoc;
        private System.Windows.Forms.PictureBox eopen;
        private System.Windows.Forms.PictureBox eclosed;
        private System.Windows.Forms.Button select;
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
        private System.Windows.Forms.Button Desactiver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imageEmp;
        private System.Windows.Forms.TextBox imageText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.DateTimePicker datpickNaissance;
    }
}