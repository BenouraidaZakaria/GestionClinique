using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    public partial class AfficherPatients : Form
    {
        Connection con = new Connection();
        public AfficherPatients()
        {
            InitializeComponent();
        }

        private void AfficherPatients_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);


            // close the connection
            con.deConnecter();

            if (Program.typeuser == "docteur")
            {
                con.remplir(PatientsGrid, "PATIENT", Program.iduser);
                PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                panel2.Visible = false;
                btnGerPat.Visible = false;
                btnGerCon.Visible = false;

            } else if (Program.typeuser == "secretaire")
            {
                con.remplir(PatientsGrid, "PATIENT");
                PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }
        FormC f = new FormC();

        static Boolean etatBtnPatient = true;
        static Boolean etatBtnEmployes = true;
        static Boolean etatBtnConsultation = true;
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            if (Program.typeuser == "docteur")
            {
                f.formInstance("AcceuilDoctors");
                this.Hide();
            }
            else if (Program.typeuser == "secretaire")
            {
                f.formInstance("AccueilSecretaire");
                this.Hide();
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (Program.typeuser == "docteur")
            {
                if (etatBtnPatient)
                {
                    panel1.Height += 36;
                    etatBtnPatient = false;
                }
                else
                {
                    panel1.Height -= 36;
                    etatBtnPatient = true;
                }
            }
            else if (Program.typeuser == "secretaire")
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
            if (Program.typeuser == "docteur")
            {
                if (etatBtnConsultation)
                {
                    panel3.Height += 36;
                    etatBtnPatient = false;
                }
                else
                {
                    panel3.Height -= 36;
                    etatBtnPatient = true;
                }
            }
            else if (Program.typeuser == "secretaire")
            {
                if (etatBtnConsultation)
                {
                    panel3.Height += 72;
                    etatBtnPatient = false;
                }
                else
                {
                    panel3.Height -= 72;
                    etatBtnPatient = true;
                }
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
        private void PatientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientsGrid.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row

                if (Program.typeuser == "docteur")
                {
                    // create a new instance of the other form
                    DossierMedicalPatient otherForm = new DossierMedicalPatient();

                    // set the values of the controls in the other form
                    otherForm.ID = (int)selectedRow.Cells["IDPATIENT"].Value;
                    otherForm.Nom = selectedRow.Cells["NOM"].Value.ToString();
                    otherForm.Prenom = selectedRow.Cells["PRENOM"].Value.ToString();
                    otherForm.DateNaissance = selectedRow.Cells["DATENAISSANCE"].Value.ToString();
                    otherForm.Adresse = selectedRow.Cells["ADRESSE"].Value.ToString();
                    otherForm.Telephone = selectedRow.Cells["TELEPHONE"].Value.ToString();
                    otherForm.Email = selectedRow.Cells["EMAIL"].Value.ToString();
                    otherForm.Sexe = selectedRow.Cells["GENRE"].Value.ToString();
                    otherForm.Assurance = selectedRow.Cells["ASSURANCE"].Value.ToString();
                    //string imageName = selectedRow.Cells["IMAGE"].Value.ToString();
                    //string imagePath = Path.Combine(Application.StartupPath, "IMAGES", "PROFILE", imageName);

                    //if (File.Exists(imagePath))
                    //{
                    //    Image image = Image.FromFile(imagePath);
                    //    otherForm.MyImage = image;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("The image file does not exist.");
                    //}
                    otherForm.Show();
                    this.Hide();
                }
                else if (Program.typeuser == "secretaire")
                {
                    // create a new instance of the other form
                    GererPatients otherForm = new GererPatients();

                    // set the values of the controls in the other form
                    otherForm.ID = (int)selectedRow.Cells["IDPATIENT"].Value;
                    otherForm.Nom = selectedRow.Cells["NOM"].Value.ToString();
                    otherForm.Prenom = selectedRow.Cells["PRENOM"].Value.ToString();
                    otherForm.DateNaissance = selectedRow.Cells["DATENAISSANCE"].Value.ToString();
                    otherForm.Adresse = selectedRow.Cells["ADRESSE"].Value.ToString();
                    otherForm.Telephone = selectedRow.Cells["TELEPHONE"].Value.ToString();
                    otherForm.Email = selectedRow.Cells["EMAIL"].Value.ToString();
                    otherForm.Sexe = selectedRow.Cells["GENRE"].Value.ToString();
                    otherForm.Assurance = selectedRow.Cells["ASSURANCE"].Value.ToString();
                    // ... set the values of other controls as needed

                    // show the other form
                    otherForm.Show();
                    this.Hide();
                }
            }
            else
            {
                // handle the case when there are no selected rows
                MessageBox.Show("Please select a row to view.");
            }
        }
    }
}
