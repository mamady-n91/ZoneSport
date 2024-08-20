namespace PPE2
{
    partial class Accueil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTitreMagasin = new System.Windows.Forms.Label();
            this.numUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.lblPrixMax = new System.Windows.Forms.Label();
            this.lblPrixMin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValiderCriteres = new System.Windows.Forms.Button();
            this.lblMarque = new System.Windows.Forms.Label();
            this.cbBoxMarque = new System.Windows.Forms.ComboBox();
            this.lblCategProduit = new System.Windows.Forms.Label();
            this.cbBoxCategProduit = new System.Windows.Forms.ComboBox();
            this.btnConsulterPanier = new System.Windows.Forms.Button();
            this.btnShowTsLesProd = new System.Windows.Forms.Button();
            this.dtGridViewProduits = new System.Windows.Forms.DataGridView();
            this.IdProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Tarif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo_Produit = new System.Windows.Forms.DataGridViewImageColumn();
            this.gpBoxMarque = new System.Windows.Forms.GroupBox();
            this.btnValiderMarque = new System.Windows.Forms.Button();
            this.gpBoxCategProduit = new System.Windows.Forms.GroupBox();
            this.btnValiderChoixCategProduit = new System.Windows.Forms.Button();
            this.btnAjoutPanier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAjoutProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewProduits)).BeginInit();
            this.gpBoxMarque.SuspendLayout();
            this.gpBoxCategProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTitreMagasin
            // 
            this.btnTitreMagasin.AutoSize = true;
            this.btnTitreMagasin.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitreMagasin.Location = new System.Drawing.Point(228, 9);
            this.btnTitreMagasin.Name = "btnTitreMagasin";
            this.btnTitreMagasin.Size = new System.Drawing.Size(158, 33);
            this.btnTitreMagasin.TabIndex = 8;
            this.btnTitreMagasin.Text = "Zone Sport";
            // 
            // numUpDownMin
            // 
            this.numUpDownMin.Location = new System.Drawing.Point(76, 15);
            this.numUpDownMin.Name = "numUpDownMin";
            this.numUpDownMin.Size = new System.Drawing.Size(63, 20);
            this.numUpDownMin.TabIndex = 9;
            this.numUpDownMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numUpDownMax
            // 
            this.numUpDownMax.Location = new System.Drawing.Point(76, 44);
            this.numUpDownMax.Name = "numUpDownMax";
            this.numUpDownMax.Size = new System.Drawing.Size(63, 20);
            this.numUpDownMax.TabIndex = 10;
            this.numUpDownMax.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblPrixMax
            // 
            this.lblPrixMax.AutoSize = true;
            this.lblPrixMax.Location = new System.Drawing.Point(3, 44);
            this.lblPrixMax.Name = "lblPrixMax";
            this.lblPrixMax.Size = new System.Drawing.Size(70, 13);
            this.lblPrixMax.TabIndex = 11;
            this.lblPrixMax.Text = "Prix maximum";
            // 
            // lblPrixMin
            // 
            this.lblPrixMin.AutoSize = true;
            this.lblPrixMin.Location = new System.Drawing.Point(3, 16);
            this.lblPrixMin.Name = "lblPrixMin";
            this.lblPrixMin.Size = new System.Drawing.Size(67, 13);
            this.lblPrixMin.TabIndex = 12;
            this.lblPrixMin.Text = "Prix minimum";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUpDownMin);
            this.groupBox1.Controls.Add(this.btnValiderCriteres);
            this.groupBox1.Controls.Add(this.lblPrixMax);
            this.groupBox1.Controls.Add(this.lblPrixMin);
            this.groupBox1.Controls.Add(this.numUpDownMax);
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 103);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnValiderCriteres
            // 
            this.btnValiderCriteres.Location = new System.Drawing.Point(67, 72);
            this.btnValiderCriteres.Name = "btnValiderCriteres";
            this.btnValiderCriteres.Size = new System.Drawing.Size(101, 27);
            this.btnValiderCriteres.TabIndex = 17;
            this.btnValiderCriteres.Text = "Vaider les prix";
            this.btnValiderCriteres.UseVisualStyleBackColor = true;
            this.btnValiderCriteres.Click += new System.EventHandler(this.btnValiderCriteres_Click);
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(18, 14);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 16;
            this.lblMarque.Text = "Marque";
            // 
            // cbBoxMarque
            // 
            this.cbBoxMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxMarque.FormattingEnabled = true;
            this.cbBoxMarque.Items.AddRange(new object[] {
            "PUMA",
            "NIKE",
            "ADIDAS",
            "NEW BALANCE"});
            this.cbBoxMarque.Location = new System.Drawing.Point(6, 41);
            this.cbBoxMarque.Name = "cbBoxMarque";
            this.cbBoxMarque.Size = new System.Drawing.Size(105, 21);
            this.cbBoxMarque.TabIndex = 15;
            this.cbBoxMarque.SelectedIndexChanged += new System.EventHandler(this.cbBoxMarque_SelectedIndexChanged);
            // 
            // lblCategProduit
            // 
            this.lblCategProduit.AutoSize = true;
            this.lblCategProduit.Location = new System.Drawing.Point(6, 13);
            this.lblCategProduit.Name = "lblCategProduit";
            this.lblCategProduit.Size = new System.Drawing.Size(102, 13);
            this.lblCategProduit.TabIndex = 14;
            this.lblCategProduit.Text = "Catégorie de produit";
            // 
            // cbBoxCategProduit
            // 
            this.cbBoxCategProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCategProduit.FormattingEnabled = true;
            this.cbBoxCategProduit.Location = new System.Drawing.Point(6, 41);
            this.cbBoxCategProduit.Name = "cbBoxCategProduit";
            this.cbBoxCategProduit.Size = new System.Drawing.Size(110, 21);
            this.cbBoxCategProduit.TabIndex = 13;
            // 
            // btnConsulterPanier
            // 
            this.btnConsulterPanier.Location = new System.Drawing.Point(882, 20);
            this.btnConsulterPanier.Name = "btnConsulterPanier";
            this.btnConsulterPanier.Size = new System.Drawing.Size(75, 22);
            this.btnConsulterPanier.TabIndex = 25;
            this.btnConsulterPanier.Text = "Panier";
            this.btnConsulterPanier.UseVisualStyleBackColor = true;
            this.btnConsulterPanier.Click += new System.EventHandler(this.btnConsulterPanier_Click);
            // 
            // btnShowTsLesProd
            // 
            this.btnShowTsLesProd.Location = new System.Drawing.Point(221, 148);
            this.btnShowTsLesProd.Name = "btnShowTsLesProd";
            this.btnShowTsLesProd.Size = new System.Drawing.Size(307, 23);
            this.btnShowTsLesProd.TabIndex = 29;
            this.btnShowTsLesProd.Text = "Afficher tous les produits";
            this.btnShowTsLesProd.UseVisualStyleBackColor = true;
            this.btnShowTsLesProd.Click += new System.EventHandler(this.btnShowTsLesProd_Click);
            // 
            // dtGridViewProduits
            // 
            this.dtGridViewProduits.AllowUserToAddRows = false;
            this.dtGridViewProduits.AllowUserToDeleteRows = false;
            this.dtGridViewProduits.AllowUserToResizeColumns = false;
            this.dtGridViewProduits.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dtGridViewProduits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduit,
            this.CATEGORIE,
            this.Nom_Produit,
            this.Marque,
            this.Prix_Tarif,
            this.Photo_Produit});
            this.dtGridViewProduits.Location = new System.Drawing.Point(18, 177);
            this.dtGridViewProduits.Name = "dtGridViewProduits";
            this.dtGridViewProduits.ReadOnly = true;
            this.dtGridViewProduits.Size = new System.Drawing.Size(754, 318);
            this.dtGridViewProduits.TabIndex = 30;
            // 
            // IdProduit
            // 
            this.IdProduit.DataPropertyName = "NO_PRODUIT";
            this.IdProduit.HeaderText = "No_Produit";
            this.IdProduit.Name = "IdProduit";
            this.IdProduit.ReadOnly = true;
            this.IdProduit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CATEGORIE
            // 
            this.CATEGORIE.DataPropertyName = "CATEGORIE_PRODUIT";
            this.CATEGORIE.HeaderText = "Categorie";
            this.CATEGORIE.Name = "CATEGORIE";
            this.CATEGORIE.ReadOnly = true;
            // 
            // Nom_Produit
            // 
            this.Nom_Produit.DataPropertyName = "NOM_PRODUIT";
            this.Nom_Produit.HeaderText = "Nom_Produit";
            this.Nom_Produit.Name = "Nom_Produit";
            this.Nom_Produit.ReadOnly = true;
            // 
            // Marque
            // 
            this.Marque.DataPropertyName = "MARQUE_PRODUIT";
            this.Marque.HeaderText = "Marque";
            this.Marque.Name = "Marque";
            this.Marque.ReadOnly = true;
            // 
            // Prix_Tarif
            // 
            this.Prix_Tarif.DataPropertyName = "PRIX_TARIF";
            this.Prix_Tarif.HeaderText = "Prix";
            this.Prix_Tarif.Name = "Prix_Tarif";
            this.Prix_Tarif.ReadOnly = true;
            // 
            // Photo_Produit
            // 
            this.Photo_Produit.DataPropertyName = "PHOTO_PRODUIT";
            this.Photo_Produit.HeaderText = "Image";
            this.Photo_Produit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Photo_Produit.Name = "Photo_Produit";
            this.Photo_Produit.ReadOnly = true;
            this.Photo_Produit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gpBoxMarque
            // 
            this.gpBoxMarque.Controls.Add(this.btnValiderMarque);
            this.gpBoxMarque.Controls.Add(this.cbBoxMarque);
            this.gpBoxMarque.Controls.Add(this.lblMarque);
            this.gpBoxMarque.Location = new System.Drawing.Point(276, 48);
            this.gpBoxMarque.Name = "gpBoxMarque";
            this.gpBoxMarque.Size = new System.Drawing.Size(200, 100);
            this.gpBoxMarque.TabIndex = 31;
            this.gpBoxMarque.TabStop = false;
            // 
            // btnValiderMarque
            // 
            this.btnValiderMarque.Location = new System.Drawing.Point(6, 71);
            this.btnValiderMarque.Name = "btnValiderMarque";
            this.btnValiderMarque.Size = new System.Drawing.Size(118, 23);
            this.btnValiderMarque.TabIndex = 17;
            this.btnValiderMarque.Text = "Choisir cette marque";
            this.btnValiderMarque.UseVisualStyleBackColor = true;
            this.btnValiderMarque.Click += new System.EventHandler(this.btnValiderMarque_Click);
            // 
            // gpBoxCategProduit
            // 
            this.gpBoxCategProduit.Controls.Add(this.btnValiderChoixCategProduit);
            this.gpBoxCategProduit.Controls.Add(this.lblCategProduit);
            this.gpBoxCategProduit.Controls.Add(this.cbBoxCategProduit);
            this.gpBoxCategProduit.Location = new System.Drawing.Point(482, 48);
            this.gpBoxCategProduit.Name = "gpBoxCategProduit";
            this.gpBoxCategProduit.Size = new System.Drawing.Size(210, 100);
            this.gpBoxCategProduit.TabIndex = 32;
            this.gpBoxCategProduit.TabStop = false;
            // 
            // btnValiderChoixCategProduit
            // 
            this.btnValiderChoixCategProduit.Location = new System.Drawing.Point(6, 71);
            this.btnValiderChoixCategProduit.Name = "btnValiderChoixCategProduit";
            this.btnValiderChoixCategProduit.Size = new System.Drawing.Size(184, 23);
            this.btnValiderChoixCategProduit.TabIndex = 15;
            this.btnValiderChoixCategProduit.Text = "Choisir cette catégorie de produit";
            this.btnValiderChoixCategProduit.UseVisualStyleBackColor = true;
            this.btnValiderChoixCategProduit.Click += new System.EventHandler(this.btnValiderChoixCategProduit_Click);
            // 
            // btnAjoutPanier
            // 
            this.btnAjoutPanier.Location = new System.Drawing.Point(801, 190);
            this.btnAjoutPanier.Name = "btnAjoutPanier";
            this.btnAjoutPanier.Size = new System.Drawing.Size(131, 23);
            this.btnAjoutPanier.TabIndex = 34;
            this.btnAjoutPanier.Text = "Ajouter au panier";
            this.btnAjoutPanier.UseVisualStyleBackColor = true;
            this.btnAjoutPanier.Click += new System.EventHandler(this.btnAjoutPanier_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(719, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Revenir à l\'accueil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.Location = new System.Drawing.Point(698, 89);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(117, 23);
            this.btnAjoutProduit.TabIndex = 36;
            this.btnAjoutProduit.Text = "Ajouter  Produit";
            this.btnAjoutProduit.UseVisualStyleBackColor = true;
            this.btnAjoutProduit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(847, 89);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(75, 23);
            this.btnModifierProduit.TabIndex = 37;
            this.btnModifierProduit.Text = "Modifier Produit";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 502);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.btnAjoutProduit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAjoutPanier);
            this.Controls.Add(this.gpBoxCategProduit);
            this.Controls.Add(this.gpBoxMarque);
            this.Controls.Add(this.dtGridViewProduits);
            this.Controls.Add(this.btnShowTsLesProd);
            this.Controls.Add(this.btnConsulterPanier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTitreMagasin);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewProduits)).EndInit();
            this.gpBoxMarque.ResumeLayout(false);
            this.gpBoxMarque.PerformLayout();
            this.gpBoxCategProduit.ResumeLayout(false);
            this.gpBoxCategProduit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnTitreMagasin;
        private System.Windows.Forms.NumericUpDown numUpDownMin;
        private System.Windows.Forms.NumericUpDown numUpDownMax;
        private System.Windows.Forms.Label lblPrixMax;
        private System.Windows.Forms.Label lblPrixMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBoxCategProduit;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.ComboBox cbBoxMarque;
        private System.Windows.Forms.Label lblCategProduit;
        private System.Windows.Forms.Button btnValiderCriteres;
        private System.Windows.Forms.Button btnConsulterPanier;
        private System.Windows.Forms.Button btnShowTsLesProd;
        private System.Windows.Forms.DataGridView dtGridViewProduits;
        private System.Windows.Forms.GroupBox gpBoxMarque;
        private System.Windows.Forms.Button btnValiderMarque;
        private System.Windows.Forms.GroupBox gpBoxCategProduit;
        private System.Windows.Forms.Button btnValiderChoixCategProduit;
        private System.Windows.Forms.Button btnAjoutPanier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Tarif;
        private System.Windows.Forms.DataGridViewImageColumn Photo_Produit;
        private System.Windows.Forms.Button btnAjoutProduit;
        private System.Windows.Forms.Button btnModifierProduit;
    }
}