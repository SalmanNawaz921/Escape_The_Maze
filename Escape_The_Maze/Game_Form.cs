using Escape_The_Maze.GL;
using Escape_The_Maze.Properties;
using EZInput;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Escape_The_Maze
{
    public partial class Game_Form : Form
    {
        Game game;
        GameCollisionDetector collisionDetector;
        Player player;
        List<PictureBox> lives;
        int livesCount = 3;
        EnemyHorizontal dragon;
        int enemyBulletCount = 0;
        int playerBulletCount = 0;
        List<Enemy> enemiesToRemove;
        List<GameBullet> playerBulletsToRemove;
        List<GameBullet> enemyBulletsToRemove;
        GameDirection playerDirection;
        private Timer enemyShootingTimer;
        private Timer enemyMovementTimer;
        public Game_Form()
        {
            InitializeComponent();
            enemyShootingTimer = new Timer();
            enemyShootingTimer.Interval = 2000;
            enemyShootingTimer.Tick += EnemyShootingTimer_Tick;
            enemyShootingTimer.Start();
            enemyMovementTimer = new Timer();
            enemyMovementTimer.Interval = 200;
            enemyMovementTimer.Tick += EnemyMovementTimer_Tick;
            enemyMovementTimer.Start();
            DoubleBuffered = true;
            game = new Game(this);
            collisionDetector = new GameCollisionDetector(game);
            lives = new List<PictureBox>() { pB_Life3, pB_Life2, pB_Life1 };
            enemiesToRemove = new List<Enemy>();
            playerBulletsToRemove = new List<GameBullet>();
            enemyBulletsToRemove = new List<GameBullet>();


        }

        private void EnemyMovementTimer_Tick(object sender, EventArgs e)
        {
            moveEnemies();
            MoveEnemyBullet();
        }

        private void EnemyShootingTimer_Tick(object sender, EventArgs e)
        {

            dragon.Shoot(player);


        }
        private void Game_Loop_Tick(object sender, System.EventArgs e)
        {

            MovePlayerBullet();
            MovePlayer();
            showScore();
            showHealth();
            showDragonHealth();
            PlayerFire();
            game.winningCondition();

        }
        private void MovePlayer()
        {
            player = game.getPlayer();

            GameCell newCell = player.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                newCell = player.CurrentCell.nextCell(GameDirection.Left, GameObjectType.PLAYER);
                playerDirection = GameDirection.Left;
                player.Image = Resources.RABBIT;
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                newCell = player.CurrentCell.nextCell(GameDirection.Right, GameObjectType.PLAYER);
                playerDirection = GameDirection.Right;
                player.Image = Resources.RABBITRIGHT;

            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                newCell = player.CurrentCell.nextCell(GameDirection.Up, GameObjectType.PLAYER);
                playerDirection = GameDirection.Up;
                player.Image = Resources.RABBITUP;

            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                newCell = player.CurrentCell.nextCell(GameDirection.Down, GameObjectType.PLAYER);
                playerDirection = GameDirection.Down;
                player.Image = Resources.RABBITDOWN;

            }

            GameCell currentCell = player.CurrentCell;
            currentCell.setGameObject(Game.getBlankGameObject());
            if (collisionDetector.isPlayerGotKey(newCell))
            {
                Door_Open();
                Game_Loop.Enabled = false;
                MessageBox.Show("You Won");
                this.Hide();
               // Won won = new Won();
                //won.FormClosed += (s, args) => this.Close(); // Close the signup form when login form is closed
                //won.Show();

            }
            player.move(newCell);

        }
        public void PlayerFire()
        {
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                if (playerBulletCount < 3)
                {
                    player.Shoot(playerDirection);
                    playerBulletCount++;

                }
                if (playerBulletCount == 3)
                {
                    playerBulletCount = 0;
                }

            }

        }

        private void Game_Form_Load(object sender, System.EventArgs e)
        {
            EnemyRandom vampire = new EnemyRandom(game.getVampireImage(), game.getCell(15, 47), EnemyType.Vampire);
            EnemyHorizontal bat = new EnemyHorizontal(game.getBatImage(), game.getCell(18, 7), EnemyType.Bat);
            EnemyRandom ghost = new EnemyRandom(game.getGhostImage(), game.getCell(8, 8), EnemyType.Ghost);
            EnemyRandom werewolf = new EnemyRandom(game.getWereWolfImage(), game.getCell(5, 47), EnemyType.WereWolf);
            dragon = new EnemyHorizontal(game.getDragonImage(), game.getCell(26, 3), EnemyType.Dragon);
            game.addGhost(vampire);
            game.addGhost(bat);
            game.addGhost(ghost);
            game.addGhost(werewolf);
            game.addGhost(dragon);
        }
        private void moveEnemies()
        {

            foreach (Enemy enemy in game.enemies)
            {
                if (collisionDetector.isEnemyCollideWithPlayer(enemy))
                {
                    livesCount--;
                    Lives();
                }
                enemy.move(enemy.nextCell());
                // Remove enemies marked for removal

            }
            foreach (Enemy enemyToRemove in enemiesToRemove)
            {
                game.enemies.Remove(enemyToRemove);
            }
            enemiesToRemove.Clear();
        }


        private void MovePlayerBullet()
        {
            for (int i = Player.BulletList.Count - 1; i >= 0; i--)
            {
                GameBullet bullet = Player.BulletList[i];
                GameCell gameCell = bullet.nextCell();
                if (gameCell != null)
                {
                    if (bullet.GetWallFlag())
                    {
                        Player.BulletList.Remove(bullet);
                    }

                    bullet.move(bullet.nextCell());

                    if (collisionDetector.isBulletCollideWithEnemy(bullet))
                    {
                        Enemy enemy = collisionDetector.CollidedEnemy;
                        game.addScorePoints(1);
                        enemy.IncreaseHitCount();
                        EnemyCollided(enemy);
                        playerBulletsToRemove.Add(bullet);
                        Player.BulletList.Remove(bullet);
                        bullet.Image = Resources.simplebox;

                    }

                }
            }
            foreach (var bullet in playerBulletsToRemove)
            {
                Player.BulletList.Remove(bullet);
            }
            playerBulletsToRemove.Clear();
        }

        private void MoveEnemyBullet()
        {
            for (int i = dragon.EnemyBulletList.Count - 1; i >= 0; i--)
            {
                GameBullet bullet = dragon.EnemyBulletList[i];
                GameCell gameCell = bullet.nextCell();
                if (gameCell != null)
                {
                    if (bullet.GetWallFlag())
                    {
                        dragon.EnemyBulletList.Remove(bullet);
                    }
                    else
                    {
                        bullet.move(gameCell);
                        if (collisionDetector.isBulletCollideWithPlayer(bullet))
                        {
                            game.removeHealthValue(10);
                            enemyBulletsToRemove.Add(bullet);
                            bullet.Image = Resources.simplebox;
                        }
                    }
                }
            }

            // Remove the marked enemy bullets.
            foreach (var bullet in enemyBulletsToRemove)
            {
                // Note: Make sure you are removing the bullet from the correct enemy's list.
                dragon.EnemyBulletList.Remove(bullet);
            }

            enemyBulletsToRemove.Clear();
        }


        //private void MoveEnemyBullet()
        //{
        //    for (int enemyIndex = 0; enemyIndex < game.enemies.Count; enemyIndex++)
        //    {
        //        var enemy = game.enemies[enemyIndex];
        //        for (int bulletIndex = enemy.EnemyBulletList.Count - 1; bulletIndex >= 0; bulletIndex--)
        //        {
        //            GameBullet bullet = enemy.EnemyBulletList[bulletIndex];
        //            if (collisionDetector.isBulletCollideWithPlayer(bullet))
        //            {
        //                game.removeHealthValue(10);
        //                enemyBulletsToRemove.Add(bullet);
        //                MessageBox.Show("Collided");
        //                //continue; // Skip the bullet movement if it collided with the player.
        //            }
        //            bullet.move(bullet.nextCell());
        //        }

        //        // Remove the marked enemy bullets.
        //        for (int bulletIndex = enemyBulletsToRemove.Count - 1; bulletIndex >= 0; bulletIndex--)
        //        {
        //            // Note: Make sure you are removing the bullet from the correct enemy's list.
        //            enemy.EnemyBulletList.Remove(enemyBulletsToRemove[bulletIndex]);
        //        }
        //    }
        //    enemyBulletsToRemove.Clear();
        //}


        private void showScore()
        {

            lbl_ScoreCount.Text = game.getScore().ToString();
        }

        private void showHealth()
        {
            int newValue = game.getValue();
            int currentHealth = Math.Max(newValue, 0);
            bar_Health.Value = currentHealth;
        }

        private void showDragonHealth()
        {
            int newValue = game.getDragonValue();
            int currentHealth = Math.Max(newValue, 0);
            bar_Dragon.Value = newValue;
        }

        private void Lives()
        {
            if (livesCount > 0)
            {
                lives[livesCount].Hide();
                lives.Remove(lives[livesCount]);

            }
            else
            {
                MessageBox.Show("You Lost ");
                this.Close();
            }

        }
        private void EnemyCollided(Enemy enemy)
        {
            if (enemy.EnemyType == EnemyType.Dragon)
            {
                game.removeDragonHealth(10);
                if (game.getDragonValue() <= 0)
                {
                    enemiesToRemove.Add(enemy);
                    enemy.CurrentCell.setGameObject(Game.getBlankGameObject());
                    game.enemies.Remove(enemy);
                }
            }
            else
            {
                enemy.IncreaseHitCount();
                if (enemy.HitCount >= 5)
                {
                    enemiesToRemove.Add(enemy);
                    enemy.CurrentCell.setGameObject(Game.getBlankGameObject());
                    game.enemies.Remove(enemy);
                }
            }
        }

        private void Door_Open()
        {
            for (int i = 26; i <= 27; i++)
            {
                for (int j = 59; j <= 60; j++)
                {
                    game.getCell(i, j).setGameObject(Game.getBlankGameObject());
                }
            }
        }

    }
}
