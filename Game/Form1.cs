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
{/*
    public partial class Form1 : Form
    {
       // public Bitmap playerTexture = Res.player;

        Graphics g;
        Player player = new Player();

        public int currFrame = 0;

        // TheMap[,] BigMap = new TheMap[9,9];
        public int MapSizeX = 13;
        public int MapSizeY = 13;
        public TheMap[,] BigMap =
       {      {new TheMap(Res.Fence0,true),new TheMap(Res.Fence1,true), new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true), new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true) ,new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence2,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.GroundUnWatered),      new TheMap(Res.GroundUnWatered),      new TheMap(Res.GroundUnWatered),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),new TheMap(Res.BlueBox),    new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence3,true),new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.market_stand_red_0,true, true),new TheMap(Res.market_stand_red_4,true, true),      new TheMap(Res.market_stand_red_8, true,true),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.market_stand_red_1,true, true),new TheMap(Res.market_stand_red_5,true, true),      new TheMap(Res.market_stand_red_9,true, true),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.market_stand_red_2,true, true),new TheMap(Res.market_stand_red_6,true, true),      new TheMap(Res.market_stand_red_10,true, true),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.market_stand_red_3,true, true),new TheMap(Res.market_stand_red_7,true, true),      new TheMap(Res.market_stand_red_11,true, true),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),      new TheMap(Res.Grass1),       new TheMap(Res.Grass1),      new TheMap(Res.Grass1) ,new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Grass1),new TheMap(Res.Fence3,true)},
              {new TheMap(Res.Fence5,true),new TheMap(Res.Fence1,true), new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true, true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true), new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true) ,new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence1,true),new TheMap(Res.Fence4,true)}
        };
        Inventory inventory = new Inventory();

        public Point Position = new Point(7, 4);

        

        public int SWidth; 
        public int SHeight;

        private Point p;
        private Point p2;

        public Enemy enemy1 = new Enemy (3,3);

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            SWidth = this.Size.Width / 2;
            SHeight = this.Size.Height / 2;

            p = new Point(0, 0);

            //this.KeyDown += new KeyEventHandler(Control);
            KeyUp += new KeyEventHandler(OnKeyUp);
            KeyDown += new KeyEventHandler(OnKeyDown);
            this.KeyDown += new KeyEventHandler(ControlUp);
            //this.KeyDown += new KeyEventHandler(OnKeyUp);
            
            //DrawMap(gr);

            timer1.Start();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(UpdateAnimation);
            
            //DrawMap(gr);
            //DrawPlayer(gr);
            //Invalidate();
        }


        public bool MoveCheck = false;
        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            MoveCheck = false;
            //if(MoveCheck == true)
            //    DrawPlayer(gr);
        }
        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            MoveCheck = true;
            //if(MoveCheck == true)
            //    DrawPlayer(gr);
        }
        

        public class Player
        {
            public int View = 0;
            public Player()
            { 
                this.View = 0;
            }
           
        }
        public void DrawPlayer(Graphics gr)
        {
            gr = this.CreateGraphics();
            switch (player.View)
            {
                case 0:
                    //gr.DrawImage(Res.playerView_0, new Rectangle(112, 64, 16, 16));
                    gr.DrawImage(Res.PlayerAnimation, 112, 64, new Rectangle(new Point(32 * currFrame, 40), new Size(23, 30)), GraphicsUnit.Pixel);
                    break;
                case 1:
                    //gr.DrawImage(Res.playerView_1, new Rectangle(112, 64, 16, 16));
                    gr.DrawImage(Res.PlayerAnimation, 112, 64, new Rectangle(new Point(32 * currFrame, 40), new Size(23, 30)), GraphicsUnit.Pixel);
                    break;
                case 2:
                    //gr.DrawImage(Res.playerView_2, new Rectangle(112, 64, 16, 16));
                    gr.DrawImage(Res.PlayerAnimation, 112, 64, new Rectangle(new Point(32 * currFrame, 295), new Size(23, 30)), GraphicsUnit.Pixel);
                    break;
                case 3:
                    //gr.DrawImage(Res.playerView_3, new Rectangle(112, 64, 16, 16));
                    gr.DrawImage(Res.PlayerAnimation, 112, 64, new Rectangle(new Point(32 * currFrame, 295), new Size(23, 30)), GraphicsUnit.Pixel);
                    break;
            } 
        }


        public class Enemy
        {
            public int x = 3;
            public int y = 3;

            public Bitmap Fon = Res.Bed;
            
            public void SetXY(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public Enemy(int x, int y)
            {
                this.x = x;
                this.y = y;

                Fon = Res.Grass1;
            }
        }

        public void SetLocation(int x, Enemy enem)
        {
            switch (x)
            {
                case 0:
                    if (!BigMap[Position.X + 1, Position.Y].Wall)
                    {
                        p2.X += 10;
                        enem.x += 1;
                    }
                    else 
                    {
                        x = 2;
                    }
                    break;
                case 1:
                    if (!BigMap[Position.X, Position.Y - 1].Wall)
                    {
                        p2.Y -= 10;
                        enem.y -= 1;
                    }
                    else
                    {
                        x = 3;
                    }
                    break;
                case 2:
                    if (!BigMap[Position.X - 1, Position.Y].Wall)
                    {
                        p2.X -= 10;
                        enem.x -= 1;
                    }
                    else
                    {
                        x = 0;
                    }
                    break;
                case 3:
                    if (!BigMap[Position.X, Position.Y + 1].Wall)
                    {
                        p2.Y += 10;
                        enem.y += 1;
                    }
                    else
                    {
                        x = 1;
                    }
                    break;

            }
        }
        public static int RandMove()
        {
            Random rnd = new Random();
            int x = rnd.Next(1,4);
            return x;
        }
        int DirUp = 0;
        int DirDown = 0;
        int DirLeft = 0;
        int DirRight = 0;
       
        public void ControlUp(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.A:
                    //MoveCheck = true;
                    if (!BigMap[Position.X - 1, Position.Y].Wall)
                    {
                        p.X += 2;
                        if (DirLeft == 0) DirRight += 2;
                        if (DirLeft != 0) DirLeft -= 2;
                        if (DirRight == 16) { Position.X -= 1; DirRight = 0; }

                        player.View = 3;

                    }
                    else
                    {
                        if (DirLeft != 0) { DirLeft -= 2; p.X += 2; };
                    }
                    //MessageBox.Show("Stop"); 
                    break;
                case Keys.D:
                    //MoveCheck = true;
                    if (!BigMap[Position.X + 1, Position.Y].Wall)
                    {
                      
                        p.X -= 2;
                        if (DirRight == 0) DirLeft += 2;
                        if (DirRight != 0) DirRight -= 2;
                        if (DirLeft  == 16) { Position.X += 1; DirLeft = 0; }
                        
                        player.View = 1;
                    }
                    else
                    {
                        if (DirRight != 0) { DirRight -= 2; p.X -= 2; }
                    }
                    break;
                case Keys.S:
                    //MoveCheck = true;
                    if (!BigMap[Position.X, Position.Y + 1].Wall)
                    {
                       
                        p.Y -= 2;
                        if (DirUp == 0) DirDown += 2;
                        if(DirUp != 0) DirUp -= 2;
                        if (DirDown == 16) { Position.Y += 1; DirDown = 0; }

                        player.View = 2;
                    }
                    else
                    {
                        if (DirUp != 0) { DirUp -= 2; p.Y -= 2; }
                    }
                    break;
                case Keys.W:
                    //MoveCheck = true;
                    if (!BigMap[Position.X, Position.Y - 1].Wall)
                    {

                        p.Y += 2;
                        if (DirDown == 0) DirUp += 2;
                        if (DirDown != 0) DirDown -= 2;
                        if (DirUp >= 16) { Position.Y -= 1; DirUp = 0; }
                        //Position.Y -= 1;
                        player.View = 0;
                    }
                    else
                    {
                        if (DirDown != 0) { DirDown -= 2; p.Y += 2; }
                    }
                    break;
                case Keys.E:
                    FunE();
                    break;
                case Keys.Up:
                    player.View = 0;
                    break;
                case Keys.Down:
                    player.View = 2;
                    break;
                case Keys.Left:
                    player.View = 3;
                    break;
                case Keys.Right:
                    player.View = 1;
                    break;
            }

            //Draw();
            
            DrawMap(gr);
            //Invalidate();
            //DrawPlayer(gr);
        }
        public Graphics gr;
        public void FunE()
        {
            if (player.View == 0)
            {
                if (BigMap[Position.X, Position.Y - 1].Wall != true && BigMap[Position.X, Position.Y - 1].Fon != Res.GroundWatered && inventory.Water > 0)
                {
                    BigMap[Position.X, Position.Y - 1].Fon = Res.GroundWatered;
                    inventory.Water -= 1;
                }
                if (BigMap[Position.X, Position.Y - 1].Wall == true)
                    inventory.Water = 10;
                if(BigMap[Position.X, Position.Y - 1].RedMarket == true)
                {
                    this.Hide();
                    RedMarket form1 = new RedMarket();
                    form1.Show();
                }
            }
            if (player.View == 1)
            {
                if (BigMap[Position.X + 1, Position.Y].Wall != true && BigMap[Position.X + 1, Position.Y].Fon != Res.GroundWatered && inventory.Water > 0)
                {
                    BigMap[Position.X + 1, Position.Y].Fon = Res.GroundWatered;
                    inventory.Water -= 1;
                }
                if (BigMap[Position.X + 1, Position.Y].Wall == true)
                    inventory.Water = 10;
            }
            if (player.View == 2)
            {
                if (BigMap[Position.X, Position.Y + 1].Wall != true && BigMap[Position.X, Position.Y + 1].Fon != Res.GroundWatered && inventory.Water > 0)
                {
                    BigMap[Position.X, Position.Y + 1].Fon = Res.GroundWatered;
                    inventory.Water -= 1;
                }
                 if (BigMap[Position.X, Position.Y + 1].Wall == true)inventory.Water = 10;
            }
            if (player.View == 3)
            {
                if (BigMap[Position.X - 1, Position.Y].Wall != true && BigMap[Position.X - 1, Position.Y].Fon != Res.GroundWatered && inventory.Water > 0)
                {
                    BigMap[Position.X - 1, Position.Y].Fon = Res.GroundWatered;
                    inventory.Water -= 1;
                }
                if (BigMap[Position.X - 1, Position.Y].Wall == true)
                    inventory.Water = 10;
            }
        }
        
        public int DirX = 0;
        public int DirY = 0;
        public void DrawMap(Graphics gr)
        {
            gr = this.CreateGraphics();

            for (int i = 0; i < MapSizeY; i++)
            {
                for (int j = 0; j < MapSizeX; j++)
                {
                    gr.DrawImage(BigMap[j, i].Fon, new Rectangle(16 * j + p.X, 16 * i + p.Y, 16, 16));
                }
            }
        }


        public void UpdateAnimation(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
            if (currFrame == 7) { currFrame = 0; }
                    currFrame++;
            
            if(MoveCheck == true)
                gr.DrawImage(Res.Water, new Rectangle(122, 64, 16, 16)); 
            else
                DrawPlayer(gr);

            TextBoxInventory.Text = "Up: " + DirUp + " Down" + DirDown + " Left" + DirLeft + " Right" + DirRight + " ::" + Position.X + " " + Position.Y;
            //DrawPlayer(gr);
            //Invalidate();
        }
        

        private void Draw(object sender, PaintEventArgs e)
        {
            
            gr = e.Graphics;
            //g = this.CreateGraphics();
            //g = Graphics.FromImage(part);

            //g.DrawImage(Res.PlayerAnimation, 112, 64, new Rectangle(new Point(32 * currFrame, 40), new Size(23, 30)), GraphicsUnit.Pixel);
            //DrawMap(g);
            //g.DrawImage(Res.RedBox, 112, 64, new Rectangle(new Point(0, 0), new Size(16, 16)), GraphicsUnit.Pixel);
            //DrawPlayer(g);
            //Animation();
            // Animation(g);

            //e.Graphics.Clear(Color.Teal);
        }
    }*/
}
