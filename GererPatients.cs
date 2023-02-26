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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GestionClinique
{
    public partial class GererPatients : Form
    {
        Connection con = new Connection();
        public int ID=1;

        public string Nom
        {
            get { return txtNom.Text; }
            set { txtNom.Text = value; }
        }
        public string Prenom
        {
            get { return txtPrenom.Text; }
            set { txtPrenom.Text = value; }
        }
        public string Sexe
        {
            get { return cmbSexe.Text; }
            set { cmbSexe.Text = value; }
        }
        public string DateNaissance
        {
            get { return datpickNaissance.Text; }
            set { datpickNaissance.Text = value; }
        }
        public string Adresse
        {
            get { return txtAdresse.Text; }
            set { txtAdresse.Text = value; }
        }
        public string Telephone
        {
            get { return txtTelephone.Text; }
            set { txtTelephone.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Assurance
        {
            get { return cmbassur.Text; }
            set { cmbassur.Text = value; }
        }
        public string Allergie
        {
            get { return lisAll.Text; }
            set { lisAll.Items.Add(value); }
        }
        //public Image MyImage
        //{
        //    get { return imgPatient.Image; }
        //    set { imgPatient.Image = value; }
        //}

        public GererPatients()
        {
            InitializeComponent();
        }


        private void GererPatients_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

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
        private void ajouter_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            try
            {
                Boolean checkEmail = false;
                Boolean checkTele = false;
                if (txtNom.Text != "" && txtPrenom.Text != "" && cmbSexe.Text != "" && txtTelephone.Text != "" && datpickNaissance.Value.Date <= DateTime.Now.Date)
                {
                    if (txtEmail.Text.Contains("@gmail.com") || txtEmail.Text.Contains("@outlook.com") || txtEmail.Text.Contains("@live.com") || txtEmail.Text == "")
                        checkEmail = true;
                    else
                        errorProvider1.SetError(txtEmail, "Email n'est pas Valide");
                    
                    if (txtTelephone.Text.Length == 10 && (txtTelephone.Text.StartsWith("05") || txtTelephone.Text.StartsWith("06") || txtTelephone.Text.StartsWith("07")))
                        checkTele = true;
                    else
                        errorProvider1.SetError(txtTelephone, "Telephone n'est pas Valide");

                    if (checkEmail == true && checkTele == true)
                    {
                        DateTime now = DateTime.Now;
                        String imgname = txtNom.Text + txtPrenom.Text + now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                        File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\" + imgname);


                    string allergies = "";
                    foreach (string item in lisAll.Items)
                    {
                        allergies += item + ",";
                    }
                    //Remove the trailing comma from the end of the string
                    allergies = allergies.TrimEnd(','); 
                   

                       
                        con.ajouterPatient(txtNom.Text, txtPrenom.Text, DateTime.Parse(datpickNaissance.Text), char.Parse(cmbSexe.Text), txtEmail.Text, txtTelephone.Text, txtAdresse.Text, cmbassur.Text, Path.GetFileNameWithoutExtension(imgname), lisAll.Text);
                        txtNom.Text = txtPrenom.Text = cmbSexe.Text = txtTelephone.Text = datpickNaissance.Text = txtEmail.Text = txtAdresse.Text = cmbassur.Text = "";
                        lisAll.Items.Clear();
                        imagePatient.Image = null;
                    }
                }
                else
                {
                    if (txtNom.Text == "")
                    {
                        errorProvider1.SetError(txtNom, "Nom est Obligatoire");
                    }
                    if (txtPrenom.Text == "")
                    {
                        errorProvider1.SetError(txtPrenom, "Prenom est Obligatoire");
                    }
                    if (cmbSexe.Text == "")
                    {
                        errorProvider1.SetError(cmbSexe, "Genre est Obligatoire");
                    }
                    if (txtTelephone.Text == "")
                    {
                        errorProvider1.SetError(txtTelephone, "Telephone est Obligatoire");
                    }
                    if (datpickNaissance.Value.Date > DateTime.Now.Date)
                    {
                        errorProvider1.SetError(datpickNaissance, "Date de Naissance n'est pas Valide");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && cmbSexe.Text != "" && txtTelephone.Text != "" && datpickNaissance.Value.Date <= DateTime.Now.Date)
                {
                    DateTime now = DateTime.Now;
                    String imgname = txtNom.Text + txtPrenom.Text + now.ToString("yyyyMMddHHmmssfff") + ".jpg";

                    File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\" + imgname);
                    string allergies = "";
                    foreach (string item in lisAll.Items)
                    {
                        allergies += item + ",";
                    }
                    con.modifierPatient(ID, txtNom.Text, txtPrenom.Text, DateTime.Parse(datpickNaissance.Text), char.Parse(cmbSexe.Text), txtEmail.Text, txtTelephone.Text, txtAdresse.Text, cmbassur.Text, Path.GetFileNameWithoutExtension(imgname), allergies);

                    txtNom.Text = txtPrenom.Text = cmbSexe.Text = txtTelephone.Text = datpickNaissance.Text = txtEmail.Text = txtAdresse.Text = cmbassur.Text = "";
                    lisAll.Items.Clear();
                    imagePatient.Image = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void select_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            AfficherPatients f = new AfficherPatients();
            //f.SetInvisibilityAndTriggerEvent(); // Call the method to set invisibility and trigger event
            f.flowLayoutPanel1.Visible = false;
            f.Show();
            //f.SetInvisibilityAndTriggerEvent();
            this.Hide();
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
            errorProvider1.Dispose();

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
            errorProvider1.Dispose();

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
            errorProvider1.Dispose();

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

        private void addall_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (cmbAll.Text != "")
                lisAll.Items.Add(cmbAll.SelectedItem.ToString());
            else
                errorProvider1.SetError(cmbAll, "selectionner ou saisir allergie");
        }

        private void rmvtall_Click(object sender, EventArgs e)
        {
            if (lisAll.Items.Count > 0) 
            {
                if (lisAll.SelectedIndex != -1)
                    lisAll.Items.RemoveAt(lisAll.SelectedIndex);
                else
                    errorProvider1.SetError(lisAll, "selectionner allergie");
            }

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

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            cmbSexe.SelectedIndex = -1;
            txtTelephone.Text = "";
            datpickNaissance.Value=DateTime.Now;
            txtEmail.Text = "";
            txtAdresse.Text = "";
            cmbassur.SelectedIndex = -1;
            lisAll.Items.Clear();
            imagePatient.Image = null;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (con.supprimerPatient(ID))
            {
                MessageBox.Show("suppression avec succès");
            }
            else
            {
                MessageBox.Show("Selectionner un patinet");
            }
        }
    }
}
