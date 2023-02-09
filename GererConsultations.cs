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
    public partial class GererConsultations : Form
    {
        public GererConsultations()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "90:00";
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

        private void button4_Click(object sender, EventArgs e)
        {
            File.Copy(imagePrescText.Text, Application.StartupPath + @"\IMAGES\PRESCRIPTION\" + Path.GetFileName(imagePrescription.ImageLocation));

        }
    }
}
