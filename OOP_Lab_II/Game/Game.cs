using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace OOP_Lab_II.Game
{
    class Game
    {
        const int NumberOfSameCellsToWin = 5;
        const int NumberOfRandomCell = 3;
        const int scoreCoef=10;
        int[] CellsPossibleIds = new int[]{2,3,4};
        
        private gameGrid grid;
        private List<Cell> objects;
        private PictureBox activeBox;
        public TextBox ScoreBoard { get; }
        int score;
        // Get Set
        public int Rows { get; set; }
        public int Columns { get; set; }
        public List<Cell> Objects { get => objects; }
        // Constructors
        public Game(int row = 9, int col = 9) {
            this.Rows = row; this.Columns = col;
            grid = new gameGrid(row, col); objects = new List<Cell>(); ScoreBoard = new TextBox();
            ScoreBoard.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2-80, 30);
            ScoreBoard.Size = new Size(160,ScoreBoard.Size.Height);
            ScoreBoard.Font = new Font(FontFamily.GenericSansSerif, 25,FontStyle.Bold);
            ScoreBoard.ReadOnly = true;ScoreBoard.TextAlign = HorizontalAlignment.Center;
            updateScore(0);
            createObjects();
        }

        //Methods
        private void createRandomCells(int count, int[] idList)
        {
            Random random = new Random();
            while ((count--) > 0)
            {
                if (grid.isFull())
                    break;
                int r= random.Next(Rows), c = random.Next(Columns);
                if(grid[r, c]!=0)
                {
                    count++;
                    continue;
                }
                int id = idList[random.Next(idList.Length)];
                Change_Cells_ID(objects[r * Columns + c].box,id);
                checkBingo(NumberOfSameCellsToWin, r, c, id);
            }
        }
        private void createObjects()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Cell cell = new Cell(grid[i,j],grid.indexTolocation(i, j), grid.CellSize);
                    objects.Add(cell);
                    Change_Cells_ID(cell.box, grid[i, j]);
                }
            }
            createRandomCells(NumberOfRandomCell, CellsPossibleIds);
        }
        private void Change_Cells_ID(PictureBox box, int value)
        {

            grid[grid.locationToIndex(box.Location)[0], grid.locationToIndex(box.Location)[1]] = value;
            objects[grid.locationToIndex(box.Location)[0] * Columns + grid.locationToIndex(box.Location)[1]].id = value;
            box.Image = Texture.texture[value];
            box.Click -= ClickCell;
            box.Click -= ClickMove;
            if (value > 1)
                box.Click += new EventHandler(ClickCell);
            else if(value==1)
                box.Click += new EventHandler(ClickMove);

            if (value > 0)
                box.Cursor = System.Windows.Forms.Cursors.Hand;
            else
                box.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void deactivateBox()
        {
            //Deactivate Old Targets
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    if (grid[i, j] == 1)
                        Change_Cells_ID(objects[i * Columns + j].box, 0);
            //Deactivate Old Active Box
            if (activeBox != null) { activeBox.BackColor = Color.White; activeBox.Padding = new Padding(0); activeBox = null; }
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
        private bool checkBingo(int sideCount,int row,int col,int CenterID)
        {
            int VerticalCounter = 1, HorizantalCounter = 1;
            bool up = true, down = true, left = true, right = true;
            for(int i=1;i<sideCount;i++)
            {
                if (up && grid[row - i, col] == CenterID) HorizantalCounter++;
                else up = false;
                if (down && grid[row + i, col] == CenterID) HorizantalCounter++;
                else down = false;
                if (left && grid[row, col - i] == CenterID) VerticalCounter++;
                else left = false;
                if (right && grid[row, col + i] == CenterID) VerticalCounter++;
                else right = false;
            }
            if (VerticalCounter >= sideCount || HorizantalCounter >= sideCount)
            {
                wait(700);
                updateScore(scoreCoef);
            }
            if(VerticalCounter>=sideCount)
                for (int i = -sideCount + 1; i <= sideCount - 1; i++)
                    if (grid[row, col + i] == CenterID)
                    {
                        grid[row, col + i] = 0;
                        this.Change_Cells_ID(objects[row * Columns + col + i].box, 0);
                    }
            if (HorizantalCounter >= sideCount)
                for (int i = -sideCount + 1; i <= sideCount - 1; i++)
                    if (grid[row+i, col] == CenterID)
                    {
                        grid[row+i, col] = 0;
                        this.Change_Cells_ID(objects[(row+i) * Columns + col].box, 0);
                    }
            return VerticalCounter >= sideCount || HorizantalCounter >= sideCount;
        }

        public void ClickCell(object sender, EventArgs e)
        {
            deactivateBox();
            //Activate New Targets
            int r = grid.locationToIndex(((System.Windows.Forms.PictureBox)sender).Location)[0];
            int c = grid.locationToIndex(((System.Windows.Forms.PictureBox)sender).Location)[1];
            for (int i = 1; i <= 3; i++)
            {
                if (grid.isInside(r - i, c) && grid[r - i, c] == 0) //CHECK UPPER
                    Change_Cells_ID(objects[(r - i) * Columns + (c)].box, 1);
                if (grid.isInside(r + i, c) && grid[r + i, c] == 0) //CHECK LOWER
                    Change_Cells_ID(objects[(r + i) * Columns + (c)].box, 1);
                if (grid.isInside(r, c - i) && grid[r, c - i] == 0) //CHECK LEFT
                    Change_Cells_ID(objects[(r) * Columns + (c - i)].box, 1);
                if (grid.isInside(r, c + i) && grid[r, c + i] == 0) //CHECK RIGHT
                    Change_Cells_ID(objects[(r) * Columns + (c + i)].box, 1);
            }

            //Activate New Active Box
            activeBox = ((PictureBox)sender); activeBox.BackColor = Color.Cyan; activeBox.Padding = new Padding(3);
        }
        public void ClickMove(object sender,EventArgs e)
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
            int counter = 3;
            if (Path != "...error...")
                foreach (char direction in Path)
                {
                    wait(700);
                    Cell oldCell = objects[CurrentRow * Columns + CurrentCol];
                    switch (direction)
                    {
                        case 'l': CurrentCol--; break;
                        case 'r': CurrentCol++; break;
                        case 'u': CurrentRow--; break;
                        case 'd': CurrentRow++; break;
                    }
                    objects[CurrentRow * Columns + CurrentCol].id = oldCell.id; // Set New One's Id
                    Change_Cells_ID(objects[CurrentRow * Columns + CurrentCol].box, oldCell.id); // Old One to New Position
                    oldCell.id = 0;
                    Change_Cells_ID(oldCell.box, 0); // Old Position is Empty
                    if(counter--<=0)
                        updateScore(-1);
                }
            else
                updateScore(-scoreCoef/3);
            checkBingo(NumberOfSameCellsToWin, TargetRow, TargetCol, Objects[CurrentRow * Columns + CurrentCol].id);
            createRandomCells(NumberOfRandomCell, CellsPossibleIds);
        }
        private void wait(int milliseconds)
        {
            var timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            // Star Timer
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>{ timer1.Enabled = false; timer1.Stop(); }; // After Waiting; Stop Timer

            while (timer1.Enabled)  // While Timer Waiting; Waited Everything
                Application.DoEvents();
        }
        private void updateScore(int point)
        {
            score += point;
            ScoreBoard.Text = "Score: " + score.ToString();
        }
    }
    
}




