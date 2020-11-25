
namespace apprenant
{
    partial class Modifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_id = new System.Windows.Forms.ComboBox();
            this.combo_pays = new System.Windows.Forms.ComboBox();
            this.combo_ville = new System.Windows.Forms.ComboBox();
            this.combo_specialite = new System.Windows.Forms.ComboBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_addrese = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "addrese";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "specialités";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "pays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "adresse mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "nom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "id";
            // 
            // combo_id
            // 
            this.combo_id.FormattingEnabled = true;
            this.combo_id.Location = new System.Drawing.Point(239, 24);
            this.combo_id.Name = "combo_id";
            this.combo_id.Size = new System.Drawing.Size(200, 24);
            this.combo_id.TabIndex = 48;
            this.combo_id.SelectedIndexChanged += new System.EventHandler(this.combo_id_SelectedIndexChanged);
            // 
            // combo_pays
            // 
            this.combo_pays.FormattingEnabled = true;
            this.combo_pays.Location = new System.Drawing.Point(239, 307);
            this.combo_pays.Name = "combo_pays";
            this.combo_pays.Size = new System.Drawing.Size(200, 24);
            this.combo_pays.TabIndex = 58;
            this.combo_pays.SelectedIndexChanged += new System.EventHandler(this.combo_pays_SelectedIndexChanged);
            // 
            // combo_ville
            // 
            this.combo_ville.FormattingEnabled = true;
            this.combo_ville.Location = new System.Drawing.Point(239, 353);
            this.combo_ville.Name = "combo_ville";
            this.combo_ville.Size = new System.Drawing.Size(200, 24);
            this.combo_ville.TabIndex = 59;
            this.combo_ville.SelectedIndexChanged += new System.EventHandler(this.combo_ville_SelectedIndexChanged);
            // 
            // combo_specialite
            // 
            this.combo_specialite.FormattingEnabled = true;
            this.combo_specialite.Location = new System.Drawing.Point(239, 393);
            this.combo_specialite.Name = "combo_specialite";
            this.combo_specialite.Size = new System.Drawing.Size(200, 24);
            this.combo_specialite.TabIndex = 60;
            this.combo_specialite.SelectedIndexChanged += new System.EventHandler(this.combo_specialite_SelectedIndexChanged);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(239, 67);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(200, 22);
            this.txt_nom.TabIndex = 52;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(239, 115);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(200, 22);
            this.txt_prenom.TabIndex = 53;
            this.txt_prenom.TextChanged += new System.EventHandler(this.txt_prenom_TextChanged);
            // 
            // txt_tele
            // 
            this.txt_tele.Location = new System.Drawing.Point(239, 166);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(200, 22);
            this.txt_tele.TabIndex = 55;
            this.txt_tele.TextChanged += new System.EventHandler(this.txt_tele_TextChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(239, 210);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(200, 22);
            this.txt_mail.TabIndex = 56;
            this.txt_mail.TextChanged += new System.EventHandler(this.txt_mail_TextChanged);
            // 
            // txt_addrese
            // 
            this.txt_addrese.Location = new System.Drawing.Point(239, 259);
            this.txt_addrese.Name = "txt_addrese";
            this.txt_addrese.Size = new System.Drawing.Size(200, 22);
            this.txt_addrese.TabIndex = 57;
            this.txt_addrese.TextChanged += new System.EventHandler(this.txt_addrese_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(364, 458);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(89, 31);
            this.btn_modifier.TabIndex = 61;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(584, 458);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(84, 31);
            this.btn_supprimer.TabIndex = 62;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 547);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.txt_addrese);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_tele);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.combo_specialite);
            this.Controls.Add(this.combo_ville);
            this.Controls.Add(this.combo_pays);
            this.Controls.Add(this.combo_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modifier";
            this.Text = "modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_id;
        private System.Windows.Forms.ComboBox combo_pays;
        private System.Windows.Forms.ComboBox combo_ville;
        private System.Windows.Forms.ComboBox combo_specialite;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_addrese;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
    }
}