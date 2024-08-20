namespace PPE2
{
    partial class FormModifProduit
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
            this.dtGridViewModif = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewModif)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewModif
            // 
            this.dtGridViewModif.AllowUserToDeleteRows = false;
            this.dtGridViewModif.AllowUserToResizeColumns = false;
            this.dtGridViewModif.AllowUserToResizeRows = false;
            this.dtGridViewModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewModif.Location = new System.Drawing.Point(162, 66);
            this.dtGridViewModif.Name = "dtGridViewModif";
            this.dtGridViewModif.Size = new System.Drawing.Size(418, 233);
            this.dtGridViewModif.TabIndex = 0;
            // 
            // FormModifProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridViewModif);
            this.Name = "FormModifProduit";
            this.Text = "FormModifProduit";
            this.Load += new System.EventHandler(this.FormModifProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewModif;
    }
}