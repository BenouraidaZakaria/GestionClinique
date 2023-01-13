using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    class FormC
    {
        public Form formInstance(string nomForm)
        {
            Form f = null;
            if (nomForm == "AccueilSecretaire")
            {
                f = new AccueilSecretaire();
                f.Show();
            }
            else if (nomForm == "AfficherConsultations")
            {
                f = new AfficherConsultations();
                f.Show();
            }
            else if (nomForm == "AfficherEmployes")
            {
                f = new AfficherEmployes();
                f.Show();
            }
            else if (nomForm == "AfficherPatients")
            {
                f = new AfficherPatients();
                f.Show();
            }
            else if (nomForm == "AjouterConsultation")
            {
                f = new AjouterConsultation();
                f.Show();
            }
            else if (nomForm == "AjouterEmploye")
            {
                f = new AjouterEmploye();
                f.Show();
            }
            else if (nomForm == "AjouterPatient")
            {
                f = new AjouterPatient();
                f.Show();
            }

            return f;
        }
    }
}
