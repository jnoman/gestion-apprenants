
namespace apprenant
{
    partial class Ajouter
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
            this.combo_specialité = new System.Windows.Forms.ComboBox();
            this.combo_ville = new System.Windows.Forms.ComboBox();
            this.combo_pays = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_addrese = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_specialité
            // 
            this.combo_specialité.FormattingEnabled = true;
            this.combo_specialité.Location = new System.Drawing.Point(287, 369);
            this.combo_specialité.Name = "combo_specialité";
            this.combo_specialité.Size = new System.Drawing.Size(168, 24);
            this.combo_specialité.TabIndex = 36;
            this.combo_specialité.SelectedIndexChanged += new System.EventHandler(this.combo_specialité_SelectedIndexChanged);
            // 
            // combo_ville
            // 
            this.combo_ville.FormattingEnabled = true;
            this.combo_ville.Location = new System.Drawing.Point(287, 328);
            this.combo_ville.Name = "combo_ville";
            this.combo_ville.Size = new System.Drawing.Size(168, 24);
            this.combo_ville.TabIndex = 35;
            this.combo_ville.SelectedIndexChanged += new System.EventHandler(this.combo_ville_SelectedIndexChanged);
            // 
            // combo_pays
            // 
            this.combo_pays.FormattingEnabled = true;
            this.combo_pays.Location = new System.Drawing.Point(287, 282);
            this.combo_pays.Name = "combo_pays";
            this.combo_pays.Size = new System.Drawing.Size(168, 24);
            this.combo_pays.TabIndex = 34;
            this.combo_pays.SelectedIndexChanged += new System.EventHandler(this.combo_pays_SelectedIndexChanged);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(377, 470);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 32);
            this.btn_ajouter.TabIndex = 33;
            this.btn_ajouter.Text = "ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(290, 187);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(165, 22);
            this.txt_mail.TabIndex = 32;
            this.txt_mail.TextChanged += new System.EventHandler(this.txt_mail_TextChanged);
            // 
            // txt_tele
            // 
            this.txt_tele.Location = new System.Drawing.Point(290, 143);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(165, 22);
            this.txt_tele.TabIndex = 31;
            this.txt_tele.TextChanged += new System.EventHandler(this.txt_tele_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(290, 93);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(165, 22);
            this.txt_prenom.TabIndex = 29;
            this.txt_prenom.TextChanged += new System.EventHandler(this.txt_prenom_TextChanged);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(290, 47);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(165, 22);
            this.txt_nom.TabIndex = 28;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "specialités";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "pays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "adresse mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "nom";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_addrese
            // 
            this.txt_addrese.Location = new System.Drawing.Point(290, 236);
            this.txt_addrese.Name = "txt_addrese";
            this.txt_addrese.Size = new System.Drawing.Size(165, 22);
            this.txt_addrese.TabIndex = 33;
            this.txt_addrese.TextChanged += new System.EventHandler(this.txt_addrese_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "addrese";
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 547);
            this.Controls.Add(this.txt_addrese);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_specialité);
            this.Controls.Add(this.combo_ville);
            this.Controls.Add(this.combo_pays);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_tele);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajouter";
            this.Text = "ajouter";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox combo_specialité;
        private System.Windows.Forms.ComboBox combo_ville;
        private System.Windows.Forms.ComboBox combo_pays;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_addrese;
        private System.Windows.Forms.Label label9;
    }
}