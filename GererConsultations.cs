﻿using System;
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

namespace GestionClinique
{
    public partial class GererConsultations : Form
    {
        Connection con = new Connection();

        public GererConsultations()
        {
            InitializeComponent();
        }
        private void imagePrescription_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    imagePrescText.Text = dialog.FileName;
                imageLocation = dialog.FileName;
                imagePrescription.ImageLocation = imageLocation;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GererConsultations_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        private void adddiag_Click(object sender, EventArgs e)
        {
            listdiag.Items.Add(txtdiag.Text);
            txtdiag.Text="";
        }
        private void rmvdiag_Click(object sender, EventArgs e)
        {
            if (listdiag.Items.Count > 0)
            {
                listdiag.Items.RemoveAt(listdiag.SelectedIndex);
            }
        }
        private void addtrai_Click(object sender, EventArgs e)
        {
            listtrai.Items.Add(txttrai.Text);
            txttrai.Text = "";
        }
        private void rmvtrai_Click(object sender, EventArgs e)
        {
            if (listtrai.Items.Count > 0)
            {
                listtrai.Items.RemoveAt(listtrai.SelectedIndex);
            }
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String imgname = now.ToString("yyyyMMddHHmmssfff") + ".jpg";
            File.Copy(imagePrescText.Text, Application.StartupPath + @"\IMAGES\PRESCRIPTION\" + imgname);
        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

        }

        private void createDGV(string table)
        {
            // Create a new form to contain the DataGridView, label, and buttons
            Form form = new Form();
            form.ClientSize = new Size(1000, 630);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Text = table;

            // Create a new instance of the Label
            Label label = new Label();
            label.Text = "Sélectionnez "+ table.ToLower();
            label.Location = new Point(25, 25);
            label.Size = new Size(200, 25);
            // Add the Label to the form
            form.Controls.Add(label);

            // Create a new instance of the DataGridView
            DataGridView dgv = new DataGridView();
            // Set the properties of the DataGridView
            dgv.Size = new Size(950, 500);
            dgv.Location = new Point(25, 50);
            dgv.AllowUserToAddRows = false;
            // Add the DataGridView to the form
            form.Controls.Add(dgv);
            con.remplir(dgv, table);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Create a new instance of the OK button
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(450, 570);
            // Add the OK button to the form
            form.Controls.Add(okButton);

            // Create a new instance of the Cancel button
            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(550, 570);
            // Add the Cancel button to the form
            form.Controls.Add(cancelButton);

            // Show the form as a modal dialog
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Code to handle the OK button click
                int selectedId = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            }
            else if (result == DialogResult.Cancel)
            {
                // Code to handle the Cancel button click
                form.Close();
            }
        }
        private void select_Click(object sender, EventArgs e)
        {

            createDGV("CONSULTATION");

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

        private void slctDoc_Click(object sender, EventArgs e)
        {
            createDGV("DOCTEUR");
        }

        private void slctPat_Click(object sender, EventArgs e)
        {
            createDGV("PATIENT");
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
