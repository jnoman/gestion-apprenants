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

namespace apprenant
{
    public partial class Afficher : Form
    {
        public Afficher()
        {
            InitializeComponent();
        }

        private void Afficher_Load(object sender, EventArgs e)
        {
            Connection cnx = new Connection();
            cnx.open_connection();
            SqlCommand cmd = new SqlCommand("select * from studentinfo", Connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cnx.close_connection();
        }
    }
}
