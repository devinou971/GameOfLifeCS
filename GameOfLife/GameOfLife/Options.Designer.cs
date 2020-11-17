namespace GameOfLife
{
    partial class Options
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
            this.lCouleurFond = new System.Windows.Forms.Label();
            this.couleurFond = new System.Windows.Forms.ColorDialog();
            this.lCouleurGrille = new System.Windows.Forms.Label();
            this.lCouleurCellules = new System.Windows.Forms.Label();
            this.couleurGrille = new System.Windows.Forms.ColorDialog();
            this.couleurCellules = new System.Windows.Forms.ColorDialog();
            this.pCouleurFond = new System.Windows.Forms.Panel();
            this.pCouleurGrille = new System.Windows.Forms.Panel();
            this.pCouleurCellules = new System.Windows.Forms.Panel();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bAppliquer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCouleurFond
            // 
            this.lCouleurFond.AutoSize = true;
            this.lCouleurFond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCouleurFond.Location = new System.Drawing.Point(42, 48);
            this.lCouleurFond.Name = "lCouleurFond";
            this.lCouleurFond.Size = new System.Drawing.Size(109, 17);
            this.lCouleurFond.TabIndex = 0;
            this.lCouleurFond.Text = "Couleur de fond";
            // 
            // lCouleurGrille
            // 
            this.lCouleurGrille.AutoSize = true;
            this.lCouleurGrille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCouleurGrille.Location = new System.Drawing.Point(42, 99);
            this.lCouleurGrille.Name = "lCouleurGrille";
            this.lCouleurGrille.Size = new System.Drawing.Size(126, 17);
            this.lCouleurGrille.TabIndex = 1;
            this.lCouleurGrille.Text = "Couleur de la grille";
            // 
            // lCouleurCellules
            // 
            this.lCouleurCellules.AutoSize = true;
            this.lCouleurCellules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCouleurCellules.Location = new System.Drawing.Point(42, 144);
            this.lCouleurCellules.Name = "lCouleurCellules";
            this.lCouleurCellules.Size = new System.Drawing.Size(135, 17);
            this.lCouleurCellules.TabIndex = 2;
            this.lCouleurCellules.Text = "Couleur des cellules";
            // 
            // pCouleurFond
            // 
            this.pCouleurFond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCouleurFond.Location = new System.Drawing.Point(195, 48);
            this.pCouleurFond.Name = "pCouleurFond";
            this.pCouleurFond.Size = new System.Drawing.Size(58, 27);
            this.pCouleurFond.TabIndex = 3;
            this.pCouleurFond.Click += new System.EventHandler(this.pCouleurFond_Click);
            // 
            // pCouleurGrille
            // 
            this.pCouleurGrille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCouleurGrille.Location = new System.Drawing.Point(195, 99);
            this.pCouleurGrille.Name = "pCouleurGrille";
            this.pCouleurGrille.Size = new System.Drawing.Size(58, 27);
            this.pCouleurGrille.TabIndex = 4;
            this.pCouleurGrille.Click += new System.EventHandler(this.pCouleurGrille_Click);
            // 
            // pCouleurCellules
            // 
            this.pCouleurCellules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCouleurCellules.Location = new System.Drawing.Point(195, 144);
            this.pCouleurCellules.Name = "pCouleurCellules";
            this.pCouleurCellules.Size = new System.Drawing.Size(58, 27);
            this.pCouleurCellules.TabIndex = 5;
            this.pCouleurCellules.Click += new System.EventHandler(this.pCouleurCellules_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(131, 194);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(99, 37);
            this.bEnregistrer.TabIndex = 6;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            // 
            // bAppliquer
            // 
            this.bAppliquer.Location = new System.Drawing.Point(252, 194);
            this.bAppliquer.Name = "bAppliquer";
            this.bAppliquer.Size = new System.Drawing.Size(86, 37);
            this.bAppliquer.TabIndex = 7;
            this.bAppliquer.Text = "Appliquer";
            this.bAppliquer.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 243);
            this.Controls.Add(this.bAppliquer);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.pCouleurCellules);
            this.Controls.Add(this.pCouleurGrille);
            this.Controls.Add(this.pCouleurFond);
            this.Controls.Add(this.lCouleurCellules);
            this.Controls.Add(this.lCouleurGrille);
            this.Controls.Add(this.lCouleurFond);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCouleurFond;
        private System.Windows.Forms.ColorDialog couleurFond;
        private System.Windows.Forms.Label lCouleurGrille;
        private System.Windows.Forms.Label lCouleurCellules;
        private System.Windows.Forms.ColorDialog couleurGrille;
        private System.Windows.Forms.ColorDialog couleurCellules;
        private System.Windows.Forms.Panel pCouleurFond;
        private System.Windows.Forms.Panel pCouleurGrille;
        private System.Windows.Forms.Panel pCouleurCellules;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bAppliquer;
    }
}