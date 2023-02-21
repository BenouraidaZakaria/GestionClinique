using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClinique
{
    public partial class GererEmployes : Form
    {
        Connection con = new Connection();
        String mailext="@docteur.ma";
        public GererEmployes()
        {
            InitializeComponent();
        }

        private void rbDoc_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDoc.Checked)
            {
                mailext = "@docteur.ma";
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Specmb.Enabled = true;
            }
            else if (rbSec.Checked)
            {
                mailext = "@secretaire.ma";
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Specmb.SelectedIndex = -1;
                Specmb.Enabled = false;
                
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

        

        private void GererEmployes_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
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

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (rbDoc.Checked)
            {
                if (Nomtxt.Text != "" && Pretxt.Text != "" && Mdptxt.Text != "" && Specmb.Text != "" && cmbGenre.Text != "" && teletxt.Text != "")
                {
                    con.ajouterEmploye(Nomtxt.Text, Pretxt.Text, null, Convert.ToDateTime(dNaissance.Text), char.Parse(cmbGenre.Text), teletxt.Text, "docteur", Mailtxt.Text, Mdptxt.Text, Specmb.Text);
                }
            }
            else
            {
                if (Nomtxt.Text != "" && Pretxt.Text != "" && Mdptxt.Text != "" && cmbGenre.Text != "" && teletxt.Text != "")
                {
                    con.ajouterEmploye(Nomtxt.Text, Pretxt.Text, null, Convert.ToDateTime(dNaissance.Text), char.Parse(cmbGenre.Text), teletxt.Text, "secretaire", Mailtxt.Text, Mdptxt.Text, null);
                }
            }
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
            form.Text = "Liste d'Employés";

            // Create a new instance of the Label
            Label label = new Label();
            label.Text = "Sélectionnez un employé";
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
            con.remplir(dgv, "EMPLOYEE");
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
    }
}
