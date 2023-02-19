
namespace GestionClinique
{
    partial class AfficherConsultations
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
            this.ConsultationsGrid = new System.Windows.Forms.DataGridView();
            this.menu1 = new GestionClinique.Menu();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationsGrid)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(621, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 95);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consultations";
            // 
            // ConsultationsGrid
            // 
            this.ConsultationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultationsGrid.Location = new System.Drawing.Point(622, 261);
            this.ConsultationsGrid.Name = "ConsultationsGrid";
            this.ConsultationsGrid.RowHeadersWidth = 102;
            this.ConsultationsGrid.RowTemplate.Height = 40;
            this.ConsultationsGrid.Size = new System.Drawing.Size(2969, 1248);
            this.ConsultationsGrid.TabIndex = 8;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(600, 1500);
            this.menu1.TabIndex = 9;
            // 
            // AfficherConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3653, 1786);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.ConsultationsGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecherche);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AfficherConsultations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Consultations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AfficherConsultations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultationsGrid;
        private Menu menu1;
    }
}