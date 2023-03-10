using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    public partial class AfficherConsultation : Form
    {
        public int ID;
        public string prescription;
        public string Prescription
        {
            get { return prescription; }
            set { prescription = value; }
        }
        public string Npat
        {
            get { return nPat.Text; }
            set { nPat.Text = value; }
        }
        public string Ppat
        {
            get { return pPat.Text; }
            set { pPat.Text = value; }
        }

       
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
        //add presImg getter and setter ?
        
       
        public AfficherConsultation()
        {
            InitializeComponent();
        }
        private void AfficherConsultation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //MessageBox.Show(Prescription);
            //string imagePath = Path.Combine(Application.StartupPath, "IMAGES", Prescription + ".jpg");
            //prescImg.Image = Image.FromFile(imagePath);
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    // Assuming the image you want to display is set as the PictureBox's Image property
        //    Image image = prescImg.Image;

        //    // Create a new instance of the PictureBox form to display the image
        //    Form pictureForm = new Form();
        //    pictureForm.StartPosition = FormStartPosition.CenterScreen;
        //    pictureForm.Text = "Picture";
        //    pictureForm.ClientSize = new Size(image.Width, image.Height);

        //    // Create a new instance of the PictureBox to display the image
        //    PictureBox picture = new PictureBox();
        //    picture.Image = image;
        //    picture.Dock = DockStyle.Fill;
        //    picture.SizeMode = PictureBoxSizeMode.Zoom;

        //    // Add the PictureBox to the form
        //    pictureForm.Controls.Add(picture);

        //    // Show the form as a modal dialog
        //    pictureForm.ShowDialog();
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void prescImg_Click(object sender, EventArgs e)
        {
            // Create an instance of the form to display the larger image
            Form largerImageForm = new Form();

            // Set the form's properties
            largerImageForm.Text = "Larger Image";
            largerImageForm.ClientSize = new Size(800, 600); // Set the form's size
            largerImageForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            largerImageForm.MaximizeBox = false;

            // Create a PictureBox control to display the larger image
            PictureBox largerPictureBox = new PictureBox();
            largerPictureBox.Image = prescImg.Image; // Set the image to display
            largerPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the size mode to zoom
            largerPictureBox.Dock = DockStyle.Fill; // Fill the entire form with the picture box
            largerPictureBox.BorderStyle = BorderStyle.FixedSingle; // Add a border to the picture box

            // Add the PictureBox to the form
            largerImageForm.Controls.Add(largerPictureBox);

            // Show the form
            largerImageForm.ShowDialog();
        }
    }
     
}
