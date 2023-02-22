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
            this.btnlogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPatient)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.btnlogout);
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
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(8, 135);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(581, 114);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Se Deconnecter";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
        private System.Windows.Forms.Button btnlogout;
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