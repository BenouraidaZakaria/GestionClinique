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
    public partial class AcceuilDoctors : Form
    {
        Connection con = new Connection();
        // instancer la class formC for the menu
        FormC f = new FormC();

        // declartion les variables pour afficher contenue d'une champ dans le menu
        static Boolean etatBtnPatient = true;
        static Boolean etatBtnConsultation = true;
        public AcceuilDoctors()
        {
            InitializeComponent();
            //con.remplir(PatientsGrid, "PATIENT");
            con.remplir(PatientsGrid, "PATIENT", Program.iduser);
            //con.remplir(ConsultationGrid, "CONSULTATION");
            con.remplir(Consultationgrid, "CONSULTATION", Program.iduser);
            Consultationgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AcceuilDoctors_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            f.formInstance("AcceuilDoctors");
            this.Hide();
        }

        //private void btnPatients_Click(object sender, EventArgs e)
        //{
        //    if (etatBtnPatient)
        //    {
        //        panel1.Height += 36;
        //        etatBtnPatient = false;
        //    }
        //    else
        //    {
        //        panel1.Height -= 36;
        //        etatBtnPatient = true;
        //    }
        //}

        //private void btnConsultation_Click(object sender, EventArgs e)
        //{
        //    if (etatBtnConsultation)
        //    {
        //        panel3.Height += 36;
        //        etatBtnConsultation = false;
        //    }
        //    else
        //    {
        //        panel3.Height -= 36;
        //        etatBtnConsultation = true;
        //    }
        //}

        private void btnAffPat_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherPatients");
            this.Hide();
        }

        private void btnAffCon_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherConsultations");
            this.Hide();
        }

        private void PatientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientsGrid.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row

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
        }

        private void Consultationgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Consultationgrid.Rows[e.RowIndex];
                // rest of the code to get the data from the selected row

                int idConsultation = (int)selectedRow.Cells["IDCONSULTATION"].Value;
                string dateConsultation = selectedRow.Cells["DATE"].Value.ToString();
                string traitement = selectedRow.Cells["TRAITEMENT"].Value.ToString();
                string diagnostic = selectedRow.Cells["DIAGNOSTIC"].Value.ToString();
                // create a new instance of the other form
                AfficherConsultation otherForm = new AfficherConsultation();

                // set the values of the controls in the other form
                otherForm.ID = idConsultation;
                otherForm.DateConsultation = dateConsultation;
                otherForm.Traitement = traitement;
                otherForm.Diagnostic = diagnostic;
                otherForm.ShowDialog();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form f= new login();
            Program.iduser = 0; ;
            Program.nameuser = "";
            Program.prenomuser= "";
            Program.typeuser = "";
            f.Show();
            this.Hide();
        }
    }
}
