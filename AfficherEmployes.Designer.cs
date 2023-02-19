
namespace GestionClinique
{
    partial class AfficherEmployes
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
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.menu1 = new GestionClinique.Menu();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
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
            this.txtRecherche.TabIndex = 3;
            this.txtRecherche.Text = "search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 95);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employes";
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Location = new System.Drawing.Point(653, 273);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.RowHeadersWidth = 102;
            this.PatientsGrid.RowTemplate.Height = 40;
            this.PatientsGrid.Size = new System.Drawing.Size(2969, 1248);
            this.PatientsGrid.TabIndex = 9;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(600, 1500);
            this.menu1.TabIndex = 11;
            // 
            // AfficherEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3653, 1786);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.txtRecherche);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AfficherEmployes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Employes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AfficherEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PatientsGrid;
        private Menu menu1;
    }
}