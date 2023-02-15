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
        }
        private void rmvdiag_Click(object sender, EventArgs e)
        {
            listdiag.Items.RemoveAt(listdiag.SelectedIndex);
        }
        private void addtrai_Click(object sender, EventArgs e)
        {
            listtrai.Items.Add(txttrai.Text);
        }
        private void rmvtrai_Click(object sender, EventArgs e)
        {
            listtrai.Items.RemoveAt(listtrai.SelectedIndex);
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            File.Copy(imagePrescText.Text, Application.StartupPath + @"\IMAGES\PRESCRIPTION\" + Path.GetFileName(imagePrescription.ImageLocation));
        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {

            // Create a new form to contain the DataGridView, label, and buttons
            Form form = new Form();
            form.ClientSize = new Size(1000, 630);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Text = "Liste de consultations";

            // Create a new instance of the Label
            Label label = new Label();
            label.Text = "Sélectionnez une consultation";
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
    }
}
