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
    public partial class SelectionnerPatient : Form
    {
        Connection con = new Connection();
        public SelectionnerPatient()
        {
            InitializeComponent();
        }

        private void SelectionnerPatient_Load(object sender, EventArgs e)
        {
            con.remplir(slcPat, "PATIENT");
            slcPat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void slcPat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = slcPat.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row

                // get the instance of GererConsultations form
                GererConsultations consultationsForm = Application.OpenForms.OfType<GererConsultations>().FirstOrDefault();

                // set the values of the controls in the GererConsultations form
                consultationsForm.IDP = (int)selectedRow.Cells["IDPATIENT"].Value;
                consultationsForm.NameP = (string)selectedRow.Cells["NOM"].Value;
                consultationsForm.PreP = (string)selectedRow.Cells["PRENOM"].Value;
                // ... set the values of other controls as needed
                // show the GererConsultations form
                consultationsForm.Show();
                this.Hide();
            }
            else
            {
                // handle the case when there are no selected rows
                MessageBox.Show("Please select a row to view.");
            }

            //if (e.RowIndex >= 0)
            //{

            //    DataGridViewRow selectedRow = slcPat.Rows[e.RowIndex];
            //    // rest of the code to get the data from the selected row


            //    // create a new instance of the other form
            //    GererConsultations otherForm = new GererConsultations();

            //    // set the values of the controls in the other form
            //    otherForm.IDP = (int)selectedRow.Cells["IDPATIENT"].Value;
            //    otherForm.NameP= (string)selectedRow.Cells["NOM"].Value;
            //    otherForm.PreP = (string)selectedRow.Cells["PRENOM"].Value;
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
