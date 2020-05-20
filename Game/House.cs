using Game.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class House : Form
    {
        public House(Entity player, RedMarket redMarket)
        {  
            InitializeComponent();
            /*
            redMarket.rrr = 12;
            label1.Text = player.posY.ToString() + " " + (redMarket.rrr).ToString();
            
            timer1.Interval = 10;
            //TimerRoots.Interval = 3000;
            PlayerTimer.Interval = 150;
            ToolsTimer.Interval = 300;

            timer1.Tick += new EventHandler(Update);
            /*PlayerTimer.Tick += new EventHandler(UpdateAnimation);
            ToolsTimer.Tick += new EventHandler(UpdateAnimationTools);
            //TimerRoots.Tick += new EventHandler(Grow);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);

            MouseDown += new MouseEventHandler(ClickMouseDown);
            MouseUp += new MouseEventHandler(ClickMouseUp);


            */
            //Init();

        }
        /*
        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.dirX = 0;
            player.dirY = 0;
            player.isMoving = false;
            player.SetAnimationConfiguration(0);
        }

        public void OnPress(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Q:
                    player.SetAnimationConfiguration(1);
                    ActionControll.Fun_Q(player, tools, seeds);
                    break;
                case Keys.E:

                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Tab:
                    //this.Hide();
                    Shop form1 = new Shop();
                    form1.ShowDialog();

                    break;
            }
        }*//*
        public void Update(object sender, EventArgs e)
        {
            if (player.isMoving)
            {
                player.Move();
            }

            if (ActionControll.isMoving && ActionControll.OutOfBorder != true) { ActionControll.ClickLeftX(player, mX); }
            else
            {
                if (ActionControll.DifferentX == 0)
                {
                    ActionControll.ClickLeftY(player, mY);
                }
            }

            relativePoint = this.PointToClient(Cursor.Position);

            if (!player.isMoving) ActionControll.CursoreView(relativePoint.X, relativePoint.Y, player);

            //textBox1.Text = relativePoint.X + "::" + relativePoint.Y;
            //textBox1.Text = player.posX + "::" + player.posX;
            //textBox2.Text = player.Water.ToString();
            //textBox2.Text = ActionControll.GetString2();
            if (NexRoom)
            {

                House redMarket = new House(player, this);
                House Home = redMarket;
                // this.Hide();
                NexRoom = false;
                Home.ShowDialog();

            }



            Invalidate();
        }
        /*
        public void UpdateAnimation(object sender, EventArgs e)
        {
            if (player.currentFrame < player.currentLimit - 1)
            {
                player.currentFrame++;
            }
            else player.currentFrame = 0;

        }
        public void UpdateAnimationTools(object sender, EventArgs e)
        {
            for (int i = 0; i < tools.Count; i++)
            {
                if (tools[i].currentFrame < tools[i].idleFrames - 1)
                {
                    tools[i].currentFrame++;
                }
                else tools[i].currentFrame = 0;
            }

            foreach (var frut in fruits)
            {
                if (frut.currentFrame < frut.idleFrames - 1)
                {
                    frut.currentFrame++;
                }
                else frut.currentFrame = 0;
            }

        }
        public void ClickMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mX = e.Location.X;
                mY = e.Location.Y;
                ActionControll.OutOfBorder = false;
                if (ActionControll.RootMove(mX, mY)) ActionControll.isMoving = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                mX = e.Location.X;
                mY = e.Location.Y;
                ActionControll.ClickRight(mX, mY, player, seeds);
                ActionControll.isMoving = true;
            }
        }
        public void ClickMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                //player.isMoving = false;
            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MapController.DrawMap(g);

        
        }
       */
    }
}
