using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{

    class Grid
    {
        private List<Point> cells = new List<Point>();
        private Size cellSize; // 10 px
        private int height;
        private int width;
        private int generation;
        private int nbColumns;
        private int nbRows;

        private const int MINIMUM_CELL_SIZE = 8;

        private bool playing;

        private Graphics graphic;
        private Pen pen;

        private SolidBrush sBrush;
        private SolidBrush eraser;
        private Point displacement; 

        /// <summary>
        /// Basic constructor without any customisations
        /// </summary>
        /// <param name="height"> Total height of tha Panel of the Grid</param>
        /// <param name="width"> Total width of the Panel of the Grid</param>
        /// <param name="cellSize"> Size in pixels of a singular cell, it's a square so it's not a tuple, just a int</param>
        /// <param name="graphics"> It's the Panel's Graphics</param>
        public Grid(int height, int width, int cellSize, Graphics graphics) : this(height, width, cellSize, graphics, Color.Black)
        {
        }

        public Grid(int height, int width, int cellSize, Graphics graphics, Color penColor) : this( height,  width,  cellSize,  graphics,  penColor, Color.White)
        {
        }

        public Grid(int height, int width, int cellSize, Graphics graphics, Color penColor, Color backgroundColor)
        {
            this.Height = height;
            this.Width = width;
            this.CellSize = new Size(cellSize, cellSize);
            this.Generation = 0;
            this.Displacement = new Point(0, 0);

            this.Graphic = graphics;

            this.Pen = new Pen(penColor);

            this.sBrush = new SolidBrush(penColor);
            this.Eraser = new SolidBrush(backgroundColor);

            this.Cells = new List<Point>();
            this.Playing = false;

            this.NbColumns = this.Width / this.CellSize.Width;
            this.NbRows = this.Height / this.CellSize.Height;
        }

        /// <summary>
        /// Creates the grid
        /// </summary>
        public void DrawGrid()
        { 
            this.NbColumns = this.Width / this.CellSize.Width;
            this.NbRows = this.Height / this.CellSize.Height;
            
            this.Graphic.Clear(Color.White);

            if (this.CellSize.Width >= MINIMUM_CELL_SIZE)
            {

                for (int x = 0; x <= nbColumns; x++)
                {
                    this.Graphic.DrawLine(this.Pen, x * this.CellSize.Width + (this.Width - nbColumns * this.CellSize.Width) / 2, 0, x * this.CellSize.Width + (this.Width - nbColumns * this.CellSize.Width) / 2, this.Height);
                }

                for (int x = 0; x <= nbRows; x++)
                {
                    this.Graphic.DrawLine(this.Pen, 0, x * this.CellSize.Height + (this.Height - nbRows * this.CellSize.Height) / 2, this.Width, x * this.CellSize.Height + (this.Height - nbRows * this.CellSize.Height) / 2);
                }
            }

            this.Graphic.DrawRectangle(this.Pen, 0, 0, this.Width - 1, this.Height - 1);
            this.DrawAllCells();
        }

        /// <summary>
        /// Pretty self explanatory : it just draws a cell with the Point given in parameter
        /// </summary>
        /// <param name="cell">This is the top left position of the cell, from this, we will be able to draw the whole cell</param>
        public void DrawCell(Point cell)
        {
            this.Graphic.FillRectangle(this.SBrush, new Rectangle(new Point((cell.X + this.Displacement.X) * this.CellSize.Width + (this.Width - this.NbColumns * this.CellSize.Width) / 2, (cell.Y + this.Displacement.Y) * this.CellSize.Height + (this.Height - this.NbRows * this.CellSize.Height) / 2), this.CellSize));
        }

        /// <summary>
        /// Draws every cell in the grid
        /// </summary>
        public void DrawAllCells()
        {
            foreach (Point cell in this.Cells)
            {
                this.DrawCell(cell);
            }
        }

        /// <summary>
        /// Erases the cell given in parameter
        /// </summary>
        /// <param name="cell">This is the top left position of the cell, from this, we will be able to draw the whole cell</param>
        public void EraseCell(Point cell)
        {
            if (this.CellSize.Width < Grid.MINIMUM_CELL_SIZE)
                this.Graphic.FillRectangle(this.Eraser, new Rectangle(new Point((cell.X + this.Displacement.X) * this.CellSize.Width + (this.Width - this.NbColumns * this.CellSize.Width) / 2, (cell.Y + this.Displacement.Y) * this.CellSize.Height + (this.Height - this.NbRows * this.CellSize.Height) / 2), this.CellSize));
            else
                this.Graphic.FillRectangle(this.Eraser, new Rectangle(new Point((cell.X + this.Displacement.X) * this.CellSize.Width + 1 + (this.Width - this.NbColumns * this.CellSize.Width) / 2, (cell.Y + this.Displacement.Y) * this.CellSize.Height + 1 + (this.Height - this.NbRows * this.CellSize.Height) / 2), new Size(this.CellSize.Width - 1, this.CellSize.Height - 1 )));
            
        }

        /// <summary>
        /// Erases every cells in the grid
        /// </summary>
        public void EraseAllCells()
        {
            foreach (Point cell in this.Cells)
            {
                this.EraseCell(cell);
            }
        }

        /// <summary>
        /// When the user clicks in the grid, it creates or destroys the nearest cell
        /// </summary>
        /// <param name="xMouse"> the X Position of the mouse in the Panel</param>
        /// <param name="yMouse"> The Y Position of the mouse in the Panel</param>
        public void Click(int xMouse, int yMouse)
        {
            //int nbColumns = this.Width / this.CellSize.Width;
            //int nbRows = this.Height / this.CellSize.Height;

            this.Generation = 0;

            int x = 0, y = 0;

            for (int i = 0; i < this.NbColumns + 1; i++)
            {
                if (i * this.CellSize.Width + (this.Width - this.NbColumns * this.CellSize.Width) / 2 <= xMouse && (i + 1) * this.CellSize.Width + (this.Width - this.NbColumns * this.CellSize.Width) / 2 >= xMouse)
                {
                    x = i - this.Displacement.X;
                }
            }

            for (int i = 0; i < this.NbRows + 1; i++)
            {
                if (i * this.CellSize.Height + (this.Height - this.NbRows * this.CellSize.Height) / 2 <= yMouse && (i + 1) * this.CellSize.Height + (this.Height - this.NbRows * this.CellSize.Height) / 2 >= yMouse)
                {
                    y = i - this.Displacement.Y;
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

        /// <summary>
        /// This is where the algorithm does it's magic
        /// </summary>
        public void Update()
        {
            List<Point> newCells = new List<Point>(this.Cells);

            foreach(Point cell in this.Cells)
            {
                int nbNeighbors = this.GetSurrondings(cell);
                if(nbNeighbors > 3)
                {
                    newCells.Remove(cell);
                    this.EraseCell(cell);
                }
                if (nbNeighbors < 2)
                {
                    newCells.Remove(cell);
                    this.EraseCell(cell);
                }

                if(nbNeighbors >= 1 && nbNeighbors <= 7)
                {
                    Point upLeft = new Point(cell.X - 1, cell.Y - 1);
                    Point up = new Point(cell.X, cell.Y - 1);
                    Point upRight = new Point(cell.X + 1, cell.Y - 1);

                    Point left = new Point(cell.X - 1, cell.Y);
                    Point right = new Point(cell.X + 1, cell.Y);

                    Point downLeft = new Point(cell.X - 1, cell.Y + 1);
                    Point down = new Point(cell.X, cell.Y + 1);
                    Point downRight = new Point(cell.X + 1, cell.Y + 1);

                    if( !(newCells.Contains(upLeft)))
                    {
                        if(this.GetSurrondings(upLeft) == 3)
                        {
                            newCells.Add(upLeft);
                            this.DrawCell(upLeft);
                        }
                    }

                    if ( !(newCells.Contains(up)) )
                    {
                        if (this.GetSurrondings(up) == 3)
                        {
                            newCells.Add(up);
                            this.DrawCell(up);
                        }
                    }

                    if ( !(newCells.Contains(upRight)) )
                    {
                        if (this.GetSurrondings(upRight) == 3)
                        {
                            newCells.Add(upRight);
                            this.DrawCell(upRight);
                        }
                    }

                    if ( !(newCells.Contains(left)) )
                    {
                        if (this.GetSurrondings(left) == 3)
                        {
                            newCells.Add(left);
                            this.DrawCell(left);
                        }
                    }

                    if ( !(newCells.Contains(right)) )
                    {
                        if (this.GetSurrondings(right) == 3)
                        {
                            newCells.Add(right);
                            this.DrawCell(right);
                        }
                    }

                    if ( !(newCells.Contains(downLeft)))
                    {
                        if (this.GetSurrondings(downLeft) == 3)
                        {
                            newCells.Add(downLeft);
                            this.DrawCell(downLeft);
                        }
                    }

                    if ( !(newCells.Contains(down)))
                    {
                        if (this.GetSurrondings(down) == 3)
                        {
                            newCells.Add(down);
                            this.DrawCell(down);
                        }
                    }

                    if ( !(newCells.Contains(downRight)) )
                    {
                        if (this.GetSurrondings(downRight) == 3)
                        {
                            newCells.Add(downRight);
                            this.DrawCell(downRight);
                        }
                    }

                }

            }
            this.Cells = new List<Point>(newCells);
        }


        /// <summary>
        /// This method gets the number of surrounding alive cells around a point P
        /// </summary>
        /// <param name="p"> This parameter is actually not always a alive cell, it is just a reference to the center</param>
        /// <returns> This is the number of alive cells around the point p </returns>
        private int GetSurrondings(Point p)
        {
            int nbNeighbors = 0;

            Point upLeft = new Point(p.X - 1, p.Y - 1);
            Point up = new Point(p.X, p.Y - 1);
            Point upRight = new Point(p.X + 1, p.Y - 1);

            Point left = new Point(p.X - 1, p.Y);
            Point right = new Point(p.X + 1, p.Y);

            Point downLeft = new Point(p.X - 1, p.Y + 1);
            Point down = new Point(p.X, p.Y + 1);
            Point downRight = new Point(p.X + 1, p.Y + 1);

            if (this.Cells.Contains(upLeft))
                nbNeighbors++;
            if (this.Cells.Contains(up))
                nbNeighbors++;
            if (this.Cells.Contains(upRight))
                nbNeighbors++;

            if (this.Cells.Contains(left))
                nbNeighbors++;
            if (this.Cells.Contains(right))
                nbNeighbors++;

            if (this.Cells.Contains(downLeft))
                nbNeighbors++;
            if (this.Cells.Contains(down))
                nbNeighbors++;
            if (this.Cells.Contains(downRight))
                nbNeighbors++;

            return nbNeighbors;
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
            this.Displacement = new Point(0, 0);
        }

        public void Zoom(int value)
        {
            this.EraseAllCells();
            this.CellSize = new Size(value, value);
            
            this.DrawGrid();
        }

        public void GoUp()
        {
            this.EraseAllCells();
            this.displacement.Y += 1;
            this.DrawAllCells();

        }
        public void GoDown()
        {
            this.EraseAllCells();
            this.displacement.Y += -1;
            this.DrawAllCells();
        }
        public void GoRight()
        {
            this.EraseAllCells();
            this.displacement.X += -1;
            this.DrawAllCells();
        }
        public void GoLeft()
        {
            this.EraseAllCells();
            this.displacement.X += 1;
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


        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
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

        public Size CellSize
        {
            get
            {
                return this.cellSize;
            }

            set
            {
                this.cellSize = value;
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

        private SolidBrush Eraser
        {
            get
            {
                return this.eraser;
            }

            set
            {
                this.eraser = value;
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

        public Point Displacement
        {
            get
            {
                return this.displacement;
            }

            set
            {
                this.displacement = value;
            }
        }

        
        private int NbColumns
        {
            get
            {
                return this.nbColumns;
            }

            set
            {
                this.nbColumns = value;
            }
        }

        private int NbRows
        {
            get
            {
                return this.nbRows;
            }

            set
            {
                this.nbRows = value;
            }

        }
        
    }
}
