using System.Drawing;

namespace Escape_The_Maze.GL
{
    class GameBullet : GameObject
    {
        private GameDirection shootingDirection;

        public GameDirection ShootingDirection { get => shootingDirection; set => shootingDirection = value; }
        private bool wallflag = false;
        public GameBullet(Image bulletImage, GameCell gameCell, GameDirection shootingDirection) : base(GameObjectType.BULLET, bulletImage)
        {
            base.CurrentCell = gameCell;
            this.ShootingDirection = shootingDirection;
        }


        public void move(GameCell gameCell)
        {
            if (CurrentCell != null)
            {
                CurrentCell.setGameObject(Game.getBlankGameObject());
            }
            CurrentCell = gameCell;
        }

        public GameCell nextCell()
        {
            GameCell nextCell = CurrentCell.nextCell(shootingDirection, GameObjectType.BULLET);

            if (nextCell != CurrentCell)
            {
                CurrentCell.setGameObject(Game.getBlankGameObject());
                CurrentCell = nextCell;
            }
            else
            {
                CurrentCell.setGameObject(Game.getBlankGameObject());
                SetWallFlag();

            }
            return CurrentCell;
        }
        public void Destroy()
        {
            CurrentCell.setGameObject(Game.getBlankGameObject());
        }
        public void SetWallFlag()
        {
            wallflag = true;
        }
        public bool GetWallFlag()
        {
            return wallflag;
        }
    }
}
