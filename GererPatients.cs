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
            try
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && cmbSexe.Text != "" && txtTelephone.Text != "" && datpickNaissance.Value.Date <= DateTime.Now.Date)
                {
                    DateTime now = DateTime.Now;
                    String imgname = txtNom.Text + txtPrenom.Text + now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                    File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\PROFILE\" + imgname + ".jpg");
                    //String allergies = "";
                    //for (int i = 0; i < lisAll.Items.Count; i++)
                    //{
                    //    lisAll.Items[0].ToString().
                    //    allergies += lisAll.Items[i].ToString();
                    //}
                    con.ajouterPatient(txtNom.Text, txtPrenom.Text, DateTime.Parse(datpickNaissance.Text), char.Parse(cmbSexe.Text), txtEmail.Text, txtTelephone.Text, txtAdresse.Text, cmbassur.Text, Path.GetFileName(imagePatient.ImageLocation), lisAll.Text);
                    txtNom.Text = txtPrenom.Text = cmbSexe.Text = txtTelephone.Text = datpickNaissance.Text = txtEmail.Text = txtAdresse.Text = cmbassur.Text = "";
                    lisAll.Items.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      
        private void select_Click(object sender, EventArgs e)
        {
            AfficherPatients f = new AfficherPatients();
            //f.SetInvisibilityAndTriggerEvent(); // Call the method to set invisibility and trigger event
            f.flowLayoutPanel1.Visible = false;
            f.Show();
            //f.SetInvisibilityAndTriggerEvent();
            //this.Hide();
            //// Create a new form to contain the DataGridView, label, and buttons
            //Form form = new Form();
            //form.ClientSize = new Size(1000, 630);
            //form.StartPosition = FormStartPosition.CenterScreen;
            //form.Text = "Liste Patients";

            //// Create a new instance of the Label
            //Label label = new Label();
            //label.Text = "Sélectionnez un patient";
            //label.Location = new Point(25, 25);
            //label.Size = new Size(200, 25);
            //// Add the Label to the form
            //form.Controls.Add(label);

            //// Create a new instance of the DataGridView
            //DataGridView dgv = new DataGridView();
            //// Set the properties of the DataGridView
            //dgv.Size = new Size(950, 500);
            //dgv.Location = new Point(25, 50);
            //dgv.AllowUserToAddRows = false;
            //// Add the DataGridView to the form
            //form.Controls.Add(dgv);
            //con.remplir(dgv, "PATIENT");
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //// Create a new instance of the OK button
            //Button okButton = new Button();
            //okButton.Text = "OK";
            //okButton.DialogResult = DialogResult.OK;
            //okButton.Location = new Point(450, 570);
            //// Add the OK button to the form
            //form.Controls.Add(okButton);

            //// Create a new instance of the Cancel button
            //Button cancelButton = new Button();
            //cancelButton.Text = "Cancel";
            //cancelButton.DialogResult = DialogResult.Cancel;
            //cancelButton.Location = new Point(550, 570);
            //// Add the Cancel button to the form
            //form.Controls.Add(cancelButton);

            //// Show the form as a modal dialog
            //DialogResult result = form.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    // Code to handle the OK button click
            //    int selectedId = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            //}
            //else if (result == DialogResult.Cancel)
            //{
            //    // Code to handle the Cancel button click
            //    form.Close();
            //}
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

        private void addall_Click(object sender, EventArgs e)
        {
            lisAll.Items.Add(cmbAll.SelectedItem.ToString());
        }

        private void rmvtall_Click(object sender, EventArgs e)
        {
            if(lisAll.Items.Count > 0) { 
                lisAll.Items.RemoveAt(lisAll.SelectedIndex);
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

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text != "" && txtPrenom.Text != "" && cmbSexe.Text != "" && txtTelephone.Text != "" && datpickNaissance.Value.Date <= DateTime.Now.Date)
                {
                    DateTime now = DateTime.Now;
                    String imgname = txtNom.Text + txtPrenom.Text + now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                    File.Copy(imageText.Text, Application.StartupPath + @"\IMAGES\PROFILE\" + imgname + ".jpg");
                    con.modifierPatient(ID,txtNom.Text, txtPrenom.Text, DateTime.Parse(datpickNaissance.Text), char.Parse(cmbSexe.Text), txtEmail.Text, txtTelephone.Text, txtAdresse.Text, cmbassur.Text, Path.GetFileName(imagePatient.ImageLocation), lisAll.Text);
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
