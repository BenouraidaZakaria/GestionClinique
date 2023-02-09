using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GestionClinique
{
    public partial class GererPatients : Form
    {
        // instancer la class formC for the menu
        FormC f = new FormC();

        // declartion les variables pour afficher contenue d'une champ dans le menu
        static Boolean etatBtnPatient = true;
        static Boolean etatBtnDocteur = true;
        static Boolean etatBtnConsultation = true;

        public GererPatients()
        {
            InitializeComponent();
        }


        private void GererPatients_Load(object sender, EventArgs e)
        {
            btnAccueil.Focus();

        }
        private void btnAccueil_Click_1(object sender, EventArgs e)
        {
            f.formInstance("AccueilSecretaire");
            this.Hide();
        }

        private void btnPatients_Click_1(object sender, EventArgs e)
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

        private void btnDocteur_Click_1(object sender, EventArgs e)
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

        private void btnConsultation_Click_1(object sender, EventArgs e)
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
        private void imagePatient_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imageText.Text = dialog.FileName;
                imageLocation = dialog.FileName;
                imagePatient.ImageLocation = imageLocation;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\PROFILE\" + Path.GetFileName(imagePatient.ImageLocation));
        }

       

        
    }
}
