using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    public partial class SelectionnerDocteur : Form
    {
     Connection con=new Connection();
        public SelectionnerDocteur()
        {
            InitializeComponent();
        }

        private void SelectionnerDocteur_Load(object sender, EventArgs e)
        {
            con.remplir(sltDoc, "DOCTEUR");
            sltDoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sltDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = sltDoc.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row

                // get the instance of the other form if it exists, or create a new one if it doesn't
                GererConsultations otherForm = Application.OpenForms.OfType<GererConsultations>().FirstOrDefault();

                // set the values of the controls in the other form
                otherForm.IDD = (int)selectedRow.Cells["ID"].Value;
                otherForm.NomD = (string)selectedRow.Cells["NOM"].Value;
                otherForm.PreD = (string)selectedRow.Cells["PRENOM"].Value;
                // ... set the values of other controls as needed
                // show the other form
                otherForm.Show();
                this.Hide();
            }
            else
            {
                // handle the case when there are no selected rows
                MessageBox.Show("Please select a row to view.");
            }
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = sltDoc.Rows[e.RowIndex];
            //    // rest of the code to get the data from the selected row


            //    // create a new instance of the other form
            //    GererConsultations otherForm = new GererConsultations();

            //    // set the values of the controls in the other form
            //    otherForm.IDD = (int)selectedRow.Cells["ID"].Value;
            //    otherForm.NomD= (string)selectedRow.Cells["NOM"].Value;
            //    otherForm.PreD= (string)selectedRow.Cells["PRENOM"].Value;
            //    // ... set the values of other controls as needed
            //    // show the other form
            //    otherForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    // handle the case when there are no selected rows
            //    MessageBox.Show("Please select a row to view.");
            //}
        }
    }
}
