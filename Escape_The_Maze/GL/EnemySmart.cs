using System;
using System.Collections.Generic;
using System.Drawing;

namespace Escape_The_Maze.GL
{
    class EnemySmart : Enemy
    {
        public Player player;
        public EnemySmart(Image gameObject, GameCell currentCell, Player player, EnemyType type) : base(gameObject, type)
        {
            base.CurrentCell = currentCell;
            this.player = player;

        }
        public override GameCell nextCell()
        {
            GameDirection direction = GetSmartDirection();
            GameCell nextCell = base.CurrentCell.nextCell(direction, GameObjectType.ENEMY);
            GameObject nextObject = nextCell.CurrentGameObject;


            if (player == null || base.CurrentCell == null)
            {
                // Handle the case when player or current cell is null.
                return base.CurrentCell;
            }

            if (nextCell != base.CurrentCell)
            {
                base.CurrentCell.setGameObject(nextObject);
                base.CurrentCell = nextCell;
            }

            return base.CurrentCell;
        }
        public override void move(GameCell gameCell)
        {

            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(Game.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
        }

        public GameDirection GetSmartDirection()
        {
            List<double> distances = GetDistances();

            if (player == null || base.CurrentCell == null)
            {
                // Handle the case when player or current cell is null.
                return GameDirection.Down;
            }

            if (distances[0] <= distances[1] && distances[0] <= distances[2] && distances[0] <= distances[3])
            {
                return GameDirection.Up;
            }

            else if (distances[1] <= distances[0] && distances[1] <= distances[2] && distances[1] <= distances[3])
            {
                return GameDirection.Down;
            }

            else if (distances[2] <= distances[0] && distances[2] <= distances[1] && distances[2] <= distances[3])
            {
                return GameDirection.Left;
            }

            else if (distances[3] <= distances[0] && distances[3] <= distances[1] && distances[3] <= distances[2])
            {
                return GameDirection.Right;
            }

            return GameDirection.Down;
        }

        public List<double> GetDistances()
        {
            List<double> distances = new List<double>
            {
                calculateDistance(CurrentCell.X - 1, CurrentCell.Y, player.CurrentCell.X, player.CurrentCell.Y),
                calculateDistance(CurrentCell.X + 1, CurrentCell.Y, player.CurrentCell.X, player.CurrentCell.Y),
                calculateDistance(CurrentCell.X, CurrentCell.Y - 1, player.CurrentCell.X, player.CurrentCell.Y),
                calculateDistance(CurrentCell.X, CurrentCell.Y + 1, player.CurrentCell.X, player.CurrentCell.Y)
            };
            return distances;
        }
        public double calculateDistance(int X, int Y, int PX, int PY)
        {
            return Math.Sqrt(Math.Pow((X - PX), 2) + Math.Pow((Y - PY), 2));
        }
    }
}
