namespace PPE2
{
    partial class FormPanier
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
            this.dtGridViewPanier = new System.Windows.Forms.DataGridView();
            this.lblMonPanier = new System.Windows.Forms.Label();
            this.btnValiderCommande = new System.Windows.Forms.Button();
            this.btnAnnulerCommande = new System.Windows.Forms.Button();
            this.numUpDownQtCommandee = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmerQt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPanier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQtCommandee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewPanier
            // 
            this.dtGridViewPanier.AllowUserToAddRows = false;
            this.dtGridViewPanier.AllowUserToDeleteRows = false;
            this.dtGridViewPanier.AllowUserToResizeColumns = false;
            this.dtGridViewPanier.AllowUserToResizeRows = false;
            this.dtGridViewPanier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewPanier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewPanier.Location = new System.Drawing.Point(22, 84);
            this.dtGridViewPanier.Name = "dtGridViewPanier";
            this.dtGridViewPanier.ReadOnly = true;
            this.dtGridViewPanier.Size = new System.Drawing.Size(556, 185);
            this.dtGridViewPanier.TabIndex = 0;
            // 
            // lblMonPanier
            // 
            this.lblMonPanier.AutoSize = true;
            this.lblMonPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonPanier.Location = new System.Drawing.Point(278, 9);
            this.lblMonPanier.Name = "lblMonPanier";
            this.lblMonPanier.Size = new System.Drawing.Size(122, 25);
            this.lblMonPanier.TabIndex = 1;
            this.lblMonPanier.Text = "Mon Panier";
            // 
            // btnValiderCommande
            // 
            this.btnValiderCommande.Location = new System.Drawing.Point(584, 93);
            this.btnValiderCommande.Name = "btnValiderCommande";
            this.btnValiderCommande.Size = new System.Drawing.Size(128, 23);
            this.btnValiderCommande.TabIndex = 2;
            this.btnValiderCommande.Text = "Enregistrer Commande";
            this.btnValiderCommande.UseVisualStyleBackColor = true;
            this.btnValiderCommande.Click += new System.EventHandler(this.btnValiderCommande_Click);
            // 
            // btnAnnulerCommande
            // 
            this.btnAnnulerCommande.Location = new System.Drawing.Point(584, 139);
            this.btnAnnulerCommande.Name = "btnAnnulerCommande";
            this.btnAnnulerCommande.Size = new System.Drawing.Size(128, 23);
            this.btnAnnulerCommande.TabIndex = 3;
            this.btnAnnulerCommande.Text = "Annuler la commande";
            this.btnAnnulerCommande.UseVisualStyleBackColor = true;
            this.btnAnnulerCommande.Click += new System.EventHandler(this.btnAnnulerCommande_Click);
            // 
            // numUpDownQtCommandee
            // 
            this.numUpDownQtCommandee.Location = new System.Drawing.Point(592, 189);
            this.numUpDownQtCommandee.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownQtCommandee.Name = "numUpDownQtCommandee";
            this.numUpDownQtCommandee.Size = new System.Drawing.Size(120, 20);
            this.numUpDownQtCommandee.TabIndex = 4;
            this.numUpDownQtCommandee.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownQtCommandee.ValueChanged += new System.EventHandler(this.numUpDownQtCommandee_ValueChanged);
            this.numUpDownQtCommandee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numUpDownQtCommandee_KeyPress);
            // 
            // btnConfirmerQt
            // 
            this.btnConfirmerQt.Location = new System.Drawing.Point(592, 226);
            this.btnConfirmerQt.Name = "btnConfirmerQt";
            this.btnConfirmerQt.Size = new System.Drawing.Size(120, 23);
            this.btnConfirmerQt.TabIndex = 5;
            this.btnConfirmerQt.Text = "Confirmer la quantité";
            this.btnConfirmerQt.UseVisualStyleBackColor = true;
            this.btnConfirmerQt.Click += new System.EventHandler(this.btnConfirmerQt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Montant total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // FormPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmerQt);
            this.Controls.Add(this.numUpDownQtCommandee);
            this.Controls.Add(this.btnAnnulerCommande);
            this.Controls.Add(this.btnValiderCommande);
            this.Controls.Add(this.lblMonPanier);
            this.Controls.Add(this.dtGridViewPanier);
            this.Name = "FormPanier";
            this.Text = "FormPanier";
            this.Load += new System.EventHandler(this.FormPanier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPanier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQtCommandee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewPanier;
        private System.Windows.Forms.Label lblMonPanier;
        private System.Windows.Forms.Button btnValiderCommande;
        private System.Windows.Forms.Button btnAnnulerCommande;
        private System.Windows.Forms.NumericUpDown numUpDownQtCommandee;
        private System.Windows.Forms.Button btnConfirmerQt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}