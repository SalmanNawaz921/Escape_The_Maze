using System;
using System.Drawing;

namespace Escape_The_Maze.GL
{
    class EnemyRandom : Enemy
    {
        public EnemyRandom(Image ghostImage, GameCell startCell, EnemyType enemyType)
          : base(ghostImage, enemyType)
        {
            base.CurrentCell = startCell;
        }


        public override void move(GameCell gameCell)
        {
            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(Game.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
        }
        public override GameCell nextCell()
        {
            GameDirection direction = randomDirection();
            GameCell nextCell = base.CurrentCell.nextCell(direction, GameObjectType.ENEMY);
            if (nextCell != this.CurrentCell)
            {
                base.CurrentCell.setGameObject(Game.getBlankGameObject());
                base.CurrentCell = nextCell;
            }
            return base.CurrentCell;
        }

        public int generateRandom()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }


        public GameDirection randomDirection()
        {
            int value = generateRandom();
            if (value == 0)
            {
                return GameDirection.Left;
            }
            else if (value == 1)
            {
                return GameDirection.Up;
            }
            else if (value == 2)
            {
                return GameDirection.Down;

            }
            else if (value == 3)
            {

                return GameDirection.Right;
            }
            return GameDirection.Left;
        }
    }
}
