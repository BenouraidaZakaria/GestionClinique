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
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select EMAIL from @table where EMAIL=@email and MOT_PASSE=@motPasse";
            cmd.Parameters.AddWithValue("@table", TableName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@motPasse", motPasse);
            if (cmd.ExecuteScalar() != null)
                etat = true;
            deConnecter();

            return etat;
        }

        public void remplir(DataGridView dgv, string TableName)
        {
            DataTable dt = new DataTable();

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select * from @table";
            cmd.Parameters.AddWithValue("@table", TableName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            deConnecter();

            dgv.DataSource = dt;
        }

        public Boolean ajouterSecretaire(string nom, string prenom)
        {
            Boolean etat = false;

            connecter();
            cmd.Connection = con;
            cmd.CommandText = "select max(IDSECRETAIRE) from SECRETAIRE";
            int id = int.Parse(cmd.ExecuteScalar().ToString());

            cmd.Parameters.Clear();

            cmd.CommandText = "insert into SECRETAIRE(NOM,PRENOM) values(@nom,@prenom)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cmd.CommandText = "select max(IDSECRETAIRE) from SECRETAIRE";
            if (id != int.Parse(cmd.ExecuteScalar().ToString()))
                etat = true;

            deConnecter();

            return etat;
        }

        public Boolean modifierSecretaire(int id, string nom, string prenom)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "update SECRETAIRE set nom=@nom, prenom=@prenom where IDSECRETAIRE=@id";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            deConnecter();

            return true;
        }

    }
}
