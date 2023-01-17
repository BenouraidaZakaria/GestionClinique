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
                cmd.CommandText = "select * from SECRETAIRE";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("DOCTEUR"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "select * from DOCTEUR";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
            else if (TableName.Equals("CONSULTATION"))
            {
                connecter();
                cmd.Connection = con;
                cmd.CommandText = "select * from CONSULTATION";
                da.SelectCommand = cmd;
                da.Fill(dt);
                deConnecter();
                dgv.DataSource = dt;
            }
        }

        public Boolean ajouterSecretaire(string nom, string prenom, string image, DateTime dateNaissance, char genre, string telephone)
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

            cmd.CommandText = "select max(IDSECRETAIRE) from SECRETAIRE";
            if (id != int.Parse(cmd.ExecuteScalar().ToString()))
                etat = true;

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

        public Boolean supprimerSecretaire(int id)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "delete SECRETAIRE where IDSECRETAIRE=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.CommandText = "select IDSECRETAIRE from SECRETAIRE where IDSECRETAIRE=@id";
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
