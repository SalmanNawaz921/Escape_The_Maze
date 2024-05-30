using System.Drawing;
using System.Windows.Forms;

namespace Escape_The_Maze.GL
{
    class GameCell
    {
        private int row;

        private int col;

        private GameObject currentGameObject;

        private GameGrid grid;

        private PictureBox pictureBox;

        private const int width = 25;

        private const int height = 25;

        public int X
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public int Y
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }

        public GameObject CurrentGameObject => currentGameObject;

        public PictureBox PictureBox
        {
            get
            {
                return pictureBox;
            }
            set
            {
                pictureBox = value;
            }
        }

        public static int Width => width;

        public static int Height => height;

        internal GameObject GameObject
        {
            get => default;
            set
            {
            }
        }

        public GameCell(int row, int col, GameGrid grid)
        {
            this.row = row;
            this.col = col;
            pictureBox = new PictureBox();
            pictureBox.Left = col * Width;
            pictureBox.Top = row * Height;
            pictureBox.Size = new Size(Width, Height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }

        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            GameObjectType type = currentGameObject.GameObjectType;
            if (type == GameObjectType.WALL || type == GameObjectType.NONE)
            {
                pictureBox.Width = GameGrid.WallWidth;
                pictureBox.Height = GameGrid.WallHeight;
            }
            else if (type == GameObjectType.DOOR)
            {
                pictureBox.Width = GameGrid.GameObjectWidth - 25;
                pictureBox.Height = GameGrid.GameObjectHeight - 25;

            }
            else
            {
                pictureBox.Width = GameGrid.GameObjectWidth;
                pictureBox.Height = GameGrid.GameObjectHeight;
            }

            pictureBox.Image = gameObject.Image;
        }

        public GameCell nextCell(GameDirection direction, GameObjectType type)
        {
            GameCell cell;
            GameCell cell1;
            GameCell cell2;
            GameCell cell3;
            GameCell cell4;
            GameCell cell5;
            if (direction == GameDirection.Left && col >= 3)
            {
                cell = grid.getCell(row, col - 1);
                cell1 = grid.getCell(row + 1, col - 1);

                if (cell.CurrentGameObject.GameObjectType != GameObjectType.WALL && cell1.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    GameCell nextCell = cell;
                    return nextCell;
                }

            }

            else if (direction == GameDirection.Right && col < grid.Cols - 1)
            {
                cell = grid.getCell(row, col + 1);
                cell1 = grid.getCell(row, col + 2);
                cell2 = grid.getCell(row, col + 3);
                cell5 = grid.getCell(row + 1, col + 3);

                if (cell.CurrentGameObject.GameObjectType != GameObjectType.WALL && cell1.CurrentGameObject.GameObjectType != GameObjectType.WALL && cell2.CurrentGameObject.GameObjectType != GameObjectType.WALL && cell5.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    GameCell nextCell = cell;
                    return nextCell;
                }

            }

            else if (direction == GameDirection.Up && row > 0)
            {
                cell = grid.getCell(row - 1, col);
                if (cell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    GameCell nextCell = cell;
                    return nextCell;
                }

            }

            else if (direction == GameDirection.Down && row < grid.Rows - 3)
            {
                cell = grid.getCell(row + 1, col);
                cell1 = grid.getCell(row + 2, col);
                cell2 = grid.getCell(row + 3, col);
                if (cell.CurrentGameObject.GameObjectType != GameObjectType.WALL && cell1.CurrentGameObject.GameObjectType != GameObjectType.WALL && cell2.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    GameCell nextCell = cell;
                    return nextCell;
                }
            }

            return this;
        }
        //public GameCell nextCell(GameDirection direction, GameObjectType type)
        //{
        //    int nextRow = row;
        //    int nextCol = col;

        //    if (direction == GameDirection.Left && col > 0)
        //    {
        //        nextCol = col - 1; // Check three cells to the left
        //    }
        //    else if (direction == GameDirection.Right && col < grid.Cols - 1)
        //    {
        //        nextCol = col + 1; // Check three cells to the right
        //    }
        //    else if (direction == GameDirection.Up && row > 0)
        //    {
        //        nextRow = row - 1; // Check three cells upward
        //    }
        //    else if (direction == GameDirection.Down && row < grid.Rows - 1)
        //    {
        //        nextRow = row + 1; // Check three cells downward
        //    }
        //    GameCell nextCell = grid.getCell(nextRow, nextCol);

        //    if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
        //    {
        //        if (type == GameObjectType.ENEMY && nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
        //        {
        //            return this;
        //        }
        //        return nextCell;
        //    }

        //    return this;
        //}


    }
}
