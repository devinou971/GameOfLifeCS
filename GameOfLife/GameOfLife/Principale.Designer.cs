namespace GameOfLife
{
    partial class Win
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
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOfLifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1187, 468);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Click += new System.EventHandler(this.panel1_Click);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(49, 522);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(124, 41);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(216, 522);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(139, 41);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(405, 522);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 41);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(553, 522);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(133, 41);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next Step";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // genStaticLabel
            // 
            this.genStaticLabel.AutoSize = true;
            this.genStaticLabel.Location = new System.Drawing.Point(716, 522);
            this.genStaticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genStaticLabel.Name = "genStaticLabel";
            this.genStaticLabel.Size = new System.Drawing.Size(43, 17);
            this.genStaticLabel.TabIndex = 5;
            this.genStaticLabel.Text = "Gen :";
            // 
            // genTextBox
            // 
            this.genTextBox.Location = new System.Drawing.Point(764, 522);
            this.genTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(132, 22);
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
            this.refreshRateLabel.Location = new System.Drawing.Point(924, 522);
            this.refreshRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(142, 17);
            this.refreshRateLabel.TabIndex = 8;
            this.refreshRateLabel.Text = "Refresh rate (in ms) :";
            // 
            // refreshRateEntry
            // 
            this.refreshRateEntry.Location = new System.Drawing.Point(1068, 522);
            this.refreshRateEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshRateEntry.Name = "refreshRateEntry";
            this.refreshRateEntry.Size = new System.Drawing.Size(132, 22);
            this.refreshRateEntry.TabIndex = 9;
            this.refreshRateEntry.Text = "10";
            this.refreshRateEntry.TextChanged += new System.EventHandler(this.refreshRateEntry_TextChanged);
            // 
            // zoomBar
            // 
            this.zoomBar.LargeChange = 1;
            this.zoomBar.Location = new System.Drawing.Point(1223, 30);
            this.zoomBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zoomBar.Maximum = 25;
            this.zoomBar.Minimum = 5;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomBar.Size = new System.Drawing.Size(56, 464);
            this.zoomBar.TabIndex = 10;
            this.zoomBar.Value = 10;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1287, 28);
            this.menuBar.TabIndex = 11;
            this.menuBar.Text = "menuBar";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.gameOfLifeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // gameOfLifeToolStripMenuItem
            // 
            this.gameOfLifeToolStripMenuItem.Name = "gameOfLifeToolStripMenuItem";
            this.gameOfLifeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gameOfLifeToolStripMenuItem.Text = "Game Of Life";
            this.gameOfLifeToolStripMenuItem.Click += new System.EventHandler(this.gameOfLifeToolStripMenuItem_Click);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 583);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fen";
            this.Text = "Game Of Life";
            //this.Resize += new System.EventHandler(this.Win_Resize);
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
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameOfLifeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
    }
}

