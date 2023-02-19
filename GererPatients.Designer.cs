
namespace GestionClinique
{
    partial class GererPatients
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
            this.cmbassur = new System.Windows.Forms.ComboBox();
            this.imagePatient = new System.Windows.Forms.PictureBox();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.datpickNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageText = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.menu1 = new GestionClinique.Menu();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePatient)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbassur);
            this.groupBox1.Controls.Add(this.imagePatient);
            this.groupBox1.Controls.Add(this.cmbSexe);
            this.groupBox1.Controls.Add(this.datpickNaissance);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imageText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(624, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2000, 1150);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du Patients";
            // 
            // cmbassur
            // 
            this.cmbassur.FormattingEnabled = true;
            this.cmbassur.Items.AddRange(new object[] {
            "AMO",
            "CNSS",
            "NOM ASSURE"});
            this.cmbassur.Location = new System.Drawing.Point(573, 1000);
            this.cmbassur.Name = "cmbassur";
            this.cmbassur.Size = new System.Drawing.Size(635, 62);
            this.cmbassur.TabIndex = 29;
            // 
            // imagePatient
            // 
            this.imagePatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePatient.Location = new System.Drawing.Point(1595, 143);
            this.imagePatient.Name = "imagePatient";
            this.imagePatient.Size = new System.Drawing.Size(355, 229);
            this.imagePatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePatient.TabIndex = 26;
            this.imagePatient.TabStop = false;
            this.imagePatient.Click += new System.EventHandler(this.imagePatient_Click);
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(573, 458);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(635, 62);
            this.cmbSexe.TabIndex = 25;
            // 
            // datpickNaissance
            // 
            this.datpickNaissance.Location = new System.Drawing.Point(573, 362);
            this.datpickNaissance.Name = "datpickNaissance";
            this.datpickNaissance.Size = new System.Drawing.Size(635, 61);
            this.datpickNaissance.TabIndex = 24;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(573, 882);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(635, 61);
            this.txtAdresse.TabIndex = 22;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(573, 746);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(635, 61);
            this.txtTelephone.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(573, 608);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(635, 61);
            this.txtEmail.TabIndex = 20;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(573, 251);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(635, 61);
            this.txtPrenom.TabIndex = 19;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(573, 133);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(635, 61);
            this.txtNom.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1356, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 46);
            this.label9.TabIndex = 17;
            this.label9.Text = "Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 1000);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = "Assurance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 897);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 761);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 46);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 623);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 46);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date de Naissance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom";
            // 
            // imageText
            // 
            this.imageText.Location = new System.Drawing.Point(1691, 244);
            this.imageText.Name = "imageText";
            this.imageText.Size = new System.Drawing.Size(100, 61);
            this.imageText.TabIndex = 28;
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(169, 438);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(553, 85);
            this.supprimer.TabIndex = 2;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(169, 298);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(553, 85);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(169, 162);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(553, 85);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supprimer);
            this.groupBox2.Controls.Add(this.modifier);
            this.groupBox2.Controls.Add(this.ajouter);
            this.groupBox2.Location = new System.Drawing.Point(2726, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 776);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2715, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(452, 61);
            this.label10.TabIndex = 33;
            this.label10.Text = "Selection Patients";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(3413, 287);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(205, 81);
            this.select.TabIndex = 34;
            this.select.Text = "selectionner";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(600, 1500);
            this.menu1.TabIndex = 35;
            // 
            // GererPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1912);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GererPatients";
            this.Text = "v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GererPatients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePatient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imagePatient;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.DateTimePicker datpickNaissance;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imageText;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.ComboBox cmbassur;
        private Menu menu1;
    }
}