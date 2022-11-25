using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Win : Form
    {
        Grid grid;
        Graphics g;
        Pen blackPen;
        SolidBrush sBruh;

        public Win()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Start();

            g = mainPanel.CreateGraphics();
            blackPen = new Pen(Color.Black);
            sBruh = new SolidBrush(Color.Black);
            grid = new Grid(mainPanel.Height, mainPanel.Width, 10, g);
            zoomBar.Value = grid.CellSize.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            grid.DrawGrid();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Right:

                    //MessageBox.Show("RIGHT");
                    grid.GoRight();
                    return true;
                case Keys.Left:
                    //MessageBox.Show("LEFT");
                    grid.GoLeft();
                    return true;
                case Keys.Up:
                    grid.GoUp();
                    //MessageBox.Show("UP");
                    return true;
                case Keys.Down:
                    grid.GoDown();
                    //MessageBox.Show("DOWN");
                    return true;
                default: return base.ProcessCmdKey(ref msg, keyData);
            }
        }


        private void panel1_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MouseEventArgs eventSouris = (System.Windows.Forms.MouseEventArgs)e;
            genTextBox.Text = "0";
            grid.Click(eventSouris.X, eventSouris.Y);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            grid.Play();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            grid.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            grid.Reset();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            grid.Update();
        }

        private void genTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(grid.Playing)
            {
                grid.Update();
                grid.Generation++;
                genTextBox.Text = "" + grid.Generation;
            }
        }

        private void refreshRateEntry_TextChanged(object sender, EventArgs e)
        {
            int interval = 1000;
            if(Regex.Match(refreshRateEntry.Text, "^[1-9]{1}[0-9]*$").Success)
            {
                Int32.TryParse(refreshRateEntry.Text, out interval);
                timer1.Interval = interval;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Valeur Invalide");
                timer1.Start();
            }
            
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            grid.Zoom(zoomBar.Value);
            
        }
        
        /*
        private void Win_Resize(object sender, EventArgs e)
        {
            if(grid != null)
            {
                grid.Height += this.Size.Height - this.mainPanel.Height - 150;
                if (grid.Height < 0)
                    grid.Height = 0;

                grid.Graphic = mainPanel.CreateGraphics();
                grid.DrawGrid();
            }
            

            this.mainPanel.Width += this.Size.Width - this.mainPanel.Width - (this.zoomBar.Width + 50);
            this.mainPanel.Height += this.Size.Height - this.mainPanel.Height - 150;
            


            this.zoomBar.Location = new Point(this.mainPanel.Width + 40, 40);
            this.nextButton.Location = new Point(this.nextButton.Location.X, this.mainPanel.Height + 40);
            this.playButton.Location = new Point(this.playButton.Location.X, this.mainPanel.Height + 40);
            this.stopButton.Location = new Point(this.stopButton.Location.X, this.mainPanel.Height + 40);
            this.resetButton.Location = new Point(this.resetButton.Location.X, this.mainPanel.Height + 40);
            this.genStaticLabel.Location = new Point(this.genStaticLabel.Location.X, this.mainPanel.Height + 40);
            this.genTextBox.Location = new Point(this.genTextBox.Location.X, this.mainPanel.Height + 40);
            this.refreshRateLabel.Location = new Point(this.refreshRateLabel.Location.X, this.mainPanel.Height + 40);
            this.refreshRateEntry.Location = new Point(this.refreshRateEntry.Location.X, this.mainPanel.Height + 40);

            
            
        }
        */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented yet");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented yet");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gameOfLifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Devinou971");
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form options = new Options();

            options.Show();
            //options.Modal();

            //Application.Run(new Options());
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
