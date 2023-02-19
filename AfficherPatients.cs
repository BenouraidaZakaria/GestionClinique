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
    public partial class AfficherPatients : Form
    {
     

        public AfficherPatients()
        {
            InitializeComponent();
        }

        private void AfficherPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CliniqueDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dB_CliniqueDataSet.Patients);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }


     
    }
}
