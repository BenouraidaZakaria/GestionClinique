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
            else if (nomForm == "AcceuilDoctors")
            {
                f = new AcceuilDoctors();
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
            else if (nomForm == "GererConsultations")
            {
                //get the now DATETIME?
                DateTime now = DateTime.Now;

                f = new GererConsultations(0,0,0,now,"","");
                f.Show();
            }
            else if (nomForm == "GererEmployes")
            {
                f = new GererEmployes();
                f.Show();
            }
            else if (nomForm == "GererPatients")
            {
                f = new GererPatients();
                f.Show();
            }

            return f;
        }
    }
}
