namespace GestionClinique
{
    partial class SelectionnerDocteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.sltDoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sltDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner Un Docteur";
            // 
            // sltDoc
            // 
            this.sltDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sltDoc.Location = new System.Drawing.Point(132, 236);
            this.sltDoc.Name = "sltDoc";
            this.sltDoc.RowHeadersWidth = 102;
            this.sltDoc.RowTemplate.Height = 40;
            this.sltDoc.Size = new System.Drawing.Size(2155, 1095);
            this.sltDoc.TabIndex = 1;
            this.sltDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sltDoc_CellClick);
            // 
            // SelectionnerDocteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2421, 1418);
            this.Controls.Add(this.sltDoc);
            this.Controls.Add(this.label1);
            this.Name = "SelectionnerDocteur";
            this.Text = "SelectionnerDocteur";
            this.Load += new System.EventHandler(this.SelectionnerDocteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sltDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sltDoc;
    }
}