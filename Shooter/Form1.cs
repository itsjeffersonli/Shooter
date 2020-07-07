using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooter
{
    public partial class Form1 : Form
    {
        int moveLeft = 0;
        int enemyMove = 5;
        Random rnd = new Random();
        int bulletSpeed = 10;
        bool shooting = false;
        int score = 0;
            
        public Form1()
        {
            InitializeComponent();
            enemy1.Top = -100;
            enemy2.Top = -100;
            enemy3.Top = -100;
            bullet.Top = 0;
            bullet.Left = 0;
        }


        Ship player1 = new Ship();
        Graphics gfx;
        Pen pen;
        Bullet b = new Bullet();

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            pen = new Pen(Color.Black, 4.0f);
        }

        private void tRender_Tick(object sender, EventArgs e)
        {
            gfx.Clear(this.BackColor);
            player1.DrawShip(gfx, pen);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "A")
            {
                player1.IsMovingLeft = true;
            }
            if (e.KeyCode.ToString() == "D")
            {
                player1.IsMovingRight = true;
            }
            if (e.KeyCode.ToString() == "W")
            {
                player1.IsMovingFront = true;
            }
            if (e.KeyCode.ToString() == "S")
            {
                player1.IsMovingBack = true;
            }
            if (e.KeyCode.ToString() == "E")
            {
                b.X = player1.X;
                b.Y = player1.Y;
                tBullet.Enabled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "A")
            {
                player1.IsMovingLeft = false;
            }
            if (e.KeyCode.ToString() == "D")
            {
                player1.IsMovingRight = false;
            }
            if (e.KeyCode.ToString() == "W")
            {
                player1.IsMovingFront = false;
            }
            if (e.KeyCode.ToString() == "S")
            {
                player1.IsMovingBack = false;
            }
            }

        private void tBullet_Tick(object sender, EventArgs e)
        {
            b.DrawBullet(gfx, pen);
            if(b.Active == false)
            {
                tBullet.Enabled = false;
                b.ResetBullet();
            }
            
        }

        private void enemyHit()
        {
            if (bullet.Bounds.IntersectsWith(enemy1.Bounds))
            {
                score += 1;
                enemy1.Top = -100;
                int ranP = rnd.Next(1, 300);
                enemy1.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;

            }
            else if (bullet.Bounds.IntersectsWith(enemy2.Bounds))
            {
                score += 1;
                enemy2.Top = -100;
                int ranP = rnd.Next(1, 400);
                enemy2.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;

            }
            else if (bullet.Bounds.IntersectsWith(enemy3.Bounds))
            {
                score += 1;
                enemy3.Top = -100;
                int ranP = rnd.Next(1, 500);
                enemy3.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;

            }
        }

        private void gameOver()
        {
            MessageBox.Show("You Score = " + score + " Click OK to play Again");
            score = 0;
            scoreText.Text = "0";
            enemy1.Top = -100;
            enemy2.Top = -100;
            enemy3.Top = -100;
            bullet.Top = -100;
            bullet.Left = -100;

        }

        private void Player_Tick(object sender, EventArgs e)
        {
                bullet.Top -= bulletSpeed;
                enemy1.Top += enemyMove;
                enemy2.Top += enemyMove;
                enemy3.Top += enemyMove;
                scoreText.Text = "" + score;

                if (enemy1.Top == 660 || enemy2.Top == 660 || enemy3.Top == 660)
                {
                    gameOver();

                }

                if (shooting && bullet.Top < 0)
            {
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;
            }
            enemyHit();
        }
    }
    }
    
    

