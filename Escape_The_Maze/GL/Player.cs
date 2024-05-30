using Escape_The_Maze.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Escape_The_Maze.GL
{
    class Player : GameObject
    {
        private static List<GameBullet> bulletList;
        private Form gameForm;
        private Game gameGUI;

        public static List<GameBullet> BulletList { get => bulletList; set => bulletList = value; }

        public Player(Image image, GameCell startCell)
          : base(GameObjectType.PLAYER, image)
        {
            base.CurrentCell = startCell;
            BulletList = new List<GameBullet>();

        }

        public void move(GameCell gameCell)
        {
            base.CurrentCell = gameCell;
        }

        public void Shoot(GameDirection playerDirection)
        {
            Image fireImage = Resources.laserPurple;
            GameCell bulletCell = this.CurrentCell.nextCell(playerDirection, GameObjectType.BULLET);
            if (bulletCell != this.CurrentCell)
            {
                GameBullet bullet = new GameBullet(fireImage, bulletCell, playerDirection);
                bulletList.Add(bullet);

            }

        }
    }
}
