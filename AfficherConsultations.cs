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
    public partial class AfficherConsultations : Form
    {
        Connection con = new Connection();

        public AfficherConsultations()
        {
            InitializeComponent();
        }
        private void AfficherConsultations_Load(object sender, EventArgs e)

        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
       
         
                con.remplir(ConsultationsGrid, "CONSULTATION");
                ConsultationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

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

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form f = new login();
            Program.iduser = 0; ;
            Program.nameuser = "";
            Program.prenomuser = "";
            Program.typeuser = "";
            f.Show();
            this.Hide();
        }
        private void ConsultationsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ConsultationsGrid.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row

                // create a new instance of the GererConsultations form
                GererConsultations existingForm = Application.OpenForms.OfType<GererConsultations>().FirstOrDefault();

                if (existingForm != null)
                {
                    string prescriptionImagePath = Path.Combine(Application.StartupPath, "IMAGES", selectedRow.Cells["PRESCRIPTION"].Value.ToString());

                    Image prescriptionImage = Image.FromFile(prescriptionImagePath+".jpg");
                    existingForm.imagePrescription.Image = prescriptionImage;
                    // if an instance of the GererConsultations form already exists, pass the data to it
                    existingForm.ID = (int)selectedRow.Cells["ID"].Value;
                    existingForm.IDP = (int)selectedRow.Cells["ID Patient"].Value;
                    existingForm.IDD = (int)selectedRow.Cells["ID Docteur"].Value;

                    existingForm.DateConsultation = (DateTime)selectedRow.Cells["Date"].Value;

                    //existingForm.Traitement = selectedRow.Cells["Traitement"].Value.ToString();
                    //existingForm.Diagnostic = selectedRow.Cells["DIAGNOSTIC"].Value.ToString();
                    string traitstring= selectedRow.Cells["Traitement"].Value.ToString();

                    if (!string.IsNullOrEmpty(traitstring))
                    {
                        string[] traitArray = traitstring.Split(',');
                        foreach (string trait in traitArray)
                        {
                            existingForm.listtrai.Items.Add(trait.Trim());
                        }
                    }
                    string diagstring= selectedRow.Cells["DIAGNOSTIC"].Value.ToString();

                    if (!string.IsNullOrEmpty(diagstring))
                    {
                        string[] diagArray = diagstring.Split(',');
                        foreach (string diag in diagArray)
                        {
                            existingForm.listdiag.Items.Add(diag.Trim());
                        }
                    }


                    // ... set the values of other controls as needed
                    int selectedPatientID = (int)selectedRow.Cells["ID Patient"].Value;
                    DataTable patientTable = new DataTable();
                    con.select("PATIENT", selectedPatientID, patientTable);
                    existingForm.NameP = patientTable.Rows[0]["NOM"].ToString();
                    existingForm.PreP = patientTable.Rows[0]["PRENOM"].ToString();

                    existingForm.textPat.Text = existingForm.NameP.Trim() + ' ' + existingForm.PreP.Trim();
                    int selectedDoctorID = (int)selectedRow.Cells["ID DOCTEUR"].Value;

                    DataTable doctorTable = new DataTable();
                    con.select("DOCTEUR", selectedDoctorID, doctorTable);
                    existingForm.NomD = doctorTable.Rows[0]["NOM"].ToString();
                    existingForm.PreD = doctorTable.Rows[0]["PRENOM"].ToString();
                    existingForm.textDoc.Text = existingForm.NomD.Trim() + ' ' + existingForm.PreD.Trim();
                }
                else
                {
                    // if an instance of the GererConsultations form does not exist, create a new one and pass the data to it
                    GererConsultations newForm = new GererConsultations((int)selectedRow.Cells["ID"].Value, (int)selectedRow.Cells["ID Patient"].Value, (int)selectedRow.Cells["ID Docteur"].Value, (DateTime)selectedRow.Cells["Date"].Value, selectedRow.Cells["Traitement"].Value.ToString(), selectedRow.Cells["DIAGNOSTIC"].Value.ToString());
                    newForm.Show();
                }
                this.Hide();
            }
            else
            {
                // handle the case when there are no selected rows
                MessageBox.Show("Please select a row to view.");
            }
        }
        //if (e.RowIndex >= 0)
        //{
        //    DataGridViewRow selectedRow = ConsultationsGrid.Rows[e.RowIndex];
        //    // rest of the code to get the data from the selected row


        //    // create a new instance of the other form
        //    GererConsultations otherForm = new GererConsultations();

        //    // set the values of the controls in the other form
        //    otherForm.ID = (int)selectedRow.Cells["ID"].Value;
        //    //otherForm.IDP = (int)selectedRow.Cells["ID Patient"].Value;
        //    //otherForm.IDD = (int)selectedRow.Cells["ID Docteur"].Value;
        //    otherForm.DateConsultation = (DateTime)selectedRow.Cells["Date"].Value;
        //    otherForm.Traitement = selectedRow.Cells["Traitement"].Value.ToString();
        //    otherForm.Diagnostic = selectedRow.Cells["DIAGNOSTIC"].Value.ToString();
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
    
