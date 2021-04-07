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
            this.lBackgroundColor = new System.Windows.Forms.Label();
            this.couleurFond = new System.Windows.Forms.ColorDialog();
            this.lGridColor = new System.Windows.Forms.Label();
            this.lCellColor = new System.Windows.Forms.Label();
            this.couleurGrille = new System.Windows.Forms.ColorDialog();
            this.couleurCellules = new System.Windows.Forms.ColorDialog();
            this.pBackgroundColor = new System.Windows.Forms.Panel();
            this.pGridColor = new System.Windows.Forms.Panel();
            this.pCellColor = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBackgroundColor
            // 
            this.lBackgroundColor.AutoSize = true;
            this.lBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBackgroundColor.Location = new System.Drawing.Point(56, 59);
            this.lBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBackgroundColor.Name = "lBackgroundColor";
            this.lBackgroundColor.Size = new System.Drawing.Size(143, 20);
            this.lBackgroundColor.TabIndex = 0;
            this.lBackgroundColor.Text = "Background Color";
            // 
            // lGridColor
            // 
            this.lGridColor.AutoSize = true;
            this.lGridColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGridColor.Location = new System.Drawing.Point(56, 122);
            this.lGridColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGridColor.Name = "lGridColor";
            this.lGridColor.Size = new System.Drawing.Size(83, 20);
            this.lGridColor.TabIndex = 1;
            this.lGridColor.Text = "Grid color";
            // 
            // lCellColor
            // 
            this.lCellColor.AutoSize = true;
            this.lCellColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCellColor.Location = new System.Drawing.Point(56, 177);
            this.lCellColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCellColor.Name = "lCellColor";
            this.lCellColor.Size = new System.Drawing.Size(80, 20);
            this.lCellColor.TabIndex = 2;
            this.lCellColor.Text = "Cell color";
            // 
            // pBackgroundColor
            // 
            this.pBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBackgroundColor.Location = new System.Drawing.Point(260, 59);
            this.pBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBackgroundColor.Name = "pBackgroundColor";
            this.pBackgroundColor.Size = new System.Drawing.Size(77, 33);
            this.pBackgroundColor.TabIndex = 3;
            this.pBackgroundColor.Click += new System.EventHandler(this.pCouleurFond_Click);
            // 
            // pGridColor
            // 
            this.pGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGridColor.Location = new System.Drawing.Point(260, 122);
            this.pGridColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pGridColor.Name = "pGridColor";
            this.pGridColor.Size = new System.Drawing.Size(77, 33);
            this.pGridColor.TabIndex = 4;
            this.pGridColor.Click += new System.EventHandler(this.pCouleurGrille_Click);
            // 
            // pCellColor
            // 
            this.pCellColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCellColor.Location = new System.Drawing.Point(260, 177);
            this.pCellColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pCellColor.Name = "pCellColor";
            this.pCellColor.Size = new System.Drawing.Size(77, 33);
            this.pCellColor.TabIndex = 5;
            this.pCellColor.Click += new System.EventHandler(this.pCouleurCellules_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(175, 239);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(132, 46);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(336, 239);
            this.bApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(115, 46);
            this.bApply.TabIndex = 7;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 299);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.pCellColor);
            this.Controls.Add(this.pGridColor);
            this.Controls.Add(this.pBackgroundColor);
            this.Controls.Add(this.lCellColor);
            this.Controls.Add(this.lGridColor);
            this.Controls.Add(this.lBackgroundColor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBackgroundColor;
        private System.Windows.Forms.ColorDialog couleurFond;
        private System.Windows.Forms.Label lGridColor;
        private System.Windows.Forms.Label lCellColor;
        private System.Windows.Forms.ColorDialog couleurGrille;
        private System.Windows.Forms.ColorDialog couleurCellules;
        private System.Windows.Forms.Panel pBackgroundColor;
        private System.Windows.Forms.Panel pGridColor;
        private System.Windows.Forms.Panel pCellColor;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bApply;
    }
}