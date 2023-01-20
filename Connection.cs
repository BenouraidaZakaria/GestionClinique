using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace GestionClinique
{
    class Connection
    {
        SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlDataReader dr;

        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=DB_Clinique; integrated security=true";
                con.Open();
            }
        }

        public void deConnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public Boolean login(string TableName, string email, string motPasse)
        {
            Boolean etat = false;

            if (TableName.Equals("SECRETAIRE"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "select EMAIL from SECRETAIRE where EMAIL=@email and MOT_PASSE=@motPasse";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@motPasse", motPasse);
                if (cmd.ExecuteScalar() != null)
                    etat = true;
                deConnecter();
            }
            else if (TableName.Equals("DOCTEUR"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "select EMAIL from DOCTEUR where EMAIL=@email and MOT_PASSE=@motPasse";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@motPasse", motPasse);
                if (cmd.ExecuteScalar() != null)
                    etat = true;
                deConnecter();
            }

            return etat;
        }

        public void remplir(DataGridView dgv, string TableName)
        {
            DataTable dt = new DataTable();
            dt.Rows.Clear();

            if (TableName.Equals("SECRETAIRE"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM SECRETAIRE INNER JOIN GERER_SECRETAIRE ON SECRETAIRE.IDSECRETAIRE=GERER_SECRETAIRE.IDSECRETAIRE";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("DOCTEUR"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM DOCTEUR";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("CONSULTATION"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM CONSULTATION JOIN REALISER ON CONSULTATION.IDCONSULTATION=REALISER.IDCONSULTATION";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
        }


        // Secretaire
        public Boolean ajouterSecretaire(int idSecretaireSup, string nom, string prenom, string image, DateTime dateNaissance, char genre, string telephone)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select max(IDSECRETAIRE) from SECRETAIRE";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into SECRETAIRE(NOM,PRENOM,IMAGE,DATE_NAISSANCE,GENRE,TELEPHONE) " +
                                "values(@nom,@prenom,@image,@date,@genre,@telephone)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@date", dateNaissance);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            if (idSecretaireSup != 0)
            {
                cmd.CommandText = "select max(IDSECRETAIRE) from SECRETAIRE";
                int id2 = int.Parse(cmd.ExecuteScalar().ToString());
                if (id != id2)
                {
                    cmd.CommandText = "insert into GERER_SECRETAIRE(IDSECRETAIRE,SEC_IDSECRETAIRE) " +
                                    "values(@supSecretaire,@scretaire)";
                    cmd.Parameters.AddWithValue("@supSecretaire", idSecretaireSup);
                    cmd.Parameters.AddWithValue("@scretaire", id2);
                    cmd.ExecuteNonQuery();
                    etat = true;
                }
            }

            deConnecter();

            return etat;
        }
        public Boolean modifierSecretaire(int id, string nom, string prenom, string image, DateTime dateNaissance, char genre, string telephone, string motPasse)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "update SECRETAIRE set NOM=@nom, PRENOM=@prenom, IMAGE=@image, DATE_NAISSANCE=convert(date,@dateNaissance), " +
                              "GENRE=@genre, TELEPHONE=@telephone, MOT_PASSE=@motPasse where IDSECRETAIRE=@id";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@dateNaissance", dateNaissance);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@motPasse", motPasse);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            deConnecter();

            return true;
        }


        // docteur
        public Boolean ajouterDocteur(int idSecretaire, string nom, string prenom, string image, DateTime dateNaissance, char genre, string telephone, string specialiste)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select max(IDDOCTEUR) from DOCTEUR";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into DOCTEUR(NOM,PRENOM,IMAGE,DATE_NAISSANCE,GENRE,TELEPHONE,SPECIALITE) " +
                                "values(@nom,@prenom,@image,@date,@genre,@telephone,@specialite)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@date", dateNaissance);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@specialite", specialiste);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cmd.CommandText = "select max(IDDOCTEUR) from DOCTEUR";
            int id2 = int.Parse(cmd.ExecuteScalar().ToString());
            if (id != id2)
            {
                cmd.CommandText = "insert into GERER_DOCTEUR(IDSECRETAIRE,IDDOCTEUR) " +
                                "values(@secretaire,@docteur)";
                cmd.Parameters.AddWithValue("@secretaire", idSecretaire);
                cmd.Parameters.AddWithValue("@docteur", id2);
                cmd.ExecuteNonQuery();

                etat = true;
            }
            deConnecter();

            return etat;
        }
        public Boolean modifierDocteur(int id, string nom, string prenom, string image, DateTime dateNaissance, char genre, string telephone, string motPasse, string specialiste)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "update DOCTEUR set NOM=@nom, PRENOM=@prenom, IMAGE=@image, DATE_NAISSANCE=convert(date,@dateNaissance), " +
                              "GENRE=@genre, TELEPHONE=@telephone, MOT_PASSE=@motPasse, SPECIALITE=@specialiste where IDDOCTEUR=@id";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@dateNaissance", dateNaissance);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@motPasse", motPasse);
            cmd.Parameters.AddWithValue("@specialiste", motPasse);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            deConnecter();

            return true;
        }


        // consultation
        public Boolean ajouterConsultation(int idSecretaire, int idDocteur, int idPatient, DateTime date, string traitement, string prescription, string diagnostic)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select max(IDCONSULTATION) from CONSULTATION";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into CONSULTATION(DATE,TRAITEMENT,PRESCRIPTION,DIAGNOSTIC) " +
                                "values(@date,@trait,@presc,@diagno)";
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@trait", traitement);
            cmd.Parameters.AddWithValue("@presc", prescription);
            cmd.Parameters.AddWithValue("@diagno", diagnostic);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cmd.CommandText = "select max(IDCONSULTATION) from CONSULTATION";
            int id2 = int.Parse(cmd.ExecuteScalar().ToString());
            if (id != id2)
            {
                cmd.CommandText = "insert into REALISER(IDSECRETAIRE,IDDOCTEUR,IDCONSULTATION,IDPATIENT) " +
                                "values(@secretaire,@docteur,@consultation,@patient)";
                cmd.Parameters.AddWithValue("@secretaire", idSecretaire);
                cmd.Parameters.AddWithValue("@docteur", idDocteur);
                cmd.Parameters.AddWithValue("@consultation", id2);
                cmd.Parameters.AddWithValue("@patient", idPatient);
                cmd.ExecuteNonQuery();

                etat = true;
            }
            deConnecter();

            return etat;
        }
        public Boolean modifierConsultation(int id, DateTime date, string traitement, string prescription, string diagnostic)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "update CONSULTATION set DATE=@date, TRAITEMENT=@trait, PRESCRIPTION=@presc, " +
                "DIAGNOSTIC=@diagno where IDCONSULTATION=@id";
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@trait", traitement);
            cmd.Parameters.AddWithValue("@presc", prescription);
            cmd.Parameters.AddWithValue("@diagno", diagnostic);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            deConnecter();

            return true;
        }
        public Boolean supprimerConsultation(int id)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "delete CONSULTATION where IDCONSULTATION=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "select IDCONSULTATION from CONSULTATION where IDCONSULTATION=@id";
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteScalar().ToString() == null)
            {
                etat = true;
            }
            deConnecter();

            return etat;
        }


        // rendez-vous
        public Boolean ajouterRendezVous(int idSecretaire, int idDocteur, int idPatient, DateTime date)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "SELECT MAX(IDRDV) FROM RENDEZ_VOUS";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "INSERT INTO RENDEZ_VOUS(DATE) " +
                                "VALUES(@date)";
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT MAX(IDRDV) FROM RENDEZ_VOUS";
            int id2 = int.Parse(cmd.ExecuteScalar().ToString());
            if (id != id2)
            {
                cmd.CommandText = "INSERT INTO RESERVER(IDRDV,IDDOCTEUR,IDSECRETAIRE,IDPATIENT) " +
                                "VALUES(@idRendezVous,@idDocteur,@idSecretaire,@idPatient)";
                cmd.Parameters.AddWithValue("@idRendezVous", id2);
                cmd.Parameters.AddWithValue("@idDocteur", idDocteur);
                cmd.Parameters.AddWithValue("@idSecretaire", idSecretaire);
                cmd.Parameters.AddWithValue("@idPatient", idPatient);
                cmd.ExecuteNonQuery();

                etat = true;
            }
            deConnecter();

            return etat;

        }
        public Boolean ModifierRendezVous(int idRendezVous, int idSecretaire, int idDocteur, int idPatient, DateTime date)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE RENDEZ_VOUS set DATE=@date " +
                " where IDRDV=@id";
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@id", idRendezVous);
            cmd.ExecuteNonQuery();
            deConnecter();

            return true;
        }
        public Boolean supprimerRendezVous(int id)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "DELETE RENDEZ_VOUS WHERE IDRDV=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT IDRDV FROM RENDEZ_VOUS WHERE IDRDV=@id";
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteScalar().ToString() == null)
            {
                etat = true;
            }
            deConnecter();

            return etat;
        }

    }
}
