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
    public partial class login : Form
    {
        // instancer une objet de la class Connection
        Connection con = new Connection();

        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    // ouverture la connection
                    con.connecter();

                    // veriver si l'email de secretaire ou de docteur
                    if (txtEmail.Text.Contains("@admin.ma"))
                    {
                        // si l'email contient '@admin.ma' on va cherecher dans la table secretaire
                        if (con.login("SECRETAIRE", txtEmail.Text.ToString(), txtPassword.Text.ToString()))
                        {
                            // si secretaire connecter avec les donnees correcte on va ouvrir la boite accueil
                            AccueilSecretaire f = new AccueilSecretaire();
                            f.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("l'email ou le Mot de Passe sont incorrecte");
                    }
                    else if (txtEmail.Text.Contains("@docteur.ma"))
                    {
                        // si l'email contient '@docteur.ma' on va cherecher dans la table docteur
                        if (con.login("DOCTEUR", txtEmail.Text.ToString(), txtPassword.Text.ToString()))
                        {
                            // si docteur connecter avec les donnees correcte on va eregistrer son email
                            AccueilSecretaire f = new AccueilSecretaire();
                            f.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("l'email ou le Mot de Passe sont incorrecte");
                    }
                    else
                        errorProvider1.SetError(txtEmail, "l'email est incorrecte");

                    // fermeture la connection
                    con.deConnecter();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtEmail.Text == "")
                    errorProvider1.SetError(txtEmail, "l'email est Obligatoite");
                if (txtPassword.Text == "")
                    errorProvider1.SetError(txtPassword, "Mot de Passe est Obligatoite");
            }
        }
    }
}
