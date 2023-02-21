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
        }

        private void AcceuilDoctors_Load(object sender, EventArgs e)
        {
            con.remplir(PatientsGrid, "PATIENT");
            PatientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con.remplir(ConsultationGrid, "CONSULTATION");
            ConsultationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
