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
    public partial class AfficherConsultation : Form
    {
        public int ID;
        public string DateConsultation
        {
            get { return datecon.Text; }
            set { datecon.Text = value; }
        }
       
        public string Traitement
        {
            get { return listtrai.Text; }
            set { listtrai.Items.Add(value); }
        }
        public string Diagnostic
        {
            get { return listdiag.Text; }
            set { listdiag.Items.Add(value);
            }
        }
        public AfficherConsultation()
        {
            InitializeComponent();
        }
        private void AfficherConsultation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Assuming the image you want to display is set as the PictureBox's Image property
            Image image = pictureBox1.Image;

            // Create a new instance of the PictureBox form to display the image
            Form pictureForm = new Form();
            pictureForm.StartPosition = FormStartPosition.CenterScreen;
            pictureForm.Text = "Picture";
            pictureForm.ClientSize = new Size(image.Width, image.Height);

            // Create a new instance of the PictureBox to display the image
            PictureBox picture = new PictureBox();
            picture.Image = image;
            picture.Dock = DockStyle.Fill;
            picture.SizeMode = PictureBoxSizeMode.Zoom;

            // Add the PictureBox to the form
            pictureForm.Controls.Add(picture);

            // Show the form as a modal dialog
            pictureForm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
     
}
