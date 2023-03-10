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
    public partial class GererEmployes : Form
    {
        Connection con = new Connection();
        public int ID;
        public string Type;
        public bool IsDoc
        {
            get { return rbDoc.Checked; }
            set { rbDoc.Checked = value; }
        }

        public bool IsSec
        {
            get { return rbSec.Checked; }
            set { rbSec.Checked = value; }
        }
        public string Nom
        {
            get { return Nomtxt.Text; }
            set { Nomtxt.Text = value; }
        }
        public string Prenom
        {
            get { return Pretxt.Text; }
            set { Pretxt.Text = value; }
        }
        public string Mail
        {
            get { return Mailtxt.Text; }
            set { Mailtxt.Text = value; }
        }
      
        public string DateNaissance
        {
            get { return dNaissance.Text; }
            set { dNaissance.Text = value; }
        }
        public string MDP
        {
            get { return Mdptxt.Text; }
            set { Mdptxt.Text = value; }
        }
        public string Telephone
        {
            get { return teletxt.Text; }
            set { teletxt.Text = value; }
        }
        //public string Specailite
        //{
        //    get { return Specmb.Text; }
        //    set { Specmb.Text = value; }
        //}
        public string Genre
        {
            get { return cmbGenre.Text; }
            set { cmbGenre.Text = value; }
        }

        // methode pour remplir et actualiser genre
        public void remplirGenre()
        {
            cmbGenre.Items.Clear();
            cmbGenre.Items.Add("M");
            cmbGenre.Items.Add("F");
        }
        
        // methode pour remplir et actualiser spécialité
        public void remplirSpecialite()
        {
            Specmb.Items.Clear();
            Specmb.Items.Add("ophtalmologue");
            Specmb.Items.Add("oto-rhino-laryngologie");
        }

        //public Image MyImage
        //{
        //    get { return imgPatient.Image; }
        //    set { imgPatient.Image = value; }
        //}



        String mailext ="@docteur.ma";
        public GererEmployes()
        {
            InitializeComponent();
        }
        private void GererEmployes_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            if (Type == "docteur")
            {
                rbDoc.Checked = true;
                rbSec.Enabled = false;
                ajtEmp.Enabled = false;
            }
            else if (Type == "secretaire")
            {
                rbSec.Checked = true;
                Specmb.SelectedIndex = -1;
                Specmb.Enabled = false;
                rbDoc.Enabled = false;
                ajtEmp.Enabled = false;
            }

            remplirGenre();
            remplirSpecialite();
        }
        private void rbDoc_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDoc.Checked)
            {
                mailext = "@docteur.ma";
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Specmb.Enabled = true;

                Nomtxt.Text = Pretxt.Text = Mailtxt.Text = Mdptxt.Text = Specmb.Text = cmbGenre.Text = dNaissance.Text = teletxt.Text = "";
                imageEmp.Image = null;
                remplirGenre();
                remplirSpecialite();
            }
            else if (rbSec.Checked)
            {
                mailext = "@secretaire.ma";
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Specmb.SelectedIndex = -1;
                Specmb.Enabled = false;

                Nomtxt.Text = Pretxt.Text = Mailtxt.Text = Mdptxt.Text = Specmb.Text = cmbGenre.Text = dNaissance.Text = teletxt.Text = "";
                imageEmp.Image = null;
                remplirGenre();
                remplirSpecialite();
            }
        }

        private void Nomtxt_TextChanged(object sender, EventArgs e)
        {
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Mdptxt.Text= Nomtxt.Text+Pretxt.Text;
        }

        private void Pretxt_TextChanged(object sender, EventArgs e)
        {
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Mdptxt.Text = Nomtxt.Text + Pretxt.Text;

        }

        private void eopen_Click(object sender, EventArgs e)
        {
            eopen.Visible = false;
            eclosed.Visible = true;
            Mdptxt.PasswordChar = '\0';
        }

        private void eclosed_Click(object sender, EventArgs e)
        {
            eopen.Visible = true;
            eclosed.Visible = false;
            Mdptxt.PasswordChar = '*';
        }


        private void select_Click(object sender, EventArgs e)
        {
            AfficherEmployes f = new AfficherEmployes();
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

        private void imageEmp_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imageText.Text = dialog.FileName;
                imageLocation = dialog.FileName;
                imageEmp.ImageLocation = imageLocation;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajtEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                String imgname = Nomtxt.Text + Pretxt.Text + now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\" + imgname);
                if (rbDoc.Checked)
                {
                    if (Nomtxt.Text != "" && Pretxt.Text != "" && Mailtxt.Text != "" && Mdptxt.Text != "" && Specmb.Text != "" && cmbGenre.Text != "" && dNaissance.Text != "" && teletxt.Text != "")
                    {
                        int tele = int.Parse(teletxt.Text);

                        if (con.ajouterEmploye(Nomtxt.Text, Pretxt.Text, Path.GetFileNameWithoutExtension(imgname), DateTime.Parse(dNaissance.Text), char.Parse(cmbGenre.Text), teletxt.Text, "docteur", Mailtxt.Text, Mdptxt.Text, Specmb.Text))
                        {
                            Nomtxt.Text = Pretxt.Text = Mailtxt.Text = Mdptxt.Text = Specmb.Text = cmbGenre.Text = dNaissance.Text = teletxt.Text = "";
                            imageEmp.Image = null;
                            remplirGenre();
                            remplirSpecialite();
                            MessageBox.Show("Ajouter avec Succès");
                        }
                    }
                    else
                    {
                        if (Nomtxt.Text == "")
                        {
                            errorProvider1.SetError(Nomtxt, "Nom est Obligatoire");
                        }
                        if (Pretxt.Text == "")
                        {
                            errorProvider1.SetError(Pretxt, "Prenom est Obligatoire");
                        }
                        if (cmbGenre.Text == "")
                        {
                            errorProvider1.SetError(cmbGenre, "Genre est Obligatoire");
                        }
                        if (teletxt.Text == "")
                        {
                            errorProvider1.SetError(teletxt, "Telephone est Obligatoire");
                        }
                        if (dNaissance.Value.Date > DateTime.Now.Date)
                        {
                            errorProvider1.SetError(dNaissance, "Date de Naissance n'est pas Valide");
                        }
                        if (Specmb.Text == "")
                        {
                            errorProvider1.SetError(Specmb, "Spécialité est Obligatoire");
                        }
                    }

                }
                else
                {
                    if (Nomtxt.Text != "" && Pretxt.Text != "" && Mailtxt.Text != "" && Mdptxt.Text != "" && cmbGenre.Text != "" && dNaissance.Text != "" && teletxt.Text != "")
                    {
                        int tele = int.Parse(teletxt.Text);

                        if (con.ajouterEmploye(Nomtxt.Text, Pretxt.Text, Path.GetFileNameWithoutExtension(imgname), DateTime.Parse(dNaissance.Text), char.Parse(cmbGenre.Text), teletxt.Text, "secretaire", Mailtxt.Text, Mdptxt.Text, null))
                        {
                            Nomtxt.Text = Pretxt.Text = Mailtxt.Text = Mdptxt.Text = Specmb.Text = cmbGenre.Text = dNaissance.Text = teletxt.Text = "";
                            imageEmp.Image = null;
                            remplirGenre();
                            remplirSpecialite();
                            MessageBox.Show("Ajouter avec Succès");
                        }
                    }
                    else
                    {
                        if (Nomtxt.Text == "")
                        {
                            errorProvider1.SetError(Nomtxt, "Nom est Obligatoire");
                        }
                        if (Pretxt.Text == "")
                        {
                            errorProvider1.SetError(Pretxt, "Prenom est Obligatoire");
                        }
                        if (cmbGenre.Text == "")
                        {
                            errorProvider1.SetError(cmbGenre, "Genre est Obligatoire");
                        }
                        if (teletxt.Text == "")
                        {
                            errorProvider1.SetError(teletxt, "Telephone est Obligatoire");
                        }
                        if (dNaissance.Value.Date > DateTime.Now.Date)
                        {
                            errorProvider1.SetError(dNaissance, "Date de Naissance n'est pas Valide");
                        }
                    }

                }
            }
            catch (FormatException ex)
            {
                errorProvider1.SetError(teletxt, "Telephone format n'est pas Valide");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ajtEmp.Enabled = true;
            Nomtxt.Text = "";
            Pretxt.Text = "";
            Mailtxt.Text = "";
            Mdptxt.Text = "";
            Specmb.SelectedIndex = -1;
            cmbGenre.SelectedIndex = -1;
            dNaissance.Value = new DateTime(2000,1,1);
            teletxt.Text = "";
            rbDoc.Enabled = true;
            rbDoc.Checked = true;
            rbSec.Enabled = true;
            rbSec.Checked = false;
            imageEmp.Image= null;


        }

        private void modEmp_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                String imgname = Nomtxt.Text + Pretxt.Text + now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\" + imgname);
                if (rbDoc.Checked)
                {
                    if (Nomtxt.Text != "" && Pretxt.Text != "" && Mailtxt.Text != "" && Mdptxt.Text != "" && Specmb.Text != "" && cmbGenre.Text != "" && dNaissance.Text != "" && teletxt.Text != "")
                    {
                        int tele = int.Parse(teletxt.Text);

                        if (con.modifierDocteur(ID, Nomtxt.Text, Pretxt.Text, Path.GetFileNameWithoutExtension(imgname), DateTime.Parse(dNaissance.Text), char.Parse(cmbGenre.Text), teletxt.Text, Mdptxt.Text, Specmb.Text))
                        {
                            Nomtxt.Text = Pretxt.Text = Mailtxt.Text = Mdptxt.Text = Specmb.Text = cmbGenre.Text = dNaissance.Text = teletxt.Text = "";
                            imageEmp.Image = null;
                            remplirGenre();
                            remplirSpecialite();
                            MessageBox.Show("Modifier avec Succès");
                        }
                    }
                    else
                    {
                        if (Nomtxt.Text == "")
                        {
                            errorProvider1.SetError(Nomtxt, "Nom est Obligatoire");
                        }
                        if (Pretxt.Text == "")
                        {
                            errorProvider1.SetError(Pretxt, "Prenom est Obligatoire");
                        }
                        if (cmbGenre.Text == "")
                        {
                            errorProvider1.SetError(cmbGenre, "Genre est Obligatoire");
                        }
                        if (teletxt.Text == "")
                        {
                            errorProvider1.SetError(teletxt, "Telephone est Obligatoire");
                        }
                        if (dNaissance.Value.Date > DateTime.Now.Date)
                        {
                            errorProvider1.SetError(dNaissance, "Date de Naissance n'est pas Valide");
                        }
                        if (Specmb.Text == "")
                        {
                            errorProvider1.SetError(Specmb, "Spécialité est Obligatoire");
                        }
                    }
                }
                else
                {
                    if (Nomtxt.Text != "" && Pretxt.Text != "" && Mailtxt.Text != "" && Mdptxt.Text != "" && cmbGenre.Text != "" && dNaissance.Text != "" && teletxt.Text != "")
                    {
                        int tele = int.Parse(teletxt.Text);

                        if (con.modifierSecretaire(ID, Nomtxt.Text, Pretxt.Text, Path.GetFileNameWithoutExtension(imgname), DateTime.Parse(dNaissance.Text), char.Parse(cmbGenre.Text), teletxt.Text, Mdptxt.Text))
                        {
                            Nomtxt.Text = Pretxt.Text = Mailtxt.Text = Mdptxt.Text = Specmb.Text = cmbGenre.Text = dNaissance.Text = teletxt.Text = "";
                            imageEmp.Image = null;
                            remplirGenre();
                            remplirSpecialite();
                            MessageBox.Show("Modifier avec Succès");
                        }
                    }
                    else
                    {
                        if (Nomtxt.Text == "")
                        {
                            errorProvider1.SetError(Nomtxt, "Nom est Obligatoire");
                        }
                        if (Pretxt.Text == "")
                        {
                            errorProvider1.SetError(Pretxt, "Prenom est Obligatoire");
                        }
                        if (cmbGenre.Text == "")
                        {
                            errorProvider1.SetError(cmbGenre, "Genre est Obligatoire");
                        }
                        if (teletxt.Text == "")
                        {
                            errorProvider1.SetError(teletxt, "Telephone est Obligatoire");
                        }
                        if (dNaissance.Value.Date > DateTime.Now.Date)
                        {
                            errorProvider1.SetError(dNaissance, "Date de Naissance n'est pas Valide");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actEmp_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                try
                {
                    con.activerEmploye(ID);
                    MessageBox.Show("Employe est Active");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("selectionner Employe");
            }
        }

        private void desEmp_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                try
                {
                    con.desactiverEmploye(ID);
                    MessageBox.Show("Employe est Desactive");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("selectionner Employe");
            }
        }
    }
}
