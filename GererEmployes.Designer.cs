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
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.menu1 = new GestionClinique.Menu();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eopen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eclosed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
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
            this.groupbox1.Size = new System.Drawing.Size(2000, 1150);
            this.groupbox1.TabIndex = 31;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Informations de l\'employe";
            // 
            // eopen
            // 
            this.eopen.Image = global::GestionClinique.Properties.Resources.open;
            this.eopen.Location = new System.Drawing.Point(1339, 764);
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
            this.eclosed.Location = new System.Drawing.Point(1339, 764);
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
            this.Specmb.Location = new System.Drawing.Point(635, 905);
            this.Specmb.Name = "Specmb";
            this.Specmb.Size = new System.Drawing.Size(644, 62);
            this.Specmb.TabIndex = 45;
            // 
            // Mdptxt
            // 
            this.Mdptxt.Location = new System.Drawing.Point(635, 764);
            this.Mdptxt.Name = "Mdptxt";
            this.Mdptxt.PasswordChar = '*';
            this.Mdptxt.ReadOnly = true;
            this.Mdptxt.Size = new System.Drawing.Size(644, 61);
            this.Mdptxt.TabIndex = 44;
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(635, 627);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.ReadOnly = true;
            this.Mailtxt.Size = new System.Drawing.Size(644, 61);
            this.Mailtxt.TabIndex = 43;
            // 
            // Pretxt
            // 
            this.Pretxt.Location = new System.Drawing.Point(635, 480);
            this.Pretxt.Name = "Pretxt";
            this.Pretxt.Size = new System.Drawing.Size(644, 61);
            this.Pretxt.TabIndex = 42;
            this.Pretxt.TextChanged += new System.EventHandler(this.Pretxt_TextChanged);
            // 
            // Nomtxt
            // 
            this.Nomtxt.Location = new System.Drawing.Point(635, 338);
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
            this.label6.Location = new System.Drawing.Point(89, 921);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 46);
            this.label6.TabIndex = 38;
            this.label6.Text = "Specialite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(89, 779);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 46);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(89, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 46);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(89, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 46);
            this.label3.TabIndex = 35;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(89, 353);
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
            this.groupBox3.Controls.Add(this.supprimer);
            this.groupBox3.Controls.Add(this.modifier);
            this.groupBox3.Controls.Add(this.ajouter);
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
            this.modifier.Enabled = false;
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
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(600, 1500);
            this.menu1.TabIndex = 37;
            // 
            // GererEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1912);
            this.Controls.Add(this.menu1);
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
            ((System.ComponentModel.ISupportInitialize)(this.eopen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eclosed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
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
        private Menu menu1;
    }
}