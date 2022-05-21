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
        const int NumberOfMovesWithoutPenalty = 5;
        int scoreCoef=10;
        
        private gameGrid grid;
        private List<Cell> objects;
        private PictureBox activeBox;
        public Label ScoreBoard { get; }
        private int score;
        private List<int> difficulty_shapes_color =null;
        private Panel GameOverPanel;

        System.Media.SoundPlayer MoveSound = new System.Media.SoundPlayer();
        System.Media.SoundPlayer BingoSound = new System.Media.SoundPlayer();

        // Get Set
        public int Rows { get; set; }
        public int Columns { get; set; }
        
        public List<Cell> Objects { get => objects; }
        // Constructors
        public Game(int row = 9, int col = 9, List<int> GameInitialIds =null,Panel gameOVer=null) {
            this.Rows = row; this.Columns = col;this.difficulty_shapes_color = GameInitialIds;this.GameOverPanel = gameOVer;
            grid = new gameGrid(row, col); objects = new List<Cell>();
            // 
            // ScoreBoard
            this.ScoreBoard = new Label();
            this.ScoreBoard.AutoSize = false;this.ScoreBoard.TextAlign = ContentAlignment.TopCenter;
            this.ScoreBoard.Font = new Font(FontFamily.GenericSansSerif, 25, FontStyle.Bold); 
            this.ScoreBoard.Text = "Score: 0";
            //
            score = 0;
            this.scoreCoef = 180 / (Rows + Columns);
            createObjects();
            MoveSound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.Move.wav");
            BingoSound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.Bingo.wav");
        }

        //Methods
        private void createRandomCells(int count)
        {
            Random random = new Random();
            while (!gameOver()&&(count--)>0)
            {
                int r= random.Next(Rows), c = random.Next(Columns); // SELECT A RANDOM BOX
                if(grid[r, c]!=0)                                    // IF BOX IS NOT EMPTY
                {
                    count++;                                         // TRY AGAIN
                    continue;
                }
                int id = difficulty_shapes_color[random.Next(difficulty_shapes_color.Count)];   // SELECT AN ID
                Change_Cells_ID(objects[r * Columns + c].box,id);                             // SET ID
                checkBingo(NumberOfSameCellsToWin, r, c, id);                            // CHECK IS THERE ANY BINGO (side by side, 5 same box)
            }
        }
        private void createObjects()
        {
            // CREATE INITIAL CELLS AS AN OBJECT
            // 
            for (int i = 0; i < Rows; i++)  
            {
                for (int j = 0; j < Columns; j++)   
                {
                    Cell cell = new Cell(grid[i,j],grid.indexTolocation(i, j), grid.CellSize);  
                    objects.Add(cell);  // Add Created Objects to list<object> objects
                    Change_Cells_ID(cell.box, grid[i, j]);  // Set all of them ids
                }
            }
            createRandomCells(NumberOfRandomCell);
        }
        private void Change_Cells_ID(PictureBox box, int value)
        {
            //
            // Set Cell IDs
            grid[grid.locationToIndex(box.Location)[0], grid.locationToIndex(box.Location)[1]] = value; // Firstly set in grid
            objects[grid.locationToIndex(box.Location)[0] * Columns + grid.locationToIndex(box.Location)[1]].id = value;    // Then set in Cell (class)
            box.Image = Texture.texture[value]; // Set picture box's image
            box.Click -= ClickCell;         
            box.Click -= ClickMove;         // Clean Cell's click events
            //
            // Set Cell's Click Events
            //
            if (value > 1)  
                box.Click += new EventHandler(ClickCell);
            else if(value==1)
                box.Click += new EventHandler(ClickMove);
            //
            // Set Cursor
            //
            if (value > 0)
                box.Cursor = System.Windows.Forms.Cursors.Hand;
            else
                box.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void deactivateBox()
        {
            //Deactivate Old SELECTABLE Cells
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    if (grid[i, j] == 1)
                        Change_Cells_ID(objects[i * Columns + j].box, 0);
            //Deactivate Old Active Box
            if (activeBox != null) { activeBox.BackColor = Color.White; activeBox.Padding = new Padding(0); activeBox = null; }
        }
        private string PathFindng(Point start, Point end, int step, string moves,bool showPossibleTargets=false)
        {
            string firstChild="...error...",secondChild= "...error...", thirdChild= "...error...", fourthChild= "...error...";
            //
            // Set Current Box as a SELECTABLE Cell.
            // In first click to a cell, Selectable Cells will be shown,
            // In second click it will be just for marking to which is passed boxes and it wont be shown.
            if (grid.isEmpty(start.X, start.Y)&&showPossibleTargets) 
                Change_Cells_ID(objects[start.X * Columns + start.Y].box, 1);

            if (start == end)   // IF START POSITION AND END POSITION IS EQUAL, WELL DONE YOU ARRIVED
                return moves;   // Return Parents Movement Hıstory
            
            else if (step < 10)   // IF STEP COUNT LESS THAN ROW DONT GO ON
            {
                start.Offset(-1, 0);    // Move UP by 1 Step
                if (grid.isEmpty(start.X, start.Y))
                {
                    firstChild = PathFindng(start, end, step + 1, moves+"u", showPossibleTargets); // CHECK FIRST CHILD
                }
                start.Offset(+1, +1);   // Move RIGHT by 1 Step
                if (grid.isEmpty(start.X, start.Y))
                {
                    secondChild = PathFindng(start, end, step + 1, moves+"r", showPossibleTargets); // CHECK SECOND CHILD
                }
                start.Offset(0, -2);    // Move LEFT by 1 Step
                if (grid.isEmpty(start.X, start.Y))
                {
                    thirdChild = PathFindng(start, end, step + 1, moves+"l", showPossibleTargets); //CHECK THIRD CHILD
                }
                start.Offset(+1, +1);   // Move DOWN by 1 Step
                if (grid.isEmpty(start.X, start.Y))
                {
                    fourthChild = PathFindng(start, end, step + 1, moves+"d", showPossibleTargets); //CHECK FOURTH CHILD
                }
            }
            //-----
            // Return Shortest Path
            int min =Math.Min(Math.Min(firstChild.Length, secondChild.Length), Math.Min(thirdChild.Length, fourthChild.Length));
            if (min == firstChild.Length) return firstChild;
            if (min == secondChild.Length) return secondChild;
            if (min == thirdChild.Length) return thirdChild;
            else return fourthChild;
        }
        private void showTarget(int row,int col,int distance)
        {
            int i, k;
            if (row - distance < 0) i = 0;
            else i = row - distance;

            for (; i <= row+distance; i++)
                for (k= col-(distance- Math.Abs(row-i)); k <= col + distance - Math.Abs(row - i); k++) 
                    if(grid.isEmpty(i,k))
                        Change_Cells_ID(objects[i * Columns + k].box, 1);   // CHANGE THE CELL TO SELECTABLE CELL
            //if (distance > 20)
            //    return;
            //if (distance > 0)  // NOT TO PAINT START POINT
            //    Change_Cells_ID(objects[row * Columns + col].box, 1);   // CHANGE THE CELL TO SELECTABLE CELL
            //if (grid.isEmpty(row + 1, col)) showTarget(row + 1, col, distance + 1); // move to down
            //if (grid.isEmpty(row - 1, col)) showTarget(row - 1, col, distance + 1); // move to up
            //if (grid.isEmpty(row, col + 1)) showTarget(row, col + 1, distance + 1); // move to right
            //if (grid.isEmpty(row, col - 1)) showTarget(row, col - 1, distance + 1); // move to left
        }
        private bool checkBingo(int sideCount,int row,int col,int CenterID)
        {
            int PositiveVerticalCounter = 1, NegativeVerticalCounter=0, PositiveHorizantalCounter = 1,NegativeHorizantalCounter=0; // Four Counter for Four direction
            bool up = true, down = true, left = true, right = true,isBingo=false;   // Four Boolean Value for Four direction and also one bool for Bingo
            for(int i=1;i<sideCount;i++)    // For sideCount=5 
            {
                if (up && grid[row - i, col] == CenterID) NegativeHorizantalCounter++;    // 4 step to up until arrive the cell which does not match with centerID
                else up = false;
                if (down && grid[row + i, col] == CenterID) PositiveHorizantalCounter++;// 4 step to down until arrive the cell which does not match with centerID
                else down = false;
                if (left && grid[row, col - i] == CenterID) NegativeVerticalCounter++;// 4 step to left until arrive the cell which does not match with centerID
                else left = false;
                if (right && grid[row, col + i] == CenterID) PositiveVerticalCounter++;// 4 step to right until arrive the cell which does not match with centerID
                else right = false;
            }
            if(PositiveVerticalCounter + NegativeVerticalCounter >= sideCount|| PositiveHorizantalCounter + NegativeHorizantalCounter >= sideCount)
            {
                wait(300);  // wait 400 ms
                System.Threading.Thread.Sleep(500);
                BingoSound.Play();
                updateScore(scoreCoef);
                isBingo = true;
            }
            if(PositiveVerticalCounter + NegativeVerticalCounter >= sideCount) // Is there a bingo vertical
                for (int i = -NegativeVerticalCounter; i < PositiveVerticalCounter; i++)   // Make Valid Cells which has same id with center cell are Empty
                    if (grid[row, col + i] == CenterID)
                        this.Change_Cells_ID(objects[row * Columns + col + i].box, 0);
            if (PositiveHorizantalCounter+ NegativeHorizantalCounter >= sideCount) // Is there a bingo horizantal
                for (int i = -1*NegativeHorizantalCounter; i < PositiveHorizantalCounter; i++)   // Make Valid Cells which has same id with center cell are Empty
                    if (grid[row+i, col] == CenterID)
                        this.Change_Cells_ID(objects[(row+i) * Columns + col].box, 0);
            return isBingo;
        }

        private void wait(int milliseconds)
        {
            var timer1 = new Timer();   // Create a timer
            if (milliseconds == 0 || milliseconds < 0) return;  // If its not Valid , finish function
            //
            // Star Timer
            timer1.Interval = milliseconds; // Set count
            timer1.Enabled = true;
            timer1.Start(); // Start

            timer1.Tick += (s, e) =>{ timer1.Enabled = false; timer1.Stop(); }; // After Waiting; Stop Timer

            while (timer1.Enabled)  // While Timer Waiting; Waited Everything
                Application.DoEvents();
        }
        private void updateScore(int point)
        {
            score += point; // Update Integer Score
            ScoreBoard.Text = "Score: " + score.ToString(); // Update Text Box
        }
        private bool gameOver()
        {
            if (!grid.isFull())
                return false;
            // OPEN GAME OVER PANEL
            if(dataTransfer.Instance.isHighestScore(score))
                GameOverPanel.Controls[0].Text = "Well Done"+Environment.NewLine+ "New Highest "+ScoreBoard.Text;
            else
                GameOverPanel.Controls[0].Text = "SORRY" + Environment.NewLine + ScoreBoard.Text+Environment.NewLine + "Best Score: "+dataTransfer.Instance.get_account().info[0].ToString();
            GameOverPanel.Visible = true;
            return true;
        }
        public void ClickCell(object sender, EventArgs e)
        {
            deactivateBox();
            //Activate New Targets
            //PathFindng(new Point(grid.locationToIndex(((PictureBox)sender).Location)[0], grid.locationToIndex(((PictureBox)sender).Location)[1]), new Point(1, 1), 0, "", true);
            showTarget(grid.locationToIndex(((PictureBox)sender).Location)[0], grid.locationToIndex(((PictureBox)sender).Location)[1],15);
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
            deactivateBox();
            //-------
            // Show Steps 
            //
            int counter = NumberOfMovesWithoutPenalty;
            if(Path!= "...error...")
                foreach (char direction in Path)
                {
                    wait(400);
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
                    System.Threading.Thread.Sleep(500);
                    MoveSound.Play();
                }
            if (!checkBingo(NumberOfSameCellsToWin, TargetRow, TargetCol, Objects[CurrentRow * Columns + CurrentCol].id))
                createRandomCells(NumberOfRandomCell);
        }
    }
    
}




