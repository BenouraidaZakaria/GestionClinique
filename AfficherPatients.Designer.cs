
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
            this.components = new System.ComponentModel.Container();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.idpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CliniqueDataSet = new GestionClinique.DB_CliniqueDataSet();
            this.patientsTableAdapter = new GestionClinique.DB_CliniqueDataSetTableAdapters.PatientsTableAdapter();
            this.menu1 = new GestionClinique.Menu();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CliniqueDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.PatientsGrid.AutoGenerateColumns = false;
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpatientDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teleDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.assuranceDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.PatientsGrid.DataSource = this.patientsBindingSource;
            this.PatientsGrid.Location = new System.Drawing.Point(653, 252);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.RowHeadersWidth = 102;
            this.PatientsGrid.RowTemplate.Height = 40;
            this.PatientsGrid.Size = new System.Drawing.Size(2713, 1248);
            this.PatientsGrid.TabIndex = 7;
            // 
            // idpatientDataGridViewTextBoxColumn
            // 
            this.idpatientDataGridViewTextBoxColumn.DataPropertyName = "idpatient";
            this.idpatientDataGridViewTextBoxColumn.HeaderText = "idpatient";
            this.idpatientDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.idpatientDataGridViewTextBoxColumn.Name = "idpatientDataGridViewTextBoxColumn";
            this.idpatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpatientDataGridViewTextBoxColumn.Width = 250;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 250;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.Width = 250;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "sexe";
            this.sexeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.Width = 250;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 250;
            // 
            // teleDataGridViewTextBoxColumn
            // 
            this.teleDataGridViewTextBoxColumn.DataPropertyName = "tele";
            this.teleDataGridViewTextBoxColumn.HeaderText = "tele";
            this.teleDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.teleDataGridViewTextBoxColumn.Name = "teleDataGridViewTextBoxColumn";
            this.teleDataGridViewTextBoxColumn.Width = 250;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 250;
            // 
            // assuranceDataGridViewTextBoxColumn
            // 
            this.assuranceDataGridViewTextBoxColumn.DataPropertyName = "assurance";
            this.assuranceDataGridViewTextBoxColumn.HeaderText = "assurance";
            this.assuranceDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.assuranceDataGridViewTextBoxColumn.Name = "assuranceDataGridViewTextBoxColumn";
            this.assuranceDataGridViewTextBoxColumn.Width = 250;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Width = 250;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dB_CliniqueDataSet;
            // 
            // dB_CliniqueDataSet
            // 
            this.dB_CliniqueDataSet.DataSetName = "DB_CliniqueDataSet";
            this.dB_CliniqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(600, 1500);
            this.menu1.TabIndex = 9;
            // 
            // AfficherPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3437, 1811);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.txtRecherche);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AfficherPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Patients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AfficherPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CliniqueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PatientsGrid;
        private DB_CliniqueDataSet dB_CliniqueDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DB_CliniqueDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private Menu menu1;
    }
}