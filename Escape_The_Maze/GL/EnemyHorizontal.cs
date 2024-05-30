using Escape_The_Maze.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace Escape_The_Maze.GL
{
    class EnemyHorizontal : Enemy
    {
        private GameDirection direction = GameDirection.Right;
        private List<GameBullet> enemyBulletList;
        public List<GameBullet> EnemyBulletList { get => enemyBulletList; set => enemyBulletList = value; }
        public EnemyHorizontal(Image ghostImage, GameCell startCell, EnemyType type)
            : base(ghostImage, type)
        {
            base.CurrentCell = startCell;
            enemyBulletList = new List<GameBullet>();
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
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction, GameObjectType.ENEMY);
            if (gameCell2 == gameCell)
            {
                if (direction == GameDirection.Right)
                {
                    if (base.EnemyType == EnemyType.Bat)
                    {
                        this.Image = Resources.Bat;
                    }
                    else
                    {
                        this.Image = Resources.Dragon;
                    }
                    direction = GameDirection.Left;

                }
                else if (direction == GameDirection.Left)
                {
                    if (base.EnemyType == EnemyType.Bat)
                    {
                        this.Image = Resources.BatRight;
                    }
                    else
                    {
                        this.Image = Resources.DragonRight;
                    }
                    direction = GameDirection.Right;
                }
            }
            else
            {
                gameCell = gameCell2;
            }

            return gameCell;
        }

        public void Shoot(Player player)
        {

            if (EnemyType == EnemyType.Dragon && CurrentCell.X == player.CurrentCell.X)
            {
                Image fireImage = Resources.FireRight;
                if (direction == GameDirection.Left)
                {

                    fireImage = Resources.Fire;
                }
                checkPlayerPosition(player);

                GameCell bulletCell = this.CurrentCell.nextCell(direction, GameObjectType.BULLET);
                if (bulletCell != this.CurrentCell)
                {
                    GameBullet bullet = new GameBullet(fireImage, bulletCell, direction);
                    EnemyBulletList.Add(bullet);

                }

            }
        }

        private void checkPlayerPosition(Player player)
        {
            if (player.CurrentCell.Y < CurrentCell.Y)
            {
                direction = GameDirection.Left;
                this.Image = Resources.Dragon;
            }
            else
            {
                direction = GameDirection.Right;
                this.Image = Resources.DragonRight;

            }
        }

    }
}
