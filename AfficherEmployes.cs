using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    public partial class AfficherEmployes : Form
    {
        Connection con = new Connection();

        public AfficherEmployes()
        {
            InitializeComponent();
        }
        private void AfficherEmployes_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            con.remplir(EmployesGrid, "EMPLOYEE");
            EmployesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        FormC f = new FormC();

        static Boolean etatBtnPatient = true;
        static Boolean etatBtnEmployes = true;
        static Boolean etatBtnConsultation = true;

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            f.formInstance("AccueilSecretaire");
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (etatBtnPatient)
            {
                panel1.Height += 72;
                etatBtnPatient = false;
            }
            else
            {
                panel1.Height -= 72;
                etatBtnPatient = true;
            }
        }

        private void btnAffPat_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherPatients");
            this.Hide();
        }

        private void btnGerPat_Click(object sender, EventArgs e)
        {
            f.formInstance("GererPatients");
            this.Hide();
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            if (etatBtnEmployes)
            {
                panel2.Height += 72;
                etatBtnEmployes = false;
            }
            else
            {
                panel2.Height -= 72;
                etatBtnEmployes = true;
            }
        }

        private void AffEmp_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherEmployes");
            this.Hide();
        }

        private void GerEmp_Click(object sender, EventArgs e)
        {
            f.formInstance("GererEmployes");
            this.Hide();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            if (etatBtnConsultation)
            {
                panel3.Height += 72;
                etatBtnConsultation = false;
            }
            else
            {
                panel3.Height -= 72;
                etatBtnConsultation = true;
            }
        }

        private void btnAffCon_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherConsultations");
            this.Hide();
        }

        private void btnGerCon_Click(object sender, EventArgs e)
        {
            f.formInstance("GererConsultations");
            this.Hide();
        }

        private void EmployesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = EmployesGrid.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row


                // create a new instance of the other form
                GererEmployes otherForm = Application.OpenForms.OfType<GererEmployes>().FirstOrDefault();

                // set the values of the controls in the other form
                otherForm.ID = (int)selectedRow.Cells["IDEMPLOYEE"].Value;
                otherForm.Type = selectedRow.Cells["TYPE"].Value.ToString();
                otherForm.Nom = selectedRow.Cells["NOM"].Value.ToString();
                otherForm.Prenom = selectedRow.Cells["PRENOM"].Value.ToString();
                otherForm.DateNaissance = selectedRow.Cells["DATE_NAISSANCE"].Value.ToString();
                otherForm.Telephone = selectedRow.Cells["TELEPHONE"].Value.ToString();
                otherForm.Mail = selectedRow.Cells["EMAIL"].Value.ToString();
                otherForm.MDP = selectedRow.Cells["MOT_PASSE"].Value.ToString();
                otherForm.Genre = selectedRow.Cells["GENRE"].Value.ToString();

                string ImgPath = Path.Combine(Application.StartupPath, "IMAGES", selectedRow.Cells["IMAGE"].Value.ToString());

                Image image = Image.FromFile(ImgPath + ".jpg");
                otherForm.imageEmp.Image = image;
                //otherForm.Specailite = selectedRow.Cells["SPECIALITE"].Value.ToString();
                // ... set the values of other controls as needed
                if (otherForm.Type == "docteur")
                {
                    otherForm.IsDoc = true;
                    otherForm.IsSec= false;
                }
                else if (otherForm.Type == "secretaire")
                {
                    otherForm.IsDoc = false;
                    otherForm.IsDoc = true;
                }
                // show the other form
                otherForm.Show();
                this.Hide();
            }
            else
            {
                // handle the case when there are no selected rows
                MessageBox.Show("Please select a row to view.");
            }
        }
    }
}
