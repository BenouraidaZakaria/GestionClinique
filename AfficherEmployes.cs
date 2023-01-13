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
    public partial class AfficherEmployes : Form
    {
        // instancer la class formC for the menu
        FormC f = new FormC();

        // declartion les variables pour afficher contenue d'une champ dans le menu
        static Boolean etatBtnPatient = true;
        static Boolean etatBtnDocteur = true;
        static Boolean etatBtnConsultation = true;

        public AfficherEmployes()
        {
            InitializeComponent();
        }

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

        private void btnDocteur_Click(object sender, EventArgs e)
        {
            if (etatBtnDocteur)
            {
                panel2.Height += 72;
                etatBtnDocteur = false;
            }
            else
            {
                panel2.Height -= 72;
                etatBtnDocteur = true;
            }
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

        private void btnListPatients_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherPatients");
            this.Hide();
        }

        private void btnAjouterPatient_Click(object sender, EventArgs e)
        {
            f.formInstance("AjouterPatient");
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherEmployes");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherEmployes");
            this.Hide();
        }

        private void btnListConsultation_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherConsultations");
            this.Hide();
        }

        private void btnAjoutConsultation_Click(object sender, EventArgs e)
        {
            f.formInstance("AjouterConsultation");
            this.Hide();
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            txtRecherche.ForeColor = Color.Black;
        }

        // placeholder de textBox
        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            txtRecherche.Text = "recherche";
            txtRecherche.ForeColor = Color.Gray;
        }

        private void AfficherEmployes_Load(object sender, EventArgs e)
        {
            btnAccueil.Focus();
        }
    }
}
