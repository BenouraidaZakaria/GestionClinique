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
    public partial class AcceuilDoctors : Form
    {
        Connection con = new Connection();

        public AcceuilDoctors()
        {
            InitializeComponent();
            con.remplir(PatientsGrid, "PATIENT");
            con.remplir(ConsultationGrid, "CONSULTATION");
            ConsultationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AcceuilDoctors_Load(object sender, EventArgs e)
        {

        }
    }
}
