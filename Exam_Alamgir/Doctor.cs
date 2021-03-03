using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Exam_Alamgir
{
    public partial class Doctor : Form
    {
        DoctorInformation doctinfo = new DoctorInformation();
        public Doctor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            string sql = "Select * From DoctorInformation";
            dgViewDoctor.DataSource = doctinfo.list_process(sql);
        }
    }
}
