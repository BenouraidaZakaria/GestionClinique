using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


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
                //con.ConnectionString = " Data Source = .; Initial Catalog = DB_Clinique; Integrated Security = True";
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

                cmd.Parameters.Clear();
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
                cmd.Parameters.Clear();
                deConnecter();
            }
            else if (TableName.Equals("EMPLOYEE"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "select IDEMPLOYEE,NOM,PRENOM,[TYPE],EMAIL from EMPLOYEE where EMAIL=@email and MOT_PASSE=@motPasse";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@motPasse", motPasse);
                if (cmd.ExecuteScalar() != null)
                {
                    etat = true;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Program.iduser = dr.GetInt32(0);
                        Program.nameuser = dr.GetString(1);
                        Program.prenomuser = dr.GetString(2);
                        Program.typeuser = dr.GetString(3);
                    }
                }

                cmd.Parameters.Clear();
                deConnecter();
            }
                return etat;
        }

        public void remplir(DataGridView dgv, string TableName)
        {
            DataTable dt = new DataTable();
            dt.Rows.Clear();

            if (TableName.Equals("EMPLOYEE"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT IDEMPLOYEE as 'ID', NOM as 'Nom', PRENOM as 'Prenom', DATE_NAISSANCE as 'Date de Naissance', GENRE as 'Genre', TELEPHONE as 'Telephone', TYPE as 'Type', EMAIL as 'Emial' FROM EMPLOYEE";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("PATIENT"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT IDPATIENT as 'ID', NOM as 'Nom', PRENOM as 'Prenom', DATENAISSANCE as 'Date de Naissance', GENRE as 'Genre', EMAIL as 'Email', TELEPHONE as 'Telephone', ADRESSE as 'Adresse' FROM PATIENT";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("CONSULTATION"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT con.IDCONSULTATION as 'ID', DATE as 'Date', IDDOCTEUR as 'ID Docteur', IDPATIENT as 'ID Patient', TRAITEMENT as 'Traitement', PRESCRIPTION as 'Prescription', DIAGNOSTIC as 'Diagnostic' FROM CONSULTATION con inner join REALISER rea on con.IDCONSULTATION=rea.IDCONSULTATION";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("DOCTEUR"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT IDDOCTEUR as 'ID',NOM as 'NOM',PRENOM as 'PRENOM',SPECIALITE as 'SPECIALITE' FROM DOCTEUR ";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
        }
        public Boolean remplir(DataGridView dgv, string TableName,int id)
        {
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            Boolean etat = false;

            if (TableName.Equals("PATIENT"))
            {
                //connecter();
                //cmd.Connection = con;
                //cmd.CommandText = "SELECT PATIENT.* FROM PATIENT INNER JOIN REALISER ON PATIENT.IDPATIENT = REALISER.IDPATIENT WHERE REALISER.IDDOCTEUR=@id";
                //cmd.Parameters.AddWithValue("@id", id);
                //if (cmd.ExecuteScalar() != null)
                //    etat = true;
                //cmd.Parameters.Clear();
                //deConnecter();

                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT PATIENT.* FROM PATIENT INNER JOIN REALISER ON PATIENT.IDPATIENT = REALISER.IDPATIENT WHERE REALISER.IDDOCTEUR=@id";
                cmd.Parameters.AddWithValue("@id", id); 
                da.SelectCommand = cmd;
                da.Fill(dt);
                etat = true;
                cmd.Parameters.Clear();
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("CONSULTATION"))
            {
                //connecter();
                //cmd.Connection = con;
                //cmd.CommandText = "SELECT DATE as 'Date', IDDOCTEUR as 'ID Docteur', IDPATIENT as 'ID Patient', TRAITEMENT as 'Traitement', PRESCRIPTION as 'Prescription', DIAGNOSTIC as 'Diagnostic' FROM CONSULTATION con inner join REALISER rea on con.IDCONSULTATION=rea.IDCONSULTATION where rea.IDDOCTEUR =@iddoc";
                //cmd.Parameters.AddWithValue("@iddoc", id);
                //if (cmd.ExecuteScalar() != null)
                //    etat = true;
                //cmd.Parameters.Clear();
                //deConnecter();

                connecter();
                cmd.Connection = con;
                cmd.CommandText = "SELECT DATE as 'Date',TRIM(Nom) as 'Nom Patient',TRIM(PRENOM) as 'Prenom Patient', TRAITEMENT as 'Traitement', PRESCRIPTION as 'Prescription', DIAGNOSTIC as 'Diagnostic' FROM CONSULTATION con " +
                    "inner join REALISER rea on con.IDCONSULTATION=rea.IDCONSULTATION " +
                    "inner join PATIENT pa on pa.IDPATIENT=rea.IDPATIENT " +
                    "where rea.IDDOCTEUR =@id";
                cmd.Parameters.AddWithValue("@id", id);
                da.SelectCommand = cmd;
                da.Fill(dt);
                etat = true;
                cmd.Parameters.Clear();
                deConnecter();
                dgv.DataSource = dt;
            }
                return etat;
        }

        // Secretaire
        // changer ajouterEmployee a la place de methode secretaire et docteur
        public Boolean ajouterEmploye(/*int idSecretaireSup,*/ string nom, string prenom, string image, DateTime dateNaissance, char genre, string telephone, string type, string email, string motPasse, string specialite)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select max(IDEMPLOYEE) from EMPLOYEE";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into EMPLOYEE(NOM,PRENOM,IMAGE,DATE_NAISSANCE,GENRE,TELEPHONE,TYPE],EMAIL,MOT_PASSE) " +
                                "values(@nom,@prenom,@image,@date,@genre,@telephone,@type,@email,@motPasse)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Parameters.AddWithValue("@date", dateNaissance);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@motPasse", motPasse);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cmd.CommandText = "select max(IDEMPLOYEE) from EMPLOYEE";
            int id2 = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            if (id != id2)
            {
                if (type == "docteur")
                {
                    cmd.CommandText = "insert into DOCTEUR(IDDOCTEUR,NOM,PRENOM,SPECIALITE,IMAGE,DATE_NAISSANCE,GENRE,TELEPHONE,EMAIL,MOT_PASSE) " +
                                    "values(@id,@nom,@prenom,@specialite,@image,@date,@genre,@telephone,@email,@motPasse)";

                    cmd.Parameters.AddWithValue("@id", id2);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@specialite", specialite);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@date", dateNaissance);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@telephone", telephone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@motPasse", motPasse);
                    cmd.ExecuteNonQuery();
                }
            }

            deConnecter();

            return etat;
        }
        public DataTable infoEmployee(int id)
        {
            DataTable dt = new DataTable();

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select * from EMPLOYEE where IDEMPLOYEE=@id";
            cmd.Parameters.AddWithValue ("id", id);
            da.SelectCommand = cmd;
            da.Fill(dt);
            deConnecter();

            return dt;
        }

        // add methode for modifier les information d'employee
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

            cmd.Parameters.Clear();

            cmd.CommandText = "update EMPLOYEE set NOM=@nom, PRENOM=@prenom, IMAGE=@image, DATE_NAISSANCE=convert(date,@dateNaissance), " +
                              "GENRE=@genre, TELEPHONE=@telephone, MOT_PASSE=@motPasse where IDEMPLOYEE=@id";
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
        // add methode for modifier les infos d'employee
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
            cmd.Parameters.AddWithValue("@specialiste", specialiste);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cmd.CommandText = "update EMPLOYEE set NOM=@nom, PRENOM=@prenom, IMAGE=@image, DATE_NAISSANCE=convert(date,@dateNaissance), " +
                              "GENRE=@genre, TELEPHONE=@telephone, MOT_PASSE=@motPasse where IDEMPLOYEE=@id";
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


        // patient
        public Boolean ajouterPatient(string nom, string prenom, DateTime dateNaissance, char sexe, string email, string tele, string adresse, string assurance, string image)
        {
            Boolean etat = false;
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select max(IDPATIENT) from Patient";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into Patient(NOM,PRENOM,DATENAISSANCE,SEXE,EMAIL,TELEPHONE,ADRESSE,IMAGE) values(@nom,@prenom,@da,@s,@email,@tele,@adresse,@assurance,@img)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@da", dateNaissance);
            cmd.Parameters.AddWithValue("@s", sexe);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tele", tele);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@assurance", assurance);
            cmd.Parameters.AddWithValue("@img", image);

            cmd.Parameters.Clear();

            cmd.CommandText = "select max(IDPATIENT) from Patient";
            int id2 = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            if (id != id2)
            {
                etat = true;
            }
            deConnecter();
            return etat;
        }
        public Boolean modifierPatient(int id, string nom, string prenom, DateTime dateNaissance, char sexe, string email, string tele, string adresse, string assurance, string image)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "update Patient set NOM=@nom,PRENOM=@prenom,DATENAISSANCE=@da,SEXE=@s,EMAIL=@email,TELEPHONE=@tele,ADRESSE=@adresse,IMAGE=@img where idPatient=@id)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@da", dateNaissance);
            cmd.Parameters.AddWithValue("@s", sexe);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tele", tele);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@img", image);
            cmd.Parameters.AddWithValue("@id", id);

            return true;
        }
        public Boolean supprimerPatient(int id)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "delete Patient where idPatient=@id)";
            cmd.Parameters.AddWithValue("@id", id);

            return true;
        }

    }
}