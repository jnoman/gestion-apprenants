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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }
        string[,] PaysVille = new string[,] { { "Maroc", "Casablanca" }, { "Maroc", "Marrakech" },{ "Maroc", "Tanger" },{ "Maroc", "Safi" },
                                             { "France", "Paris" },{ "France", "Marseille" },{ "France", "Lyon" },{ "France", "Toulouse" },
                                             { "Allemagne", "Berlin" },{ "Allemagne", "Hambourg" },{ "Allemagne", "Munich" },{ "Allemagne", "Cologne" }};
        private void Ajouter_Load(object sender, EventArgs e)
        {
            combo_ville.Enabled = false;
            combo_specialité.Items.AddRange(new string[] { "jee", "C#", "back-end font-end" });
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
        }

        private void combo_pays_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_ville.Items.Clear();
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
        private void combo_specialité_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(combo_specialité, null);
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (valid_nom() && valid_prenom() && valid_tele() && valid_mail() && valid_pays() && valid_ville() && valid_specialite() && valid_addrese())
            {
                Connection cnx = new Connection();
                cnx.open_connection();
                SqlCommand cmd = new SqlCommand("insert into studentinfo(nom,prenom,addrese,email,pays,ville,specilate,tele)" +
                    "values('"+txt_nom.Text+ "','" + txt_prenom.Text + "','" + txt_addrese.Text + "','" + txt_mail.Text + "','" +
                    combo_pays.Text + "','" + combo_ville.Text + "','" + combo_specialité.Text + "','" + txt_tele.Text + "')", Connection.con);
                cmd.ExecuteNonQuery();
                cnx.close_connection();
                MessageBox.Show("L'apprenant a bien ajouté");
            }
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
            if (!combo_specialité.Text.Trim().Equals(""))
            {
                valid = true;
                errorProvider1.SetError(combo_specialité, null);
            }
            else
            {
                errorProvider1.SetError(combo_specialité, "Merci de sélectionner une spécialité");
            }
            return valid;
        }

    }
}
