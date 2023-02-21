﻿namespace GestionClinique
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
            this.btnGerPat = new System.Windows.Forms.Button();
            this.btnAffPat = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultationGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GerEmp = new System.Windows.Forms.Button();
            this.AffEmp = new System.Windows.Forms.Button();
            this.btnEmployes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGerCon = new System.Windows.Forms.Button();
            this.btnAffCon = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Location = new System.Drawing.Point(247, 103);
            this.PatientsGrid.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.RowHeadersWidth = 102;
            this.PatientsGrid.RowTemplate.Height = 40;
            this.PatientsGrid.Size = new System.Drawing.Size(506, 507);
            this.PatientsGrid.TabIndex = 23;
            // 
            // btnAccueil
            // 
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.Location = new System.Drawing.Point(3, 3);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(218, 48);
            this.btnAccueil.TabIndex = 0;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGerPat);
            this.panel1.Controls.Add(this.btnAffPat);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.MaximumSize = new System.Drawing.Size(218, 124);
            this.panel1.MinimumSize = new System.Drawing.Size(218, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 53);
            this.panel1.TabIndex = 1;
            // 
            // btnGerPat
            // 
            this.btnGerPat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerPat.Location = new System.Drawing.Point(-1, 87);
            this.btnGerPat.Name = "btnGerPat";
            this.btnGerPat.Size = new System.Drawing.Size(218, 35);
            this.btnGerPat.TabIndex = 3;
            this.btnGerPat.Text = "Gerer Patient";
            this.btnGerPat.UseVisualStyleBackColor = false;
            // 
            // btnAffPat
            // 
            this.btnAffPat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAffPat.Location = new System.Drawing.Point(-1, 53);
            this.btnAffPat.Name = "btnAffPat";
            this.btnAffPat.Size = new System.Drawing.Size(218, 35);
            this.btnAffPat.TabIndex = 2;
            this.btnAffPat.Text = "Liste des Patients";
            this.btnAffPat.UseVisualStyleBackColor = false;
            // 
            // btnPatients
            // 
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(0, 3);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(218, 48);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "Consultations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Patients";
            // 
            // ConsultationGrid
            // 
            this.ConsultationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultationGrid.Location = new System.Drawing.Point(819, 103);
            this.ConsultationGrid.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ConsultationGrid.Name = "ConsultationGrid";
            this.ConsultationGrid.RowHeadersWidth = 102;
            this.ConsultationGrid.RowTemplate.Height = 40;
            this.ConsultationGrid.Size = new System.Drawing.Size(444, 206);
            this.ConsultationGrid.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GerEmp);
            this.panel2.Controls.Add(this.AffEmp);
            this.panel2.Controls.Add(this.btnEmployes);
            this.panel2.Location = new System.Drawing.Point(3, 116);
            this.panel2.MaximumSize = new System.Drawing.Size(218, 124);
            this.panel2.MinimumSize = new System.Drawing.Size(218, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 53);
            this.panel2.TabIndex = 2;
            // 
            // GerEmp
            // 
            this.GerEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GerEmp.Location = new System.Drawing.Point(0, 88);
            this.GerEmp.Name = "GerEmp";
            this.GerEmp.Size = new System.Drawing.Size(218, 35);
            this.GerEmp.TabIndex = 5;
            this.GerEmp.Text = "Gerer Employes";
            this.GerEmp.UseVisualStyleBackColor = false;
            // 
            // AffEmp
            // 
            this.AffEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AffEmp.Location = new System.Drawing.Point(0, 54);
            this.AffEmp.Name = "AffEmp";
            this.AffEmp.Size = new System.Drawing.Size(218, 35);
            this.AffEmp.TabIndex = 4;
            this.AffEmp.Text = "Liste des Employes";
            this.AffEmp.UseVisualStyleBackColor = false;
            // 
            // btnEmployes
            // 
            this.btnEmployes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployes.Location = new System.Drawing.Point(0, 3);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(218, 48);
            this.btnEmployes.TabIndex = 2;
            this.btnEmployes.Text = "Employes";
            this.btnEmployes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(824, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 39);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rendez-vous";
            this.label4.Visible = false;
            // 
            // btnGerCon
            // 
            this.btnGerCon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerCon.Location = new System.Drawing.Point(0, 88);
            this.btnGerCon.Name = "btnGerCon";
            this.btnGerCon.Size = new System.Drawing.Size(218, 35);
            this.btnGerCon.TabIndex = 7;
            this.btnGerCon.Text = "Gerer Consultation";
            this.btnGerCon.UseVisualStyleBackColor = false;
            // 
            // btnAffCon
            // 
            this.btnAffCon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAffCon.Location = new System.Drawing.Point(0, 54);
            this.btnAffCon.Name = "btnAffCon";
            this.btnAffCon.Size = new System.Drawing.Size(218, 35);
            this.btnAffCon.TabIndex = 6;
            this.btnAffCon.Text = "Liste des Consultations";
            this.btnAffCon.UseVisualStyleBackColor = false;
            // 
            // btnConsultation
            // 
            this.btnConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultation.Location = new System.Drawing.Point(0, 3);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(218, 48);
            this.btnConsultation.TabIndex = 3;
            this.btnConsultation.Text = "Consultations";
            this.btnConsultation.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGerCon);
            this.panel3.Controls.Add(this.btnAffCon);
            this.panel3.Controls.Add(this.btnConsultation);
            this.panel3.Location = new System.Drawing.Point(3, 175);
            this.panel3.MaximumSize = new System.Drawing.Size(218, 124);
            this.panel3.MinimumSize = new System.Drawing.Size(218, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 53);
            this.panel3.TabIndex = 1;
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezVous.Location = new System.Drawing.Point(3, 234);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(218, 48);
            this.btnRendezVous.TabIndex = 4;
            this.btnRendezVous.Text = "Rendez-Vous";
            this.btnRendezVous.UseVisualStyleBackColor = true;
            // 
            // btnReglage
            // 
            this.btnReglage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReglage.Location = new System.Drawing.Point(3, 288);
            this.btnReglage.Name = "btnReglage";
            this.btnReglage.Size = new System.Drawing.Size(218, 48);
            this.btnReglage.TabIndex = 5;
            this.btnReglage.Text = "Reglages";
            this.btnReglage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(819, 410);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 102;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(446, 206);
            this.dataGridView3.TabIndex = 22;
            this.dataGridView3.Visible = false;
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
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 548);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // AcceuilDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 556);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConsultationGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "AcceuilDoctors";
            this.Text = "AcceuilDoctors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AcceuilDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsGrid;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerPat;
        private System.Windows.Forms.Button btnAffPat;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ConsultationGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GerEmp;
        private System.Windows.Forms.Button AffEmp;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGerCon;
        private System.Windows.Forms.Button btnAffCon;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnReglage;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}