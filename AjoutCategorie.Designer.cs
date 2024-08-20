namespace PPE2
{
    partial class AjoutCategorie
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
            this.txtBoxCdeCategProduit = new System.Windows.Forms.TextBox();
            this.txtBoxLibelleCateg = new System.Windows.Forms.TextBox();
            this.btnInsertCategorie = new System.Windows.Forms.Button();
            this.txtBoxNomProduit = new System.Windows.Forms.TextBox();
            this.btnAjoutImg = new System.Windows.Forms.Button();
            this.btnInsertProduit = new System.Windows.Forms.Button();
            this.lblCodeCategProduit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPckrAjoutStock = new System.Windows.Forms.DateTimePicker();
            this.numUpDownPrixTarif = new System.Windows.Forms.NumericUpDown();
            this.numUpDownSeuilReap = new System.Windows.Forms.NumericUpDown();
            this.cbBoxCodeCategProduit = new System.Windows.Forms.ComboBox();
            this.cbBoxCodeMarque = new System.Windows.Forms.ComboBox();
            this.lblCodeMarque = new System.Windows.Forms.Label();
            this.txtBoxCodeMarque = new System.Windows.Forms.TextBox();
            this.txtBoxLibelleMarque = new System.Windows.Forms.TextBox();
            this.btnInsertMarque = new System.Windows.Forms.Button();
            this.pctBxImgProduit = new System.Windows.Forms.PictureBox();
            this.txtBoxNoProduit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrixTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSeuilReap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxImgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxCdeCategProduit
            // 
            this.txtBoxCdeCategProduit.Location = new System.Drawing.Point(175, 76);
            this.txtBoxCdeCategProduit.MaxLength = 4;
            this.txtBoxCdeCategProduit.Name = "txtBoxCdeCategProduit";
            this.txtBoxCdeCategProduit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCdeCategProduit.TabIndex = 0;
            this.txtBoxCdeCategProduit.TextChanged += new System.EventHandler(this.txtBoxCdeCategProduit_TextChanged);
            this.txtBoxCdeCategProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCdeCategProduit_KeyPress);
            // 
            // txtBoxLibelleCateg
            // 
            this.txtBoxLibelleCateg.Location = new System.Drawing.Point(175, 114);
            this.txtBoxLibelleCateg.MaxLength = 10;
            this.txtBoxLibelleCateg.Name = "txtBoxLibelleCateg";
            this.txtBoxLibelleCateg.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLibelleCateg.TabIndex = 1;
            // 
            // btnInsertCategorie
            // 
            this.btnInsertCategorie.Location = new System.Drawing.Point(135, 142);
            this.btnInsertCategorie.Name = "btnInsertCategorie";
            this.btnInsertCategorie.Size = new System.Drawing.Size(163, 23);
            this.btnInsertCategorie.TabIndex = 2;
            this.btnInsertCategorie.Text = "Valider l\'ajout de la catégorie";
            this.btnInsertCategorie.UseVisualStyleBackColor = true;
            this.btnInsertCategorie.Click += new System.EventHandler(this.btnInsertCategorie_Click);
            // 
            // txtBoxNomProduit
            // 
            this.txtBoxNomProduit.Location = new System.Drawing.Point(477, 68);
            this.txtBoxNomProduit.MaxLength = 15;
            this.txtBoxNomProduit.Name = "txtBoxNomProduit";
            this.txtBoxNomProduit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomProduit.TabIndex = 5;
            this.txtBoxNomProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNomProduit_KeyPress);
            // 
            // btnAjoutImg
            // 
            this.btnAjoutImg.Location = new System.Drawing.Point(467, 336);
            this.btnAjoutImg.Name = "btnAjoutImg";
            this.btnAjoutImg.Size = new System.Drawing.Size(110, 23);
            this.btnAjoutImg.TabIndex = 9;
            this.btnAjoutImg.Text = "Ajouter une image";
            this.btnAjoutImg.UseVisualStyleBackColor = true;
            this.btnAjoutImg.Click += new System.EventHandler(this.btnAjoutImg_Click);
            // 
            // btnInsertProduit
            // 
            this.btnInsertProduit.Location = new System.Drawing.Point(467, 490);
            this.btnInsertProduit.Name = "btnInsertProduit";
            this.btnInsertProduit.Size = new System.Drawing.Size(138, 23);
            this.btnInsertProduit.TabIndex = 13;
            this.btnInsertProduit.Text = "Valider l\'ajout du produit";
            this.btnInsertProduit.UseVisualStyleBackColor = true;
            this.btnInsertProduit.Click += new System.EventHandler(this.btnInsertProduit_Click);
            // 
            // lblCodeCategProduit
            // 
            this.lblCodeCategProduit.AutoSize = true;
            this.lblCodeCategProduit.Location = new System.Drawing.Point(299, 43);
            this.lblCodeCategProduit.Name = "lblCodeCategProduit";
            this.lblCodeCategProduit.Size = new System.Drawing.Size(155, 13);
            this.lblCodeCategProduit.TabIndex = 15;
            this.lblCodeCategProduit.Text = "Code de la catégorie de produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nom du produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date d\'ajout au stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Prix tarifaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Seuil de réapprovisionnement";
            // 
            // dtPckrAjoutStock
            // 
            this.dtPckrAjoutStock.CustomFormat = "yyyy-MM-dd";
            this.dtPckrAjoutStock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPckrAjoutStock.Location = new System.Drawing.Point(467, 179);
            this.dtPckrAjoutStock.Name = "dtPckrAjoutStock";
            this.dtPckrAjoutStock.Size = new System.Drawing.Size(181, 20);
            this.dtPckrAjoutStock.TabIndex = 21;
            this.dtPckrAjoutStock.Value = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            // 
            // numUpDownPrixTarif
            // 
            this.numUpDownPrixTarif.DecimalPlaces = 2;
            this.numUpDownPrixTarif.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDownPrixTarif.Location = new System.Drawing.Point(467, 219);
            this.numUpDownPrixTarif.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numUpDownPrixTarif.Minimum = new decimal(new int[] {
            299,
            0,
            0,
            131072});
            this.numUpDownPrixTarif.Name = "numUpDownPrixTarif";
            this.numUpDownPrixTarif.Size = new System.Drawing.Size(120, 20);
            this.numUpDownPrixTarif.TabIndex = 7;
            this.numUpDownPrixTarif.Value = new decimal(new int[] {
            299,
            0,
            0,
            131072});
            // 
            // numUpDownSeuilReap
            // 
            this.numUpDownSeuilReap.Location = new System.Drawing.Point(467, 258);
            this.numUpDownSeuilReap.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownSeuilReap.Name = "numUpDownSeuilReap";
            this.numUpDownSeuilReap.Size = new System.Drawing.Size(120, 20);
            this.numUpDownSeuilReap.TabIndex = 8;
            this.numUpDownSeuilReap.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbBoxCodeCategProduit
            // 
            this.cbBoxCodeCategProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCodeCategProduit.FormattingEnabled = true;
            this.cbBoxCodeCategProduit.Location = new System.Drawing.Point(466, 40);
            this.cbBoxCodeCategProduit.Name = "cbBoxCodeCategProduit";
            this.cbBoxCodeCategProduit.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCodeCategProduit.TabIndex = 30;
            // 
            // cbBoxCodeMarque
            // 
            this.cbBoxCodeMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCodeMarque.FormattingEnabled = true;
            this.cbBoxCodeMarque.Location = new System.Drawing.Point(467, 103);
            this.cbBoxCodeMarque.MaxDropDownItems = 10;
            this.cbBoxCodeMarque.MaxLength = 4;
            this.cbBoxCodeMarque.Name = "cbBoxCodeMarque";
            this.cbBoxCodeMarque.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCodeMarque.TabIndex = 31;
            // 
            // lblCodeMarque
            // 
            this.lblCodeMarque.AutoSize = true;
            this.lblCodeMarque.Location = new System.Drawing.Point(344, 103);
            this.lblCodeMarque.Name = "lblCodeMarque";
            this.lblCodeMarque.Size = new System.Drawing.Size(96, 13);
            this.lblCodeMarque.TabIndex = 32;
            this.lblCodeMarque.Text = "Code de la marque";
            // 
            // txtBoxCodeMarque
            // 
            this.txtBoxCodeMarque.Location = new System.Drawing.Point(146, 212);
            this.txtBoxCodeMarque.MaxLength = 4;
            this.txtBoxCodeMarque.Name = "txtBoxCodeMarque";
            this.txtBoxCodeMarque.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodeMarque.TabIndex = 33;
            this.txtBoxCodeMarque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCodeMarque_KeyPress);
            // 
            // txtBoxLibelleMarque
            // 
            this.txtBoxLibelleMarque.Location = new System.Drawing.Point(146, 257);
            this.txtBoxLibelleMarque.MaxLength = 8;
            this.txtBoxLibelleMarque.Name = "txtBoxLibelleMarque";
            this.txtBoxLibelleMarque.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLibelleMarque.TabIndex = 34;
            this.txtBoxLibelleMarque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLibelleMarque_KeyPress);
            // 
            // btnInsertMarque
            // 
            this.btnInsertMarque.Location = new System.Drawing.Point(109, 296);
            this.btnInsertMarque.Name = "btnInsertMarque";
            this.btnInsertMarque.Size = new System.Drawing.Size(166, 23);
            this.btnInsertMarque.TabIndex = 35;
            this.btnInsertMarque.Text = "Valider l\'ajout de la marque";
            this.btnInsertMarque.UseVisualStyleBackColor = true;
            this.btnInsertMarque.Click += new System.EventHandler(this.btnInsertMarque_Click);
            // 
            // pctBxImgProduit
            // 
            this.pctBxImgProduit.InitialImage = null;
            this.pctBxImgProduit.Location = new System.Drawing.Point(248, 346);
            this.pctBxImgProduit.Name = "pctBxImgProduit";
            this.pctBxImgProduit.Size = new System.Drawing.Size(112, 85);
            this.pctBxImgProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBxImgProduit.TabIndex = 29;
            this.pctBxImgProduit.TabStop = false;
            // 
            // txtBoxNoProduit
            // 
            this.txtBoxNoProduit.Location = new System.Drawing.Point(630, 23);
            this.txtBoxNoProduit.Name = "txtBoxNoProduit";
            this.txtBoxNoProduit.ReadOnly = true;
            this.txtBoxNoProduit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNoProduit.TabIndex = 36;
            this.txtBoxNoProduit.Visible = false;
            // 
            // AjoutCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.txtBoxNoProduit);
            this.Controls.Add(this.btnInsertMarque);
            this.Controls.Add(this.txtBoxLibelleMarque);
            this.Controls.Add(this.txtBoxCodeMarque);
            this.Controls.Add(this.lblCodeMarque);
            this.Controls.Add(this.cbBoxCodeMarque);
            this.Controls.Add(this.cbBoxCodeCategProduit);
            this.Controls.Add(this.pctBxImgProduit);
            this.Controls.Add(this.numUpDownSeuilReap);
            this.Controls.Add(this.numUpDownPrixTarif);
            this.Controls.Add(this.dtPckrAjoutStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodeCategProduit);
            this.Controls.Add(this.btnInsertProduit);
            this.Controls.Add(this.btnAjoutImg);
            this.Controls.Add(this.txtBoxNomProduit);
            this.Controls.Add(this.btnInsertCategorie);
            this.Controls.Add(this.txtBoxLibelleCateg);
            this.Controls.Add(this.txtBoxCdeCategProduit);
            this.Name = "AjoutCategorie";
            this.Text = "AjoutCategorie";
            this.Load += new System.EventHandler(this.AjoutCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrixTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSeuilReap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxImgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtBoxNomProduit;
        internal System.Windows.Forms.Button btnAjoutImg;
        internal System.Windows.Forms.Button btnInsertProduit;
        internal System.Windows.Forms.Label lblCodeCategProduit;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DateTimePicker dtPckrAjoutStock;
        internal System.Windows.Forms.NumericUpDown numUpDownPrixTarif;
        internal System.Windows.Forms.NumericUpDown numUpDownSeuilReap;
        internal System.Windows.Forms.PictureBox pctBxImgProduit;
        internal System.Windows.Forms.ComboBox cbBoxCodeCategProduit;
        internal System.Windows.Forms.ComboBox cbBoxCodeMarque;
        internal System.Windows.Forms.Label lblCodeMarque;
        internal System.Windows.Forms.TextBox txtBoxCdeCategProduit;
        internal System.Windows.Forms.TextBox txtBoxLibelleCateg;
        internal System.Windows.Forms.Button btnInsertCategorie;
        internal System.Windows.Forms.TextBox txtBoxCodeMarque;
        internal System.Windows.Forms.TextBox txtBoxLibelleMarque;
        internal System.Windows.Forms.Button btnInsertMarque;
        internal System.Windows.Forms.TextBox txtBoxNoProduit;
    }
}