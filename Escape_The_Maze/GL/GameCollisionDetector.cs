namespace Escape_The_Maze.GL
{
    class GameCollisionDetector
    {

        private Enemy collidedEnemy;
        private Game game;

        public Enemy CollidedEnemy { get => collidedEnemy; set => collidedEnemy = value; }

        public GameCollisionDetector(Game game)
        {
            this.game = game;
        }


        public bool isPlayerGotKey(GameCell nextCell)
        {
            bool flag = false;
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                game.setKeyTaken();
                flag = true;
            }
            return flag;
        }
        public bool isEnemyCollideWithPlayer(Enemy enemy)
        {
            bool flag = false;
            GameCell gameCell = enemy.nextCell();
            if (gameCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                flag = true;
            }
            return flag;
        }
        public bool isBulletCollideWithEnemy(GameBullet bullet)
        {
            bool flag = false;
            GameCell gameCell = bullet.nextCell();
            foreach (Enemy enemy in game.enemies)
            {
                if (gameCell == enemy.nextCell())
                {
                    CollidedEnemy = enemy;
                    flag = true;
                    bullet.Destroy();
                    break;
                }
            }

            return flag;
        }
        public bool isBulletCollideWithPlayer(GameBullet bullet)
        {
            bool flag = false;
            GameCell gameCell = bullet.nextCell();

            if (gameCell == game.getPlayer().CurrentCell)
            {
                flag = true;
            }
            return flag;
        }
    }
}
