using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Escape_The_Maze.GL
{
    class GameGrid
    {
        private GameCell[,] cells;

        private int rows;

        private int cols;
        public const int WallWidth = 25;
        public const int WallHeight = 25;
        public const int GameObjectWidth = 75;
        public const int GameObjectHeight = 75;
        public int Rows
        {
            get
            {
                return rows;
            }
            set
            {
                rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
            set
            {
                cols = value;
            }
        }

        internal GameCell GameCell
        {
            get => default;
            set
            {
            }
        }

        public GameGrid(string fileName, int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            cells = new GameCell[rows, cols];
            loadGrid(fileName);
        }

        public GameCell getCell(int x, int y)
        {
            return cells[x, y];
        }

        //private void loadGrid(string fileName)
        //{
        //    StreamReader streamReader = new StreamReader(fileName);
        //    for (int i = 0; i < rows; i++)
        //    {
        //        string text = streamReader.ReadLine();
        //        for (int j = 0; j < cols; j++)
        //        {
        //            GameCell gameCell = new GameCell(i, j, this);
        //            char displayCharacter = text[j];
        //            GameObjectType gameObjectType = GameObject.getGameObjectType(displayCharacter);
        //            Image gameObjectImage = Game.getGameObjectImage(displayCharacter);
        //            GameObject gameObject = new GameObject(gameObjectType, gameObjectImage);
        //            gameCell.setGameObject(gameObject);
        //            cells[i, j] = gameCell;
        //        }
        //    }

        //    streamReader.Close();
        //}
        private void loadGrid(string fileName)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();
            rows = lines.Count;
            cols = lines.Max(line => line.Length);
            cells = new GameCell[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string text = lines[i].PadRight(cols); // Pad the line with spaces if needed.

                for (int j = 0; j < cols; j++)
                {
                    GameCell gameCell = new GameCell(i, j, this);
                    char displayCharacter = text[j];
                    GameObjectType gameObjectType = GameObject.getGameObjectType(displayCharacter);
                    Image gameObjectImage = Game.getGameObjectImage(displayCharacter);
                    GameObject gameObject = new GameObject(gameObjectType, gameObjectImage);
                    gameCell.setGameObject(gameObject);
                    cells[i, j] = gameCell;
                }
            }
        }

    }
}
