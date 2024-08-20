namespace PPE2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTxtBoxDateDuJour = new System.Windows.Forms.RichTextBox();
            this.lblTitreMagasin = new System.Windows.Forms.Label();
            this.ScrollBarAccueil = new System.Windows.Forms.VScrollBar();
            this.lienCateg = new System.Windows.Forms.LinkLabel();
            this.lienCrampons = new System.Windows.Forms.LinkLabel();
            this.btnAfficherProduits = new System.Windows.Forms.Button();
            this.pctBxCrampns = new System.Windows.Forms.PictureBox();
            this.pctBoxCategMaillot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxCrampns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCategMaillot)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxtBoxDateDuJour
            // 
            this.richTxtBoxDateDuJour.Location = new System.Drawing.Point(563, -61);
            this.richTxtBoxDateDuJour.Name = "richTxtBoxDateDuJour";
            this.richTxtBoxDateDuJour.Size = new System.Drawing.Size(100, 53);
            this.richTxtBoxDateDuJour.TabIndex = 1;
            this.richTxtBoxDateDuJour.Text = "";
            // 
            // lblTitreMagasin
            // 
            this.lblTitreMagasin.AutoSize = true;
            this.lblTitreMagasin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitreMagasin.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreMagasin.Location = new System.Drawing.Point(280, 9);
            this.lblTitreMagasin.Name = "lblTitreMagasin";
            this.lblTitreMagasin.Size = new System.Drawing.Size(160, 35);
            this.lblTitreMagasin.TabIndex = 7;
            this.lblTitreMagasin.Text = "Zone Sport";
            // 
            // ScrollBarAccueil
            // 
            this.ScrollBarAccueil.Location = new System.Drawing.Point(783, -1);
            this.ScrollBarAccueil.Name = "ScrollBarAccueil";
            this.ScrollBarAccueil.Size = new System.Drawing.Size(17, 453);
            this.ScrollBarAccueil.TabIndex = 9;
            // 
            // lienCateg
            // 
            this.lienCateg.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lienCateg.AutoSize = true;
            this.lienCateg.LinkColor = System.Drawing.Color.Black;
            this.lienCateg.Location = new System.Drawing.Point(46, 55);
            this.lienCateg.Name = "lienCateg";
            this.lienCateg.Size = new System.Drawing.Size(42, 13);
            this.lienCateg.TabIndex = 11;
            this.lienCateg.TabStop = true;
            this.lienCateg.Text = "Maillots";
            // 
            // lienCrampons
            // 
            this.lienCrampons.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lienCrampons.AutoSize = true;
            this.lienCrampons.LinkColor = System.Drawing.Color.Black;
            this.lienCrampons.Location = new System.Drawing.Point(563, 55);
            this.lienCrampons.Name = "lienCrampons";
            this.lienCrampons.Size = new System.Drawing.Size(54, 13);
            this.lienCrampons.TabIndex = 12;
            this.lienCrampons.TabStop = true;
            this.lienCrampons.Text = "Crampons";
            // 
            // btnAfficherProduits
            // 
            this.btnAfficherProduits.Location = new System.Drawing.Point(224, 152);
            this.btnAfficherProduits.Name = "btnAfficherProduits";
            this.btnAfficherProduits.Size = new System.Drawing.Size(216, 41);
            this.btnAfficherProduits.TabIndex = 13;
            this.btnAfficherProduits.Text = "Afficher tous les produits";
            this.btnAfficherProduits.UseVisualStyleBackColor = true;
            // 
            // pctBxCrampns
            // 
            this.pctBxCrampns.Image = global::PPE2.Properties.Resources.imageCrampon;
            this.pctBxCrampns.Location = new System.Drawing.Point(514, 72);
            this.pctBxCrampns.Name = "pctBxCrampns";
            this.pctBxCrampns.Size = new System.Drawing.Size(164, 170);
            this.pctBxCrampns.TabIndex = 10;
            this.pctBxCrampns.TabStop = false;
            // 
            // pctBoxCategMaillot
            // 
            this.pctBoxCategMaillot.Image = global::PPE2.Properties.Resources.imageZidane;
            this.pctBoxCategMaillot.Location = new System.Drawing.Point(12, 72);
            this.pctBoxCategMaillot.Name = "pctBoxCategMaillot";
            this.pctBoxCategMaillot.Size = new System.Drawing.Size(122, 170);
            this.pctBoxCategMaillot.TabIndex = 8;
            this.pctBoxCategMaillot.TabStop = false;
            this.pctBoxCategMaillot.Click += new System.EventHandler(this.pctBoxCategMaillot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficherProduits);
            this.Controls.Add(this.lienCrampons);
            this.Controls.Add(this.lienCateg);
            this.Controls.Add(this.pctBxCrampns);
            this.Controls.Add(this.ScrollBarAccueil);
            this.Controls.Add(this.pctBoxCategMaillot);
            this.Controls.Add(this.lblTitreMagasin);
            this.Controls.Add(this.richTxtBoxDateDuJour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBxCrampns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCategMaillot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTxtBoxDateDuJour;
        private System.Windows.Forms.Label lblTitreMagasin;
        private System.Windows.Forms.PictureBox pctBoxCategMaillot;
        private System.Windows.Forms.VScrollBar ScrollBarAccueil;
        private System.Windows.Forms.PictureBox pctBxCrampns;
        private System.Windows.Forms.LinkLabel lienCateg;
        private System.Windows.Forms.LinkLabel lienCrampons;
        private System.Windows.Forms.Button btnAfficherProduits;
    }
}

