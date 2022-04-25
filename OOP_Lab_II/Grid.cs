using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace GAME_TEST
{
    class gameGrid
    {
        private int[,] matrix;
        private int cellSize;
        private Point startPoint;   // Start Location of Grid
        // Get Set
        public int CellSize { get => cellSize; }
        public int Row { get; }
        public int Column { get; }
        public int this[int row,int col] { get => matrix[row, col]; set => matrix[row, col] = value; }

        // Costructor
        public gameGrid(int x,int y) { 
            matrix = new int[x, y]; 
            Row = x; Column = y;
            cellSize = Screen.PrimaryScreen.Bounds.Height * 4 / 5 / Column;
            startPoint = new Point((Screen.PrimaryScreen.Bounds.Width - Column * cellSize) / 2, (Screen.PrimaryScreen.Bounds.Height - Row * cellSize) * 3 / 4);
            createEmptyGrid();
        }

        //Methods
        public bool isInside(int row,int col) { return row < Row && row >= 0 && col < Column && col >= 0; }
        public bool isEmpty(int row,int col) {
            if (isInside(row, col))
                return matrix[row, col] == 0;
            return false;
                    }
        public Point indexTolocation(int row,int col) { return new Point(startPoint.X + col * cellSize, startPoint.Y + row * cellSize); }
        public int[] locationToIndex(Point loc) { return new int[]{(loc.Y-startPoint.Y)/cellSize,(loc.X - startPoint.X) / cellSize}; }

        public void createEmptyGrid()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    matrix[i,j] = 0;
                }
            }
        }
       
    }
}
