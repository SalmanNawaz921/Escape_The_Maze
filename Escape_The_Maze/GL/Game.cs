using Escape_The_Maze.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Escape_The_Maze.GL
{
    class Game
    {

        private Player player;

        private GameGrid grid;

        public List<Enemy> enemies;

        private int score;
        private int value = 100;
        private int dragonValue = 100;
        private bool keyTaken = false;

        private Form game;

        public Game(Form game)
        {

            this.game = game;
            grid = new GameGrid("maze.txt", 32, 61);
            Image gameObjectImage = getGameObjectImage('P');
            enemies = new List<Enemy>();
            GameCell cell = grid.getCell(3, 3);
            player = new Player(gameObjectImage, cell);
            printMaze(grid);
        }

        internal GameGrid GameGrid
        {
            get => default;
            set
            {
            }
        }

        public GameCell getCell(int x, int y)
        {
            return grid.getCell(x, y);
        }

        public void addGhost(Enemy ghost)
        {
            enemies.Add(ghost);
        }

        public Player getPlayer()
        {
            return player;
        }

        public void addScorePoints(int points)
        {
            score += points;
        }
        public void removeHealthValue(int points)
        {
            value -= points;
        }
        public void removeDragonHealth(int points)
        {
            dragonValue -= points;
        }

        public int getScore()
        {
            return score;
        }
        public int getValue()
        {
            return value;
        }

        public int getDragonValue()
        {
            return dragonValue;
        }

        private void printMaze(GameGrid grid)
        {
            for (int i = 0; i < grid.Rows; i++)
            {
                for (int j = 0; j < grid.Cols; j++)
                {
                    GameCell cell = grid.getCell(i, j);
                    game.Controls.Add(cell.PictureBox);
                }
            }
        }

        public static GameObject getBlankGameObject()
        {
            return new GameObject(GameObjectType.NONE, Resources.simplebox);
        }

        public Image getGhostImage()
        {
            return Resources.GhostRight;
        }
        public Image getDragonImage()
        {
            return Resources.DragonRight;
        }

        public Image getVampireImage()
        {
            return Resources.VampireRight;
        }
        public Image getWereWolfImage()
        {
            return Resources.WerewolfRight;
        }

        public Image getBatImage()
        {
            return Resources.BatRight;
        }

        public void setKeyTaken()
        {
            keyTaken = true;
        }
        public bool getKeyTaken()
        {
            return keyTaken;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            Image result = Resources.simplebox;
            if (displayCharacter == '%')
            {
                result = Resources.Tile;
            }
            if (displayCharacter == '&')
            {
                result = Resources.Door;
            }

            if (displayCharacter == '#')
            {
                result = Resources.tile5;
            }

            if (displayCharacter == 'A')
            {
                result = Resources.ArrowSign;
            }
            if (displayCharacter == 'B')
            {
                result = Resources.Bush__1_;
            }
            if (displayCharacter == 'C')
            {
                result = Resources.Crate;
            }
            if (displayCharacter == 'D')
            {
                result = Resources.DeadBush;
            }
            if (displayCharacter == 'S')
            {
                result = Resources.Skeleton;
            }
            if (displayCharacter == 'T')
            {
                result = Resources.TombStone__2_;
            }

            if (displayCharacter == '*')
            {
                result = Resources.KEY;

            }

            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                result = Resources.RABBIT;
            }

            return result;
        }
        public void winningCondition()
        {
            if (enemies.Count == 0)
            {
                removeObstaclesAroundKey();
            }
        }
        public GameGrid getGrid()
        {
            return this.grid;
        }
        private void removeObstaclesAroundKey()
        {
            for (int i = 27; i <= 29; i++)
            {
                for (int j = 49; j <= 50; j++)
                {
                    getCell(i, j).setGameObject(getBlankGameObject());

                }
            }
            for (int i = 27; i <= 29; i++)
            {
                for (int j = 42; j <= 43; j++)
                {
                    getCell(i, j).setGameObject(getBlankGameObject());

                }
            }
            for (int i = 26; i < 27; i++)
            {
                for (int j = 42; j <= 50; j++)
                {
                    getCell(i, j).setGameObject(getBlankGameObject());
                }
            }
        }
    }
}
