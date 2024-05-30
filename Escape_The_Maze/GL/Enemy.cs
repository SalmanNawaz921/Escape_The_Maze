using System.Drawing;

namespace Escape_The_Maze.GL
{
    abstract class Enemy : GameObject
    {
        protected EnemyType enemyType;
        public int HitCount;

        public EnemyType EnemyType { get => enemyType; set => enemyType = value; }

        public Enemy(Image enemyImage, EnemyType enemyType) : base(GameObjectType.ENEMY, enemyImage)
        {
            this.EnemyType = enemyType;
            HitCount = 0;
        }

        public abstract GameCell nextCell();
        public abstract void move(GameCell gameCell);
        public void Destroy()
        {
            CurrentCell.PictureBox.Dispose();
            CurrentCell.setGameObject(Game.getBlankGameObject());

        }
        public void IncreaseHitCount()
        {
            HitCount++;
        }

        public void ResetHitCount()
        {
            HitCount = 0;
        }
    }
}
