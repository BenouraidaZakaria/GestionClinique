﻿using System;
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
    public partial class DossierMedicalPatient : Form
    {
        Connection con = new Connection();
        public int ID;
       
        public string Nom
        {
            get { return txtnom.Text; }
            set { txtnom.Text = value; }
        }
        public string Prenom
        {
            get { return txtprenom.Text; }
            set { txtprenom.Text = value; }
        }
        public string Sexe
        {
            get { return txtgenre.Text; }
            set { txtgenre.Text = value; }
        }
        public string DateNaissance
        {
            get { return txtdate.Text; }
            set { txtdate.Text = value; }
        }
        public string Adresse
        {
            get { return txtadd.Text; }
            set { txtadd.Text = value; }
        }
        public string Telephone
        {
            get { return txttel.Text; }
            set { txttel.Text = value; }
        }
        public string Email
        {
            get { return txtmail.Text; }
            set { txtmail.Text = value; }
        }
        public string Assurance
        {
            get { return txtassu.Text; }
            set { txtassu.Text = value; }
        }
        //public Image MyImage
        //{
        //    get { return imgPatient.Image; }
        //    set { imgPatient.Image = value; }
        //}
        public DossierMedicalPatient()
        {
            InitializeComponent();
        }
        private void DossierMedicalPatient_Load(object sender, EventArgs e)
        {
            //panel2.Visible=false;
            
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            con.remplir(congrid, "CONSULTATION", Program.iduser, ID);
            congrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        FormC f = new FormC();

        static Boolean etatBtnPatient = true;
        static Boolean etatBtnEmployes = true;
        static Boolean etatBtnConsultation = true;
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            if (Program.typeuser == "docteur")
            {
                f.formInstance("AcceuilDoctors");
                this.Hide();
            }
            else if (Program.typeuser == "secretaire")
            {
                f.formInstance("AccueilSecretaire");
                this.Hide();
            }
        }

        //private void btnPatients_Click(object sender, EventArgs e)
        //{
        //    if (Program.typeuser == "docteur")
        //    {
        //        if (etatBtnPatient)
        //        {
        //            panel1.Height += 36;
        //            etatBtnPatient = false;
        //        }
        //        else
        //        {
        //            panel1.Height -= 36;
        //            etatBtnPatient = true;
        //        }
        //    }
        //    else if (Program.typeuser == "secretaire")
        //    {
        //        if (etatBtnPatient)
        //        {
        //            panel1.Height += 72;
        //            etatBtnPatient = false;
        //        }
        //        else
        //        {
        //            panel1.Height -= 72;
        //            etatBtnPatient = true;
        //        }
        //    }
        //}

        private void btnAffPat_Click(object sender, EventArgs e)
        {
            f.formInstance("AfficherPatients");
            this.Hide();
        }

        private void btnGerPat_Click(object sender, EventArgs e)
        {  f.formInstance("GererPatients");
            this.Hide();
        }

        //private void btnEmployes_Click(object sender, EventArgs e)
        //{
        //    if (etatBtnEmployes)
        //    {
        //        panel2.Height += 72;
        //        etatBtnEmployes = false;
        //    }
        //    else
        //    {
        //        panel2.Height -= 72;
        //        etatBtnEmployes = true;
        //    }
        //}

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

        //private void btnConsultation_Click(object sender, EventArgs e)
        //{
        //    if (Program.typeuser == "docteur")
        //    {
        //        if (etatBtnConsultation)
        //        {
        //            panel3.Height += 36;
        //            etatBtnPatient = false;
        //        }
        //        else
        //        {
        //            panel3.Height -= 36;
        //            etatBtnPatient = true;
        //        }
        //    }
        //    else if (Program.typeuser == "secretaire")
        //    {
        //        if (etatBtnConsultation)
        //        {
        //            panel3.Height += 72;
        //            etatBtnPatient = false;
        //        }
        //        else
        //        {
        //            panel3.Height -= 72;
        //            etatBtnPatient = true;
        //        }
        //    }
        //}

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

        private void congrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = congrid.Rows[e.RowIndex];
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

                //otherForm.PRESCRIPTION = selectedRow.Cells["PRESCRIPTION"].Value.ToString();

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
    }
    }
