using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{

    class Grille
    {
        private List<Point> cells = new List<Point>();
        private Size tailleCellule; // 10 px
        private int hauteur;
        private int largeur;
        private int generation;
        private int nbColonnes;
        private int nbLignes;

        private const int TAILLE_CELLULE_MINIMUM = 8;

        private bool playing;

        private Graphics graphic;
        private Pen pen;

        private SolidBrush sBrush;
        private SolidBrush gomme;
        private Point deplacement; 

        /// <summary>
        /// Contructeur de Base, celui que l'on utilise sans aucune personnalisation
        /// </summary>
        /// <param name="hauteur"> Permet de connaitre la hauteur total du Panel qui acceuil la grille</param>
        /// <param name="largeur"> Permet de connaitre la largeur total du Panel qui acceuil la grille</param>
        /// <param name="tailleCellule"> Coorespond à la taille en pixel de chaque cellule</param>
        /// <param name="graphics"> Correspond au graphics du Panel</param>
        public Grille(int hauteur, int largeur, int tailleCellule, Graphics graphics) : this(hauteur, largeur, tailleCellule, graphics, Color.Black)
        {
        }

        public Grille(int hauteur, int largeur, int tailleCellule, Graphics graphics, Color couleurStylo) : this( hauteur,  largeur,  tailleCellule,  graphics,  couleurStylo, Color.White)
        {
        }

        public Grille(int hauteur, int largeur, int tailleCellule, Graphics graphics, Color couleurStylo, Color couleurFond)
        {
            this.Hauteur = hauteur;
            this.Largeur = largeur;
            this.TailleCellule = new Size(tailleCellule, tailleCellule);
            this.Generation = 0;
            this.Deplacement = new Point(0, 0);

            this.Graphic = graphics;

            this.Pen = new Pen(couleurStylo);

            this.sBrush = new SolidBrush(couleurStylo);
            this.Gomme = new SolidBrush(couleurFond);

            this.Cells = new List<Point>();
            this.Playing = false;

            this.NbColonnes = this.Largeur / this.TailleCellule.Width;
            this.NbLignes = this.Hauteur / this.TailleCellule.Height;
        }

        /// <summary>
        /// Permet uniquement de générer la grille au début de la fenetre   
        /// </summary>
        public void DrawGrid()
        { 
            this.NbColonnes = this.Largeur / this.TailleCellule.Width;
            this.NbLignes = this.Hauteur / this.TailleCellule.Height;
            
            this.Graphic.Clear(Color.White);

            if (this.TailleCellule.Width >= TAILLE_CELLULE_MINIMUM)
            {

                for (int x = 0; x <= nbColonnes; x++)
                {
                    this.Graphic.DrawLine(this.Pen, x * this.TailleCellule.Width + (this.Largeur - nbColonnes * this.TailleCellule.Width) / 2, 0, x * this.TailleCellule.Width + (this.Largeur - nbColonnes * this.TailleCellule.Width) / 2, this.Hauteur);
                }

                for (int x = 0; x <= nbLignes; x++)
                {
                    this.Graphic.DrawLine(this.Pen, 0, x * this.TailleCellule.Height + (this.Hauteur - nbLignes * this.TailleCellule.Height) / 2, this.Largeur, x * this.TailleCellule.Height + (this.Hauteur - nbLignes * this.TailleCellule.Height) / 2);
                }
            }

            this.Graphic.DrawRectangle(this.Pen, 0, 0, this.Largeur - 1, this.Hauteur - 1);
            this.DrawAllCells();
        }

        public void DrawCell(Point cell)
        {
            this.Graphic.FillRectangle(this.SBrush, new Rectangle(new Point((cell.X + this.Deplacement.X) * this.TailleCellule.Width + (this.Largeur - this.NbColonnes * this.TailleCellule.Width) / 2, (cell.Y + this.Deplacement.Y) * this.TailleCellule.Height + (this.Hauteur - this.NbLignes * this.TailleCellule.Height) / 2), this.TailleCellule));
        }

        public void DrawAllCells()
        {
            //MessageBox.Show("Draw All Cells");
            foreach (Point cell in this.Cells)
            {
                this.DrawCell(cell);
            }
        }

        public void EraseCell(Point cell)
        {
            if (this.TailleCellule.Width < Grille.TAILLE_CELLULE_MINIMUM)
                this.Graphic.FillRectangle(this.Gomme, new Rectangle(new Point((cell.X + this.Deplacement.X) * this.TailleCellule.Width + (this.Largeur - this.NbColonnes * this.TailleCellule.Width) / 2, (cell.Y + this.Deplacement.Y) * this.TailleCellule.Height + (this.Hauteur - this.NbLignes * this.TailleCellule.Height) / 2), this.TailleCellule));
            else
                this.Graphic.FillRectangle(this.Gomme, new Rectangle(new Point((cell.X + this.Deplacement.X) * this.TailleCellule.Width + 1 + (this.Largeur - this.NbColonnes * this.TailleCellule.Width) / 2, (cell.Y + this.Deplacement.Y) * this.TailleCellule.Height + 1 + (this.Hauteur - this.NbLignes * this.TailleCellule.Height) / 2), new Size(this.TailleCellule.Width - 1, this.TailleCellule.Height - 1 )));
            
        }

        public void EraseAllCells()
        {
            foreach (Point cell in this.Cells)
            {
                this.EraseCell(cell);
            }
        }

        public void Click(int xMouse, int yMouse)
        {
            //MessageBox.Show(xMouse + " " + yMouse);
            //int nbColonnes = this.Largeur / this.TailleCellule.Width;
            //int nbLignes = this.Hauteur / this.TailleCellule.Height;

            this.Generation = 0;

            int x = 0, y = 0;

            for (int i = 0; i < this.NbColonnes + 1; i++) // On prend la position x en fonction de la grille
            {
                if (i * this.TailleCellule.Width + (this.Largeur - this.NbColonnes * this.TailleCellule.Width) / 2 <= xMouse && (i + 1) * this.TailleCellule.Width + (this.Largeur - this.NbColonnes * this.TailleCellule.Width) / 2 >= xMouse)
                {
                    x = i - this.Deplacement.X;
                }
            }

            for (int i = 0; i < this.NbLignes + 1; i++) // On prend la position y en fonction de la grille
            {
                if (i * this.TailleCellule.Height + (this.Hauteur - this.NbLignes * this.TailleCellule.Height) / 2 <= yMouse && (i + 1) * this.TailleCellule.Height + (this.Hauteur - this.NbLignes * this.TailleCellule.Height) / 2 >= yMouse)
                {
                    y = i - this.Deplacement.Y;
                }
            }

            Point cell = new Point(x, y);
            if (this.Cells.Contains(cell))
            {
                this.Cells.Remove(cell);
                this.EraseCell(cell);
                
            }
            else
            {
                this.Cells.Add(cell);
                this.DrawCell(cell);
            }
           
        }

        public void Update()
        {
            List<Point> newCells = new List<Point>(this.Cells);

            foreach(Point cell in this.Cells)
            {
                int nbVoisins = this.GetSurrondings(cell);
                if(nbVoisins > 3)
                {
                    newCells.Remove(cell);
                    this.EraseCell(cell);
                }
                if (nbVoisins < 2)
                {
                    newCells.Remove(cell);
                    this.EraseCell(cell);
                }

                if(nbVoisins >= 1 && nbVoisins <= 7)
                {
                    Point hautGauche = new Point(cell.X - 1, cell.Y - 1);
                    Point haut = new Point(cell.X, cell.Y - 1);
                    Point hautDroite = new Point(cell.X + 1, cell.Y - 1);

                    Point gauche = new Point(cell.X - 1, cell.Y);
                    Point droite = new Point(cell.X + 1, cell.Y);

                    Point basGauche = new Point(cell.X - 1, cell.Y + 1);
                    Point bas = new Point(cell.X, cell.Y + 1);
                    Point basDroite = new Point(cell.X + 1, cell.Y + 1);

                    if( !(newCells.Contains(hautGauche)))
                    {
                        if(this.GetSurrondings(hautGauche) == 3)
                        {
                            newCells.Add(hautGauche);
                            this.DrawCell(hautGauche);
                        }
                    }

                    if ( !(newCells.Contains(haut)) )
                    {
                        if (this.GetSurrondings(haut) == 3)
                        {
                            newCells.Add(haut);
                            this.DrawCell(haut);
                        }
                    }

                    if ( !(newCells.Contains(hautDroite)) )
                    {
                        if (this.GetSurrondings(hautDroite) == 3)
                        {
                            newCells.Add(hautDroite);
                            this.DrawCell(hautDroite);
                        }
                    }

                    if ( !(newCells.Contains(gauche)) )
                    {
                        if (this.GetSurrondings(gauche) == 3)
                        {
                            newCells.Add(gauche);
                            this.DrawCell(gauche);
                        }
                    }

                    if ( !(newCells.Contains(droite)) )
                    {
                        if (this.GetSurrondings(droite) == 3)
                        {
                            newCells.Add(droite);
                            this.DrawCell(droite);
                        }
                    }

                    if ( !(newCells.Contains(basGauche)))
                    {
                        if (this.GetSurrondings(basGauche) == 3)
                        {
                            newCells.Add(basGauche);
                            this.DrawCell(basGauche);
                        }
                    }

                    if ( !(newCells.Contains(bas)))
                    {
                        if (this.GetSurrondings(bas) == 3)
                        {
                            newCells.Add(bas);
                            this.DrawCell(bas);
                        }
                    }

                    if ( !(newCells.Contains(basDroite)) )
                    {
                        if (this.GetSurrondings(basDroite) == 3)
                        {
                            newCells.Add(basDroite);
                            this.DrawCell(basDroite);
                        }
                    }

                }

            }
            this.Cells = new List<Point>(newCells);
        }

        private int GetSurrondings(Point p)
        {
            int nbVoisins = 0;

            Point hautGauche = new Point(p.X - 1, p.Y - 1);
            Point haut = new Point(p.X, p.Y - 1);
            Point hautDroite = new Point(p.X + 1, p.Y - 1);

            Point gauche = new Point(p.X - 1, p.Y);
            Point droite = new Point(p.X + 1, p.Y);

            Point basGauche = new Point(p.X - 1, p.Y + 1);
            Point bas = new Point(p.X, p.Y + 1);
            Point basDroite = new Point(p.X + 1, p.Y + 1);

            if (this.Cells.Contains(hautGauche))
                nbVoisins++;
            if (this.Cells.Contains(haut))
                nbVoisins++;
            if (this.Cells.Contains(hautDroite))
                nbVoisins++;

            if (this.Cells.Contains(gauche))
                nbVoisins++;
            if (this.Cells.Contains(droite))
                nbVoisins++;

            if (this.Cells.Contains(basGauche))
                nbVoisins++;
            if (this.Cells.Contains(bas))
                nbVoisins++;
            if (this.Cells.Contains(basDroite))
                nbVoisins++;

            return nbVoisins;
        }

        public void Play()
        {
            this.Playing = true;
        }

        public void Stop()
        {
            this.Playing = false;
        }

        public void Reset()
        {
            this.EraseAllCells();
            this.Cells = new List<Point>();
            this.Deplacement = new Point(0, 0);
        }

        public void Zoom(int value)
        {
            this.EraseAllCells();
            this.TailleCellule = new Size(value, value);
            
            this.DrawGrid();
        }

        public void GoUp()
        {
            this.EraseAllCells();
            this.deplacement.Y += 1;
            this.DrawAllCells();

        }
        public void GoDown()
        {
            this.EraseAllCells();
            this.deplacement.Y += -1;
            this.DrawAllCells();
        }
        public void GoRight()
        {
            this.EraseAllCells();
            this.deplacement.X += -1;
            this.DrawAllCells();
        }
        public void GoLeft()
        {
            this.EraseAllCells();
            this.deplacement.X += 1;
            this.DrawAllCells();
        }

        public List<Point> Cells
        {
            get
            {
                return this.cells;
            }

            set
            {
                this.cells = value;
            }
        }


        public int Hauteur
        {
            get
            {
                return this.hauteur;
            }

            set
            {
                this.hauteur = value;
            }
        }

        public int Largeur
        {
            get
            {
                return this.largeur;
            }

            set
            {
                this.largeur = value;
            }
        }

        

        public Graphics Graphic
        {
            get
            {
                return this.graphic;
            }

            set
            {
                this.graphic = value;
            }
        }

        private Pen Pen
        {
            get
            {
                return this.pen;
            }

            set
            {
                this.pen = value;
            }
        }

        private SolidBrush SBrush
        {
            get
            {
                return this.sBrush;
            }

            set
            {
                this.sBrush = value;
            }
        }

        public Size TailleCellule
        {
            get
            {
                return this.tailleCellule;
            }

            set
            {
                this.tailleCellule = value;
            }
        }

        public bool Playing
        {
            get
            {
                return this.playing;
            }

            set
            {
                this.playing = value;
            }
        }

        private SolidBrush Gomme
        {
            get
            {
                return this.gomme;
            }

            set
            {
                this.gomme = value;
            }
        }

        public int Generation
        {
            get
            {
                return this.generation;
            }

            set
            {
                this.generation = value;
            }
        }

        public Point Deplacement
        {
            get
            {
                return this.deplacement;
            }

            set
            {
                this.deplacement = value;
            }
        }

        
        private int NbColonnes
        {
            get
            {
                return this.nbColonnes;
            }

            set
            {
                this.nbColonnes = value;
            }
        }

        private int NbLignes
        {
            get
            {
                return this.nbLignes;
            }

            set
            {
                this.nbLignes = value;
            }

        }
        
    }
}
