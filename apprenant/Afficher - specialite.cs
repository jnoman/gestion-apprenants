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
    public partial class Afficher___specialite : Form
    {
        public Afficher___specialite()
        {
            InitializeComponent();
        }

        private void Afficher___specialite_Load(object sender, EventArgs e)
        {
            combo_specialité.Items.AddRange(new string[] { "jee", "C#", "back-end font-end" });
        }

        private void combo_specialité_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection cnx = new Connection();
            cnx.open_connection();
            SqlCommand cmd = new SqlCommand("select * from studentinfo where CONVERT(VARCHAR, specialite)='" + combo_specialité.Text+"'", Connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cnx.close_connection();
            label_nombre.Text = "nombre d'apprenant est: "+dataGridView1.RowCount.ToString();
        }
    }
}
