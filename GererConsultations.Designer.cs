namespace GestionClinique
{
    partial class GererConsultations
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
            this.rmvtrai = new System.Windows.Forms.PictureBox();
            this.addtrai = new System.Windows.Forms.PictureBox();
            this.rmvdiag = new System.Windows.Forms.PictureBox();
            this.adddiag = new System.Windows.Forms.PictureBox();
            this.txttrai = new System.Windows.Forms.TextBox();
            this.txtdiag = new System.Windows.Forms.TextBox();
            this.listtrai = new System.Windows.Forms.ListBox();
            this.listdiag = new System.Windows.Forms.ListBox();
            this.imagePrescription = new System.Windows.Forms.PictureBox();
            this.imagePrescText = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.menu1 = new GestionClinique.Menu();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmvtrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addtrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmvdiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adddiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePrescription)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rmvtrai);
            this.groupBox1.Controls.Add(this.addtrai);
            this.groupBox1.Controls.Add(this.rmvdiag);
            this.groupBox1.Controls.Add(this.adddiag);
            this.groupBox1.Controls.Add(this.txttrai);
            this.groupBox1.Controls.Add(this.txtdiag);
            this.groupBox1.Controls.Add(this.listtrai);
            this.groupBox1.Controls.Add(this.listdiag);
            this.groupBox1.Controls.Add(this.imagePrescription);
            this.groupBox1.Controls.Add(this.imagePrescText);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F);
            this.groupBox1.Location = new System.Drawing.Point(624, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2000, 1648);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations de la Consultation";
            // 
            // rmvtrai
            // 
            this.rmvtrai.Image = global::GestionClinique.Properties.Resources.minus;
            this.rmvtrai.Location = new System.Drawing.Point(1725, 1073);
            this.rmvtrai.Name = "rmvtrai";
            this.rmvtrai.Size = new System.Drawing.Size(133, 65);
            this.rmvtrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rmvtrai.TabIndex = 37;
            this.rmvtrai.TabStop = false;
            this.rmvtrai.Click += new System.EventHandler(this.rmvtrai_Click);
            // 
            // addtrai
            // 
            this.addtrai.Image = global::GestionClinique.Properties.Resources.plus;
            this.addtrai.Location = new System.Drawing.Point(1586, 1073);
            this.addtrai.Name = "addtrai";
            this.addtrai.Size = new System.Drawing.Size(133, 65);
            this.addtrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addtrai.TabIndex = 36;
            this.addtrai.TabStop = false;
            this.addtrai.Click += new System.EventHandler(this.addtrai_Click);
            // 
            // rmvdiag
            // 
            this.rmvdiag.Image = global::GestionClinique.Properties.Resources.minus;
            this.rmvdiag.Location = new System.Drawing.Point(1725, 739);
            this.rmvdiag.Name = "rmvdiag";
            this.rmvdiag.Size = new System.Drawing.Size(133, 65);
            this.rmvdiag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rmvdiag.TabIndex = 35;
            this.rmvdiag.TabStop = false;
            this.rmvdiag.Click += new System.EventHandler(this.rmvdiag_Click);
            // 
            // adddiag
            // 
            this.adddiag.Image = global::GestionClinique.Properties.Resources.plus;
            this.adddiag.Location = new System.Drawing.Point(1586, 739);
            this.adddiag.Name = "adddiag";
            this.adddiag.Size = new System.Drawing.Size(133, 65);
            this.adddiag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adddiag.TabIndex = 34;
            this.adddiag.TabStop = false;
            this.adddiag.Click += new System.EventHandler(this.adddiag_Click);
            // 
            // txttrai
            // 
            this.txttrai.Location = new System.Drawing.Point(1255, 1077);
            this.txttrai.Name = "txttrai";
            this.txttrai.Size = new System.Drawing.Size(302, 61);
            this.txttrai.TabIndex = 33;
            // 
            // txtdiag
            // 
            this.txtdiag.Location = new System.Drawing.Point(1255, 739);
            this.txtdiag.Name = "txtdiag";
            this.txtdiag.Size = new System.Drawing.Size(302, 61);
            this.txtdiag.TabIndex = 32;
            // 
            // listtrai
            // 
            this.listtrai.FormattingEnabled = true;
            this.listtrai.ItemHeight = 54;
            this.listtrai.Location = new System.Drawing.Point(578, 1057);
            this.listtrai.Name = "listtrai";
            this.listtrai.Size = new System.Drawing.Size(591, 220);
            this.listtrai.TabIndex = 31;
            // 
            // listdiag
            // 
            this.listdiag.FormattingEnabled = true;
            this.listdiag.ItemHeight = 54;
            this.listdiag.Location = new System.Drawing.Point(578, 739);
            this.listdiag.Name = "listdiag";
            this.listdiag.Size = new System.Drawing.Size(591, 220);
            this.listdiag.TabIndex = 31;
            // 
            // imagePrescription
            // 
            this.imagePrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePrescription.Location = new System.Drawing.Point(599, 1345);
            this.imagePrescription.Name = "imagePrescription";
            this.imagePrescription.Size = new System.Drawing.Size(355, 229);
            this.imagePrescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePrescription.TabIndex = 29;
            this.imagePrescription.TabStop = false;
            this.imagePrescription.Click += new System.EventHandler(this.imagePrescription_Click);
            // 
            // imagePrescText
            // 
            this.imagePrescText.Location = new System.Drawing.Point(599, 1410);
            this.imagePrescText.Name = "imagePrescText";
            this.imagePrescText.Size = new System.Drawing.Size(100, 61);
            this.imagePrescText.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(578, 571);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 2, 8, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(806, 61);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2023, 2, 10, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(578, 444);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 2, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(806, 61);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 10, 0, 0, 0, 0);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(578, 309);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(418, 62);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(578, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(418, 62);
            this.comboBox2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(104, 1410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prescription";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(103, 1057);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Traitements";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(104, 739);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diagnostics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(104, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(104, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(104, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(104, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docteur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supprimer);
            this.groupBox2.Controls.Add(this.modifier);
            this.groupBox2.Controls.Add(this.ajouter);
            this.groupBox2.Location = new System.Drawing.Point(2726, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 776);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(169, 434);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(553, 85);
            this.supprimer.TabIndex = 2;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(169, 298);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(553, 85);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2715, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(555, 61);
            this.label10.TabIndex = 35;
            this.label10.Text = "Selection Consultation";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(3403, 297);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(215, 81);
            this.select.TabIndex = 36;
            this.select.Text = "selectionner";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(600, 1500);
            this.menu1.TabIndex = 37;
            // 
            // GererConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1912);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GererConsultations";
            this.Text = "GererConsultations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GererConsultations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmvtrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addtrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmvdiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adddiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePrescription)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox imagePrescription;
        private System.Windows.Forms.TextBox imagePrescText;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox listtrai;
        private System.Windows.Forms.ListBox listdiag;
        private System.Windows.Forms.TextBox txtdiag;
        private System.Windows.Forms.TextBox txttrai;
        private System.Windows.Forms.PictureBox rmvtrai;
        private System.Windows.Forms.PictureBox addtrai;
        private System.Windows.Forms.PictureBox rmvdiag;
        private System.Windows.Forms.PictureBox adddiag;
        private System.Windows.Forms.Button select;
        private Menu menu1;
    }
}