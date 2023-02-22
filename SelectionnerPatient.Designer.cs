namespace GestionClinique
{
    partial class SelectionnerPatient
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
            this.slcPat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slcPat)).BeginInit();
            this.SuspendLayout();
            // 
            // slcPat
            // 
            this.slcPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slcPat.Location = new System.Drawing.Point(141, 235);
            this.slcPat.Name = "slcPat";
            this.slcPat.RowHeadersWidth = 102;
            this.slcPat.RowTemplate.Height = 40;
            this.slcPat.Size = new System.Drawing.Size(2169, 1056);
            this.slcPat.TabIndex = 0;
            this.slcPat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.slcPat_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner Un Patient";
            // 
            // SelectionnerPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2425, 1381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slcPat);
            this.Name = "SelectionnerPatient";
            this.Text = "SelectionnerPatient";
            this.Load += new System.EventHandler(this.SelectionnerPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slcPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView slcPat;
        private System.Windows.Forms.Label label1;
    }
}