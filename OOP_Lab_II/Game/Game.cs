using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GAME_TEST
{
    class Game
    {
        private gameGrid grid;
        private List<Cell> objects;
        private PictureBox activeBox;
        // Get Set
        public int Rows { get; set; }
        public int Columns { get; set; }
        public List<Cell> Objects { get => objects; }
        // Constructors
        public Game(int row = 9, int col = 9) {
            this.Rows = row; this.Columns = col;
            grid = new gameGrid(row, col); objects = new List<Cell>();
            createObjects();
        }

        //Methods
        public void createObjects()
        {
            randomCells(Rows * 3, new int[] { 2, 3, 4 });
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Cell cell = new Cell(grid[i,j],grid.indexTolocation(i, j), grid.CellSize);
                    setCellsId(cell.box, grid[i, j]);
                    objects.Add(cell);
                }
            }
        }
        private void randomCells(int count, int[] idList)
        {
            Random random = new Random();
            while ((count--) > 0)
            {
                grid[random.Next(Rows), random.Next(Columns)] = idList[random.Next(idList.Length)];
            }
        }
        public void activateBox(object sender, EventArgs e)
        {
            deactivateBox();
            //Activate New Targets
            int r = grid.locationToIndex(((System.Windows.Forms.PictureBox)sender).Location)[0];
            int c = grid.locationToIndex(((System.Windows.Forms.PictureBox)sender).Location)[1];
            for (int i = 1; i <= 3; i++)
            {
                if (grid.isInside(r - i, c) && grid[r - i, c] == 0) //CHECK UPPER
                    setCellsId(objects[(r - i) * Columns + (c)].box, 1);
                if (grid.isInside(r + i, c) && grid[r + i, c] == 0) //CHECK LOWER
                    setCellsId(objects[(r + i) * Columns + (c)].box, 1);
                if (grid.isInside(r, c - i) && grid[r, c - i] == 0) //CHECK LEFT
                    setCellsId(objects[(r) * Columns + (c - i)].box, 1);
                if (grid.isInside(r, c + i) && grid[r, c + i] == 0) //CHECK RIGHT
                    setCellsId(objects[(r) * Columns + (c + i)].box, 1);
            }

            //Activate New Active Box
            activeBox = ((PictureBox)sender); activeBox.BackColor = Color.Cyan; activeBox.Padding = new Padding(3);
        }
        public void deactivateBox()
        {
            //Deactivate Old Targets
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    if (grid[i, j] == 1)
                        setCellsId(objects[i * Columns + j].box, 0);
            //Deactivate Old Active Box
            if (activeBox != null) { activeBox.BackColor = Color.White; activeBox.Padding = new Padding(0); activeBox = null; }
        }
        public async void Move(object sender, EventArgs e)
        {
            int CurrentRow = grid.locationToIndex(activeBox.Location)[0];
            int CurrentCol = grid.locationToIndex(activeBox.Location)[1];
            deactivateBox();
            int TargetRow = grid.locationToIndex(((PictureBox)sender).Location)[0];
            int TargetCol = grid.locationToIndex(((PictureBox)sender).Location)[1];

            string Path = PathFindng(new Point(CurrentRow, CurrentCol), new Point(TargetRow, TargetCol), 0,"");
            //-------
            // Show Steps 
            //
            if(Path!="...error...")
                foreach(char direction in Path)
                {
                    await Task.Delay(200);
                    Cell oldCell = objects[CurrentRow * Columns + CurrentCol];
                    switch (direction)
                    {
                        case 'l': CurrentCol--;break;
                        case 'r': CurrentCol++;break;
                        case 'u': CurrentRow--;break;
                        case 'd': CurrentRow++;break;
                    }
                    objects[CurrentRow * Columns + CurrentCol].id = oldCell.id; // Set New One's Id
                    setCellsId(objects[CurrentRow * Columns + CurrentCol].box, oldCell.id); // Old One to New Position
                    oldCell.id = 0;
                    setCellsId(oldCell.box, 0); // Old Position is Empty
                    await Task.Delay(800);
                }
        }
        private string PathFindng(Point start, Point end, int step, string moves)
        {
            string firstChild="...error...",secondChild= "...error...", thirdChild= "...error...", fourthChild= "...error...";
            if (start == end)   // IF START POSITION AND END POSITION IS EQUAL, WELL DONE YOU ARRIVED
                return moves;   // Return Parents Movement Hıstory
            else if (step < Rows + 1)   // IF STEP COUNT LESS THAN ROW DONT GO ON
            {
                start.Offset(-1, 0);
                if (grid.isEmpty(start.X, start.Y))
                {
                    grid[start.X, start.Y] = 11;    //  Dont Look This Cell, Again
                    firstChild = PathFindng(start, end, step + 1, moves+"u"); // CHECK FIRST CHILD
                    grid[start.X, start.Y] = 0;     // Now You Can Look
                }
                start.Offset(+1, +1);
                if (grid.isEmpty(start.X, start.Y))
                {
                    grid[start.X, start.Y] = 11;
                    secondChild = PathFindng(start, end, step + 1, moves+"r"); // CHECK SECOND CHILD
                    grid[start.X, start.Y] = 0;
                }
                start.Offset(0, -2);
                if (grid.isEmpty(start.X, start.Y))
                {
                    grid[start.X, start.Y] = 11;
                    thirdChild = PathFindng(start, end, step + 1, moves+"l"); //CHECK THIRD CHILD
                    grid[start.X, start.Y] = 0;
                }
                start.Offset(+1, +1);
                if (grid.isEmpty(start.X, start.Y))
                {
                    grid[start.X, start.Y] = 11;
                    fourthChild = PathFindng(start, end, step + 1, moves+"d"); //CHECK FOURTH CHILD
                    grid[start.X, start.Y] = 0;
                }
            }
            //-----
            // Return Shortest Path
            int min=Math.Min(Math.Min(firstChild.Length, secondChild.Length), Math.Min(thirdChild.Length, fourthChild.Length));
            if (min == firstChild.Length) return firstChild;
            if (min == secondChild.Length) return secondChild;
            if (min == thirdChild.Length) return thirdChild;
            else return fourthChild;
        }
        public void setCellsId(PictureBox box, int value)
        {
            grid[grid.locationToIndex(box.Location)[0], grid.locationToIndex(box.Location)[1]] = value;
            box.Image = Texture.texture[value];
            box.Click -= activateBox;
            box.Click -= Move;
            if (value > 1)
                box.Click += new EventHandler(activateBox);
            else if(value==1)
                box.Click += new EventHandler(Move);

            if (value > 0)
                box.Cursor = System.Windows.Forms.Cursors.Hand;
            else
                box.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
    
}




