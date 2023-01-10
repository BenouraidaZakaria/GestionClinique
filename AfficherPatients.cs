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
    public partial class AfficherPatients : Form
    {
        static Boolean etatPanel1 = false;
        static Boolean etatPanel2 = false;
        static Boolean etatPanel3 = false;


        // le menu
        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (!etatPanel1)
            {
                panel1.Height += 72;
                etatPanel1 = true;
            }
            else
            {
                panel1.Height -= 72;
                etatPanel1 = false;
            }
        }
        private void btnDocteur_Click(object sender, EventArgs e)
        {
            if (!etatPanel2)
            {
                panel2.Height += 72;
                etatPanel2 = true;
            }
            else
            {
                panel2.Height -= 72;
                etatPanel2 = false;
            }
        }
        private void btnConsultation_Click(object sender, EventArgs e)
        {
            if (!etatPanel3)
            {
                panel3.Height += 72;
                etatPanel3 = true;
            }
            else
            {
                panel3.Height -= 72;
                etatPanel3 = false;
            }
        }

        public AfficherPatients()
        {
            InitializeComponent();
        }

        private void AfficherPatients_Load(object sender, EventArgs e)
        {
            btnAccueil.Focus();
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
    }
}
