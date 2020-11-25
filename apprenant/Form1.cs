using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apprenant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter f = new Ajouter();
            f.Show();
            f.MdiParent = this;
            f.Location = new Point(0, 0);
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afficher f = new Afficher();
            f.Show();
            f.MdiParent = this;
            f.Location = new Point(0, 0);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier f = new Modifier();
            f.Show();
            f.MdiParent = this;
            f.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ajouterToolStripMenuItem_Click(sender, e);
        }
    }
}
