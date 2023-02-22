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
        static Boolean etatBtnEmployes = true;
        static Boolean etatBtnConsultation = true;
        public AcceuilDoctors()
        {
            InitializeComponent();
            //con.remplir(PatientsGrid, "PATIENT");
            con.remplir(PatientsGrid, "PATIENT", Program.iduser);
            //con.remplir(ConsultationGrid, "CONSULTATION");
            con.remplir(ConsultationGrid, "CONSULTATION",Program.iduser);
            ConsultationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AcceuilDoctors_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.iduser.ToString());
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
                f.formInstance("AcceuilDoctors");
                this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
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

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            if (etatBtnConsultation)
            {
                panel3.Height += 36;
                etatBtnConsultation = false;
            }
            else
            {
                panel3.Height -= 36;
                etatBtnConsultation = true;
            }
        }

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
    }
}
