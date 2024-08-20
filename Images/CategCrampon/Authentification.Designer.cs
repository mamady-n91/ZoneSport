namespace PPE2.Images.CategCrampon
{
    partial class Authentification
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
            this.lblConnexion = new System.Windows.Forms.Label();
            this.gpBoxFormInscrip = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.btnValiderCnx = new System.Windows.Forms.Button();
            this.txtBoxPseudo = new System.Windows.Forms.TextBox();
            this.btnInscription = new System.Windows.Forms.Button();
            this.gpBoxFormInscrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.Color.White;
            this.lblConnexion.Location = new System.Drawing.Point(160, 9);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(286, 25);
            this.lblConnexion.TabIndex = 5;
            this.lblConnexion.Text = "Bienvenue sur Zone Sport";
            // 
            // gpBoxFormInscrip
            // 
            this.gpBoxFormInscrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpBoxFormInscrip.Controls.Add(this.label2);
            this.gpBoxFormInscrip.Controls.Add(this.lblPseudo);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxMdp);
            this.gpBoxFormInscrip.Controls.Add(this.btnValiderCnx);
            this.gpBoxFormInscrip.Controls.Add(this.txtBoxPseudo);
            this.gpBoxFormInscrip.Location = new System.Drawing.Point(165, 101);
            this.gpBoxFormInscrip.Name = "gpBoxFormInscrip";
            this.gpBoxFormInscrip.Size = new System.Drawing.Size(281, 191);
            this.gpBoxFormInscrip.TabIndex = 22;
            this.gpBoxFormInscrip.TabStop = false;
            this.gpBoxFormInscrip.Enter += new System.EventHandler(this.gpBoxFormInscrip_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mot de passe";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(6, 36);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(43, 13);
            this.lblPseudo.TabIndex = 38;
            this.lblPseudo.Text = "Pseudo";
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(119, 83);
            this.txtBoxMdp.MaxLength = 10;
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.PasswordChar = '*';
            this.txtBoxMdp.Size = new System.Drawing.Size(140, 20);
            this.txtBoxMdp.TabIndex = 30;
            // 
            // btnValiderCnx
            // 
            this.btnValiderCnx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnValiderCnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderCnx.ForeColor = System.Drawing.Color.White;
            this.btnValiderCnx.Location = new System.Drawing.Point(113, 129);
            this.btnValiderCnx.Name = "btnValiderCnx";
            this.btnValiderCnx.Size = new System.Drawing.Size(146, 30);
            this.btnValiderCnx.TabIndex = 28;
            this.btnValiderCnx.Text = "Valider";
            this.btnValiderCnx.UseVisualStyleBackColor = false;
            this.btnValiderCnx.Click += new System.EventHandler(this.btnValiderCnx_Click);
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.Location = new System.Drawing.Point(119, 36);
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(140, 20);
            this.txtBoxPseudo.TabIndex = 27;
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInscription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.Location = new System.Drawing.Point(41, 298);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(605, 23);
            this.btnInscription.TabIndex = 23;
            this.btnInscription.Text = "Pas encore inscrit ? Inscrivez vous dès maintenant pour pouvoir commander au plus" +
    " vite vos produits";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.gpBoxFormInscrip);
            this.Controls.Add(this.lblConnexion);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.gpBoxFormInscrip.ResumeLayout(false);
            this.gpBoxFormInscrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.GroupBox gpBoxFormInscrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.Button btnValiderCnx;
        private System.Windows.Forms.TextBox txtBoxPseudo;
        private System.Windows.Forms.Button btnInscription;
    }
}