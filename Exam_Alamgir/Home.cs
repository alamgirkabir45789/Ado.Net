using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Alamgir
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Doctor frmDoct = new Doctor();
            frmDoct.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientInformation frmpatient = new PatientInformation();
            frmpatient.Show();
        }
    }
}
