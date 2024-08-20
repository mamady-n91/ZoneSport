namespace PPE2
{
    partial class Inscription
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
            this.lblFormInscription = new System.Windows.Forms.Label();
            this.gpBoxFormInscrip = new System.Windows.Forms.GroupBox();
            this.cbBoxCp = new System.Windows.Forms.ComboBox();
            this.cbBoxVille = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblDtNaiss = new System.Windows.Forms.Label();
            this.lblPrenomClt = new System.Windows.Forms.Label();
            this.lblNomClt = new System.Windows.Forms.Label();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.dtPckrDtNaiss = new System.Windows.Forms.DateTimePicker();
            this.btnValiderInscription = new System.Windows.Forms.Button();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomClt = new System.Windows.Forms.TextBox();
            this.txtBoxNomClt = new System.Windows.Forms.TextBox();
            this.txtBoxPseudo = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.gpBoxFormInscrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormInscription
            // 
            this.lblFormInscription.AutoSize = true;
            this.lblFormInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormInscription.ForeColor = System.Drawing.Color.White;
            this.lblFormInscription.Location = new System.Drawing.Point(244, 9);
            this.lblFormInscription.Name = "lblFormInscription";
            this.lblFormInscription.Size = new System.Drawing.Size(258, 25);
            this.lblFormInscription.TabIndex = 0;
            this.lblFormInscription.Text = "Formulaire d\'inscription";
            // 
            // gpBoxFormInscrip
            // 
            this.gpBoxFormInscrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpBoxFormInscrip.Controls.Add(this.lblPseudo);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxPseudo);
            this.gpBoxFormInscrip.Controls.Add(this.cbBoxCp);
            this.gpBoxFormInscrip.Controls.Add(this.cbBoxVille);
            this.gpBoxFormInscrip.Controls.Add(this.label8);
            this.gpBoxFormInscrip.Controls.Add(this.label7);
            this.gpBoxFormInscrip.Controls.Add(this.label5);
            this.gpBoxFormInscrip.Controls.Add(this.label2);
            this.gpBoxFormInscrip.Controls.Add(this.label1);
            this.gpBoxFormInscrip.Controls.Add(this.lblMdp);
            this.gpBoxFormInscrip.Controls.Add(this.lblMail);
            this.gpBoxFormInscrip.Controls.Add(this.lblTel);
            this.gpBoxFormInscrip.Controls.Add(this.lblCp);
            this.gpBoxFormInscrip.Controls.Add(this.lblVille);
            this.gpBoxFormInscrip.Controls.Add(this.lblAdresse);
            this.gpBoxFormInscrip.Controls.Add(this.lblDtNaiss);
            this.gpBoxFormInscrip.Controls.Add(this.lblPrenomClt);
            this.gpBoxFormInscrip.Controls.Add(this.lblNomClt);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxMdp);
            this.gpBoxFormInscrip.Controls.Add(this.dtPckrDtNaiss);
            this.gpBoxFormInscrip.Controls.Add(this.btnValiderInscription);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxMail);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxTel);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxAdresse);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxPrenomClt);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxNomClt);
            this.gpBoxFormInscrip.Location = new System.Drawing.Point(133, 57);
            this.gpBoxFormInscrip.Name = "gpBoxFormInscrip";
            this.gpBoxFormInscrip.Size = new System.Drawing.Size(489, 442);
            this.gpBoxFormInscrip.TabIndex = 21;
            this.gpBoxFormInscrip.TabStop = false;
            // 
            // cbBoxCp
            // 
            this.cbBoxCp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCp.FormattingEnabled = true;
            this.cbBoxCp.Location = new System.Drawing.Point(160, 276);
            this.cbBoxCp.MaxLength = 6;
            this.cbBoxCp.Name = "cbBoxCp";
            this.cbBoxCp.Size = new System.Drawing.Size(113, 21);
            this.cbBoxCp.TabIndex = 49;
            // 
            // cbBoxVille
            // 
            this.cbBoxVille.FormattingEnabled = true;
            this.cbBoxVille.Location = new System.Drawing.Point(158, 233);
            this.cbBoxVille.MaxLength = 20;
            this.cbBoxVille.Name = "cbBoxVille";
            this.cbBoxVille.Size = new System.Drawing.Size(113, 21);
            this.cbBoxVille.TabIndex = 48;
            this.cbBoxVille.SelectedValueChanged += new System.EventHandler(this.cbBoxVille_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "15 caractères minimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "8 caractères minimum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "10 caractères minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "3 caractères minimum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "2 caractères minimum";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(27, 385);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(71, 13);
            this.lblMdp.TabIndex = 39;
            this.lblMdp.Text = "Mot de passe";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(27, 347);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 38;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(27, 315);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 13);
            this.lblTel.TabIndex = 37;
            this.lblTel.Text = "Telephone";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(27, 279);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(63, 13);
            this.lblCp.TabIndex = 36;
            this.lblCp.Text = "Code postal";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(27, 236);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 35;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(27, 196);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 34;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblDtNaiss
            // 
            this.lblDtNaiss.AutoSize = true;
            this.lblDtNaiss.Location = new System.Drawing.Point(27, 157);
            this.lblDtNaiss.Name = "lblDtNaiss";
            this.lblDtNaiss.Size = new System.Drawing.Size(96, 13);
            this.lblDtNaiss.TabIndex = 33;
            this.lblDtNaiss.Text = "Date de naissance";
            // 
            // lblPrenomClt
            // 
            this.lblPrenomClt.AutoSize = true;
            this.lblPrenomClt.Location = new System.Drawing.Point(27, 122);
            this.lblPrenomClt.Name = "lblPrenomClt";
            this.lblPrenomClt.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomClt.TabIndex = 32;
            this.lblPrenomClt.Text = "Prenom";
            // 
            // lblNomClt
            // 
            this.lblNomClt.AutoSize = true;
            this.lblNomClt.Location = new System.Drawing.Point(27, 87);
            this.lblNomClt.Name = "lblNomClt";
            this.lblNomClt.Size = new System.Drawing.Size(29, 13);
            this.lblNomClt.TabIndex = 31;
            this.lblNomClt.Text = "Nom";
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(159, 374);
            this.txtBoxMdp.MaxLength = 10;
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.PasswordChar = '*';
            this.txtBoxMdp.Size = new System.Drawing.Size(156, 20);
            this.txtBoxMdp.TabIndex = 30;
            // 
            // dtPckrDtNaiss
            // 
            this.dtPckrDtNaiss.Location = new System.Drawing.Point(158, 153);
            this.dtPckrDtNaiss.Name = "dtPckrDtNaiss";
            this.dtPckrDtNaiss.Size = new System.Drawing.Size(200, 20);
            this.dtPckrDtNaiss.TabIndex = 29;
            // 
            // btnValiderInscription
            // 
            this.btnValiderInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnValiderInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderInscription.ForeColor = System.Drawing.Color.White;
            this.btnValiderInscription.Location = new System.Drawing.Point(160, 407);
            this.btnValiderInscription.Name = "btnValiderInscription";
            this.btnValiderInscription.Size = new System.Drawing.Size(146, 30);
            this.btnValiderInscription.TabIndex = 28;
            this.btnValiderInscription.Text = "Valider les informations";
            this.btnValiderInscription.UseVisualStyleBackColor = false;
            this.btnValiderInscription.Click += new System.EventHandler(this.btnValiderInscription_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(160, 343);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(156, 20);
            this.txtBoxMail.TabIndex = 27;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(160, 304);
            this.txtBoxTel.MaxLength = 10;
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(156, 20);
            this.txtBoxTel.TabIndex = 26;
            this.txtBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTel_KeyPress_1);
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(160, 189);
            this.txtBoxAdresse.MaxLength = 70;
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(156, 20);
            this.txtBoxAdresse.TabIndex = 23;
            // 
            // txtBoxPrenomClt
            // 
            this.txtBoxPrenomClt.Location = new System.Drawing.Point(160, 118);
            this.txtBoxPrenomClt.Name = "txtBoxPrenomClt";
            this.txtBoxPrenomClt.Size = new System.Drawing.Size(156, 20);
            this.txtBoxPrenomClt.TabIndex = 22;
            this.txtBoxPrenomClt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrenomClt_KeyPress_1);
            // 
            // txtBoxNomClt
            // 
            this.txtBoxNomClt.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNomClt.Location = new System.Drawing.Point(160, 84);
            this.txtBoxNomClt.Name = "txtBoxNomClt";
            this.txtBoxNomClt.Size = new System.Drawing.Size(156, 20);
            this.txtBoxNomClt.TabIndex = 21;
            this.txtBoxNomClt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNomClt_KeyPress_1);
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.Location = new System.Drawing.Point(158, 43);
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(158, 20);
            this.txtBoxPseudo.TabIndex = 50;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(27, 46);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(43, 13);
            this.lblPseudo.TabIndex = 51;
            this.lblPseudo.Text = "Pseudo";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.gpBoxFormInscrip);
            this.Controls.Add(this.lblFormInscription);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.gpBoxFormInscrip.ResumeLayout(false);
            this.gpBoxFormInscrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormInscription;
        private System.Windows.Forms.GroupBox gpBoxFormInscrip;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblDtNaiss;
        private System.Windows.Forms.Label lblPrenomClt;
        private System.Windows.Forms.Label lblNomClt;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.DateTimePicker dtPckrDtNaiss;
        private System.Windows.Forms.Button btnValiderInscription;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxPrenomClt;
        private System.Windows.Forms.TextBox txtBoxNomClt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxVille;
        private System.Windows.Forms.ComboBox cbBoxCp;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox txtBoxPseudo;
    }
}