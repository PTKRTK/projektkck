using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZajebistyProjekciktylkozeterazzKCK
{
    public partial class Form1 : Form
    {
        int Window_Size=1920;
        int gamespeed = 0;
        //szybkosc sterowania
        int str = 8;
        public Form1()
        {
            InitializeComponent();
            over.Visible = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
            gamespeed = collectedcoins + 5;
        }

        Random r = new Random();
        int x;

        void enemy(int speed)
        {
            int range_rand = 100;


            if(enemy1.Top >= Window_Size)
            {
                x = r.Next(0, range_rand);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= Window_Size)
            {
                x = r.Next(range_rand, range_rand*2);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (mk4.Top >= Window_Size)
            {
                x = r.Next(range_rand*2, range_rand*3);
                mk4.Location = new Point(x, 0);
            }
            else
            {
                mk4.Top += speed;
            }

            if (enemy4.Top >= Window_Size)
            {
                x = r.Next(range_rand*4, range_rand*5);
                enemy4.Location = new Point(x, 0);
            }
            else
            {
                enemy4.Top += speed;
            }
        }

        int collectedcoins = 0;

        void coinscollection()
        {
            if (PlayerCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                score.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, Window_Size-40);
                coin1.Location = new Point(x, 0);
            }

            if (PlayerCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                score.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, Window_Size-40);
                coin2.Location = new Point(x, 0);
            }

            if (PlayerCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                score.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, Window_Size-40);
                coin3.Location = new Point(x, 0);
            }

            if (PlayerCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                score.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, Window_Size-40);
                coin4.Location = new Point(x, 0);
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= Window_Size)
            {
                x = r.Next(0, Window_Size-40);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= Window_Size-40)
            {
                x = r.Next(0, Window_Size-40);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= Window_Size)
            {
                x = r.Next(0, Window_Size-40);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= Window_Size)
            {
                x = r.Next(0, Window_Size-40);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }


        }

        void moveline(int speed)
        {
            
            MoveLines(speed, Line1);
            MoveLines(speed, Line2);
            MoveLines(speed, Line3);
            MoveLines(speed, Line4);
            MoveLines(speed, Line5);
            MoveLines(speed, Line6);
            MoveLines(speed, Line7);
            MoveLines(speed, Line8);
            MoveLines(speed, Line9);
            MoveLines(speed, Line10);
            MoveLines(speed, Line11);
            MoveLines(speed, Line12);
            MoveLines(speed, Line13);
            MoveLines(speed, Line14);
            MoveLines(speed, Line15);
            MoveLines(speed, Line16);
            MoveLines(speed, Line_r1_1);
            MoveLines(speed, Line_r1_2);
            MoveLines(speed, Line_r1_3);
            MoveLines(speed, Line_r1_4);
            MoveLines(speed, Line_r2_1);
            MoveLines(speed, Line_r2_2);
            MoveLines(speed, Line_r2_3);
            MoveLines(speed, Line_r2_4);


        }

        private void MoveLines(int speed, System.Windows.Forms.PictureBox Line_)
        {
            if (Line_.Top >= Window_Size)
            {
                Line_.Top = 0;
            }
            else
            {
                Line_.Top += speed;
            }
        }

        void gameover()
        {
            if (PlayerCar.Bounds.IntersectsWith(enemy1.Bounds)){
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (PlayerCar.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (PlayerCar.Bounds.IntersectsWith(mk4.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (PlayerCar.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(PlayerCar.Left >0)
                    PlayerCar.Left += -str;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(PlayerCar.Right< Window_Size)
                    PlayerCar.Left += str;
            }
               /*
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
               */ 
        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void mk4_Click(object sender, EventArgs e)
        {

        }
    }
}
