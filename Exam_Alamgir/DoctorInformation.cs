using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Exam_Alamgir
{
    
    class DoctorInformation
    {
       

        SqlConnection con = new SqlConnection("Data Source=(localdb)mssqllocaldb;Initial Catalog=CUREHOSPITAL_DB;Integrated Security=True");
        SqlCommand cmd;
        DataTable person_table;
        SqlDataAdapter adtr;
        public void command_process(string query)
        {
            con.Open();
            cmd =new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable list_process( string query)
        {
            con.Open();
            adtr = new SqlDataAdapter(query, con);
            person_table = new DataTable();
            adtr.Fill(person_table);
            con.Close();
            return person_table;
        }

    }
}
