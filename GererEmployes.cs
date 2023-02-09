using System;
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
    public partial class GererEmployes : Form
    {
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
                Spetxt.ReadOnly = false;
                Specmb.Enabled = true;
            }
            else if (rbSec.Checked)
            {
                mailext = "@secretaire.ma";
                Mailtxt.Text = Nomtxt.Text + Pretxt.Text + mailext;
                Spetxt.Text = "";
                Spetxt.ReadOnly = true;
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

        private void eclosed_Click(object sender, EventArgs e)
        {
            eopen.Visible = true;
            eclosed.Visible = false;
            Mdptxt.PasswordChar = '\0';
        }

        private void eopen_Click(object sender, EventArgs e)
        {
            eopen.Visible = false;
            eclosed.Visible = true;
            Mdptxt.PasswordChar = '*';
        }
    }
}
