namespace GameOfLife
{
    partial class Fen
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.genStaticLabel = new System.Windows.Forms.Label();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.refreshRateEntry = new System.Windows.Forms.TextBox();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOfLifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(890, 380);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Click += new System.EventHandler(this.panel1_Click);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(37, 424);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(93, 33);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(162, 424);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(104, 33);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(304, 424);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(84, 33);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(415, 424);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 33);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next Step";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // genStaticLabel
            // 
            this.genStaticLabel.AutoSize = true;
            this.genStaticLabel.Location = new System.Drawing.Point(537, 424);
            this.genStaticLabel.Name = "genStaticLabel";
            this.genStaticLabel.Size = new System.Drawing.Size(33, 13);
            this.genStaticLabel.TabIndex = 5;
            this.genStaticLabel.Text = "Gen :";
            // 
            // genTextBox
            // 
            this.genTextBox.Location = new System.Drawing.Point(573, 424);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(100, 20);
            this.genTextBox.TabIndex = 7;
            this.genTextBox.TextChanged += new System.EventHandler(this.genTextBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.Location = new System.Drawing.Point(693, 424);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(104, 13);
            this.refreshRateLabel.TabIndex = 8;
            this.refreshRateLabel.Text = "Refresh rate (in ms) :";
            // 
            // refreshRateEntry
            // 
            this.refreshRateEntry.Location = new System.Drawing.Point(801, 424);
            this.refreshRateEntry.Name = "refreshRateEntry";
            this.refreshRateEntry.Size = new System.Drawing.Size(100, 20);
            this.refreshRateEntry.TabIndex = 9;
            this.refreshRateEntry.Text = "10";
            this.refreshRateEntry.TextChanged += new System.EventHandler(this.refreshRateEntry_TextChanged);
            // 
            // zoomBar
            // 
            this.zoomBar.LargeChange = 1;
            this.zoomBar.Location = new System.Drawing.Point(917, 24);
            this.zoomBar.Maximum = 25;
            this.zoomBar.Minimum = 5;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomBar.Size = new System.Drawing.Size(45, 377);
            this.zoomBar.TabIndex = 10;
            this.zoomBar.Value = 10;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(965, 24);
            this.menuBar.TabIndex = 11;
            this.menuBar.Text = "menuBar";
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fichiersToolStripMenuItem.Text = "Fichiers";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleursToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // couleursToolStripMenuItem
            // 
            this.couleursToolStripMenuItem.Name = "couleursToolStripMenuItem";
            this.couleursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.couleursToolStripMenuItem.Text = "Couleurs";
            this.couleursToolStripMenuItem.Click += new System.EventHandler(this.couleursToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.gameOfLifeToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.helpToolStripMenuItem.Text = "Aide";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // gameOfLifeToolStripMenuItem
            // 
            this.gameOfLifeToolStripMenuItem.Name = "gameOfLifeToolStripMenuItem";
            this.gameOfLifeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.gameOfLifeToolStripMenuItem.Text = "Game Of Life";
            this.gameOfLifeToolStripMenuItem.Click += new System.EventHandler(this.gameOfLifeToolStripMenuItem_Click);
            // 
            // Fen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 474);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.refreshRateEntry);
            this.Controls.Add(this.refreshRateLabel);
            this.Controls.Add(this.genTextBox);
            this.Controls.Add(this.genStaticLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Fen";
            this.Text = "Game Of Life";
            this.Resize += new System.EventHandler(this.Fen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label genStaticLabel;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label refreshRateLabel;
        private System.Windows.Forms.TextBox refreshRateEntry;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameOfLifeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleursToolStripMenuItem;
    }
}

