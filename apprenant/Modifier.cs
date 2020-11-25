using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace apprenant
{
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }
        string[,] PaysVille = new string[,] { { "Maroc", "Casablanca" }, { "Maroc", "Marrakech" },{ "Maroc", "Tanger" },{ "Maroc", "Safi" },
                                             { "France", "Paris" },{ "France", "Marseille" },{ "France", "Lyon" },{ "France", "Toulouse" },
                                             { "Allemagne", "Berlin" },{ "Allemagne", "Hambourg" },{ "Allemagne", "Munich" },{ "Allemagne", "Cologne" }};
        private void Modifier_Load(object sender, EventArgs e)
        {
            combo_ville.Enabled = false;
            combo_specialite.Items.AddRange(new string[] { "jee", "C#", "back-end font-end" });
            for (int i = 0; i < PaysVille.GetLength(0); i++)
            {
                var trouve = 0;
                foreach (var item in combo_pays.Items)
                {
                    if (item.ToString().Equals(PaysVille[i, 0]))
                    {
                        trouve = 1;
                    }
                }
                if (trouve == 0)
                {
                    combo_pays.Items.Add(PaysVille[i, 0]);
                }
            }
            remplire_combo_id();
            disaple_input();
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            valid_nom();
        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {
            valid_prenom();
        }

        private void txt_tele_TextChanged(object sender, EventArgs e)
        {
            valid_tele();
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            valid_mail();
        }

        private void txt_addrese_TextChanged(object sender, EventArgs e)
        {
            valid_addrese();
        }

        private void combo_pays_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_ville.Items.Clear();
            combo_ville.Text = "";
            combo_ville.Enabled = true;
            for (int i = 0; i < PaysVille.GetLength(0); i++)
            {
                if (combo_pays.SelectedItem.ToString().Equals(PaysVille[i, 0]))
                {
                    combo_ville.Items.Add(PaysVille[i, 1]);
                }
            }
            errorProvider1.SetError(combo_pays, null);
        }

        private void combo_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(combo_ville, null);
        }

        private void combo_specialite_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(combo_specialite, null);
        }
        private Boolean valid_nom()
        {
            bool valid = false;
            string pattern = @"^[a-zA-ZÀ-ú\-\s]{3,}";
            Regex r = new Regex(pattern);
            Match m = r.Match(txt_nom.Text);
            if (m.Success)
            {
                valid = true;
                errorProvider1.SetError(txt_nom, null);
            }
            else
            {
                errorProvider1.SetError(txt_nom, "Nom invalid!");
            }
            return valid;
        }
        private Boolean valid_prenom()
        {
            bool valid = false;
            string pattern = @"^[a-zA-ZÀ-ú\-\s]{3,}";
            Regex r = new Regex(pattern);
            Match m = r.Match(txt_prenom.Text);
            if (m.Success)
            {
                valid = true;
                errorProvider1.SetError(txt_prenom, null);
            }
            else
            {
                errorProvider1.SetError(txt_prenom, "Prenom invalid!");
            }
            return valid;
        }
        private Boolean valid_tele()
        {
            bool valid = false;
            string pattern = @"^(05|06|07)([0-9]){8}$";
            Regex r = new Regex(pattern);
            Match m = r.Match(txt_tele.Text);
            if (m.Success)
            {
                valid = true;
                errorProvider1.SetError(txt_tele, null);
            }
            else
            {
                errorProvider1.SetError(txt_tele, "Numero de téléphone invalid!");
            }
            return valid;
        }
        private Boolean valid_addrese()
        {
            bool valid = false;
            string pattern = @"^\d+\s[A-z]+\s[A-z]+";
            Regex r = new Regex(pattern);
            Match m = r.Match(txt_addrese.Text);
            if (m.Success)
            {
                valid = true;
                errorProvider1.SetError(txt_addrese, null);
            }
            else
            {
                errorProvider1.SetError(txt_addrese, "Addrese invalid!");
            }
            return valid;
        }
        private Boolean valid_mail()
        {
            bool valid = false;
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex r = new Regex(pattern);
            Match m = r.Match(txt_mail.Text);
            if (m.Success)
            {
                valid = true;
                errorProvider1.SetError(txt_mail, null);
            }
            else
            {
                errorProvider1.SetError(txt_mail, "Email invalid!");
            }
            return valid;
        }
        private Boolean valid_pays()
        {
            bool valid = false;
            if (!combo_pays.Text.Trim().Equals(""))
            {
                valid = true;
                errorProvider1.SetError(combo_pays, null);
            }
            else
            {
                errorProvider1.SetError(combo_pays, "Merci de sélectionner un pays");
            }
            return valid;
        }
        private Boolean valid_ville()
        {
            bool valid = false;
            if (!combo_ville.Text.Trim().Equals(""))
            {
                valid = true;
                errorProvider1.SetError(combo_ville, null);
            }
            else
            {
                errorProvider1.SetError(combo_ville, "Merci de sélectionner une ville");
            }
            return valid;
        }
        private Boolean valid_specialite()
        {
            bool valid = false;
            if (!combo_specialite.Text.Trim().Equals(""))
            {
                valid = true;
                errorProvider1.SetError(combo_specialite, null);
            }
            else
            {
                errorProvider1.SetError(combo_specialite, "Merci de sélectionner une spécialité");
            }
            return valid;
        }

        private void combo_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection cnx = new Connection();
            cnx.open_connection();
            SqlCommand cmd = new SqlCommand("select * from studentinfo where id="+combo_id.Text, Connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txt_nom.Text = dr[1].ToString();
            txt_prenom.Text = dr[2].ToString();
            txt_addrese.Text = dr[3].ToString();
            txt_mail.Text = dr[4].ToString();
            combo_pays.Text = dr[5].ToString();
            combo_ville.Text = dr[6].ToString();
            combo_specialite.Text = dr[7].ToString();
            txt_tele.Text = dr[8].ToString();

            cnx.close_connection();
            txt_nom.Enabled = true;
            txt_prenom.Enabled = true;
            txt_addrese.Enabled = true;
            txt_tele.Enabled = true;
            txt_mail.Enabled = true;
            combo_pays.Enabled = true;
            combo_ville.Enabled = true;
            combo_specialite.Enabled = true;
        }

        public void remplire_combo_id()
        {
            combo_id.Items.Clear();
            Connection cnx = new Connection();
            cnx.open_connection();
            SqlCommand cmd = new SqlCommand("select id from studentinfo", Connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combo_id.Items.Add(dr[0]);
            }
            cnx.close_connection();
        }
        public void disaple_input()
        {
            txt_nom.Enabled = false;
            txt_prenom.Enabled = false;
            txt_addrese.Enabled = false;
            txt_tele.Enabled = false;
            txt_mail.Enabled = false;
            combo_pays.Enabled = false;
            combo_ville.Enabled = false;
            combo_specialite.Enabled = false;
        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Connection cnx = new Connection();
            cnx.open_connection();
            SqlCommand cmd = new SqlCommand("delete from studentinfo where id=" + combo_id.Text, Connection.con);
            cmd.ExecuteNonQuery();
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_addrese.Text = "";
            txt_mail.Text = "";
            combo_pays.Text = "";
            combo_ville.Text = "";
            combo_specialite.Text = "";
            txt_tele.Text = "";
            cnx.close_connection();
            remplire_combo_id();
            disaple_input();
            MessageBox.Show("L'apprenant a bien supprimer");
        }
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (valid_nom() && valid_prenom() && valid_tele() && valid_mail() && valid_pays() && valid_ville() && valid_specialite() && valid_addrese())
            {
                Connection cnx = new Connection();
                cnx.open_connection();
                SqlCommand cmd = new SqlCommand("update studentinfo set nom='" + txt_nom.Text + "',prenom='" + txt_prenom.Text + "',addrese='" +
                    txt_addrese.Text + "',email='" + txt_mail.Text + "',pays='" + combo_pays.Text + "',ville='" + combo_ville.Text + "'," +
                    "specilate='" + combo_specialite.Text + "',tele='" + txt_tele.Text + "' where id=" + combo_id.Text, Connection.con);
                cmd.ExecuteNonQuery();
                cnx.close_connection();
                MessageBox.Show("L'apprenant a bien modifier");
            }
        }
    }
}
