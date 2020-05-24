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


    public partial class RedMarket : Form
    {
        public static Point Different; 
        public int rrr = 100;
        Entity player;

        Tool Shovel;
        Tool Axe;
        Tool Bailer;
        Tool Scythe;

        Seeds Carrot;
        Seeds Strawberry;
        Seeds Cabbage;


        public Point relativePoint;

        public List<Tool> tools = new List<Tool>();
        public List<Seeds> seeds = new List<Seeds>();
        public static List<Fruit> fruits = new List<Fruit>();

        public int mX;
        public int mY;

        public static bool NexRoom = false;

        

        //public HotPocket Pocket { get => pocket; set => pocket = value; }

        public RedMarket()
        {
            InitializeComponent();
            Different = new Point((this.Width),(this.Height));


            this.BackgroundImage = MapController.grass.Clone(new Rectangle(32 * 8, 32 * 2, 32, 32), MapController.grass.PixelFormat);

            this.Size = new Size(MapController.mapWidth * 32, MapController.mapHeight * 32);

            timer1.Interval = 10;
            TimerRoots.Interval = 3000;
            PlayerTimer.Interval = 150;
            ToolsTimer.Interval = 300;

            timer1.Tick += new EventHandler(Update);
            PlayerTimer.Tick += new EventHandler(UpdateAnimation);
            ToolsTimer.Tick += new EventHandler(UpdateAnimationTools);
            TimerRoots.Tick += new EventHandler(Grow);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);

            MouseDown += new MouseEventHandler(ClickMouseDown);
            MouseUp += new MouseEventHandler(ClickMouseUp);
            
            

            Init();
        }
        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.dirX = 0;
            player.dirY = 0;
            player.isMoving = false;
            player.SetAnimationConfiguration(0);
        }
        public Shop shop = null;
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

                    //Shop shop = new Shop();
                    //shop.ShowDialog();

                    //Application.Run(new Shop());
                    
                    
                        shop = new Shop();
                        shop.ShowDialog();
                    
                    break;

            }
        }

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

            
            //textBox1.Text = player.posX + "::" + player.posX;
            //textBox2.Text = player.Water.ToString();
            //textBox2.Text = ActionControll.GetString2();
            if (NexRoom)
            {
               
                House redMarket = new House(player,this);
                House Home = redMarket;
                // this.Hide();
                NexRoom = false;
                Home.ShowDialog();
                
            }



            Invalidate();
        }

        //static void Main()


        public void Grow(object sender, EventArgs e)
        {
            for (int i = 0; i < seeds.Count; i++)
            {

                if (seeds[i].CountRoots != 0)
                {


                    foreach (var root in seeds[i].roots)
                    {
                        
                        //MessageBox.Show("qwe");
                        if (root.id == 10)
                        {
                            MapController.BigMap[root.j, root.i].Fon = MapController.Ex.Clone(new Rectangle(32 * root.currentFrame, 32, 32, 32), MapController.grass.PixelFormat);
                        }
                        if (root.id == 11)
                            MapController.BigMap[root.j, root.i].Fon = MapController.Ex.Clone(new Rectangle(32 * root.currentFrame, 0, 32, 32), MapController.grass.PixelFormat);
                        if (root.id == 12)
                            MapController.BigMap[root.j, root.i].Fon = MapController.Ex.Clone(new Rectangle(32 * root.currentFrame, 32 * 2, 32, 32), MapController.grass.PixelFormat);

                        if (root.currentFrame < root.idleFrames - 1)
                            root.currentFrame++;
                    }
                }

            }

        }
        public void Init()
        {
            player = new Entity(200, 100, 3, 7, Res.RedBox);
            //HotPocket Pocket = new HotPocket(200);
            Shovel = new Tool(Res.shovel, 100, 100, 1);
            Axe = new Tool(Res.shovel, 50, 100, 2);
            Scythe = new Tool(Res.shovel, 100, 70, 4);
            Bailer = new Tool(Res.shovel, 100, 150, 3);

            Carrot = new Seeds(Res.Seeds, 150, 60,10);
            Strawberry = new Seeds(Res.Seeds, 183, 60,11);
            Cabbage = new Seeds(Res.Seeds, 215, 60,12);

            seeds.Add(Carrot);
            seeds.Add(Strawberry);
            seeds.Add(Cabbage);

            tools.Add(Shovel);
            tools.Add(Axe);
            tools.Add(Bailer);
            tools.Add(Scythe);

            timer1.Start();
            mX = player.posX;
            mY = player.posY;
        }

        private void RedMarket_Load(object sender, EventArgs e)
        {

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

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MapController.DrawMap(g, this);

            textBox1.Text = this.Width.ToString() + " " + this.Height.ToString();
            //textBox2.Text = ActionControll.str;
            label1.Text = Convert.ToString("Money: " + HotPocket.money +
                "\nCarrot: " + HotPocket.Carrot +
                "\nStrawbery: " + HotPocket.Strawbery+
                "\nCabbage: " + HotPocket.Cabbage +
                "\nCarrot Seeds: " + HotPocket.CarrotSeeds+
                "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                );

            player.PlayAnimation(g);

            for (int i = 0; i < tools.Count; i++)
                tools[i].Draw(g, player);

            for (int i = 0; i < seeds.Count; i++)
                seeds[i].Draw(g, player);

            foreach (var fruit in fruits)
            {
                fruit.Draw(g, player);
            }


            ActionControll.CursorDraw(relativePoint, player, g);
            ActionControll.ToolColision(player, tools, seeds);

        }

        private void PlayerTimer_Tick(object sender, EventArgs e)
        {
            // MessageBox.Show("qwr");
            /*if (player.currentFrame < player.currentLimit - 1) player.currentFrame++;
            else player.currentFrame = 0;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("qwr");
        }
    }

    public class Fruit
    {
        public int i;
        public int j;

        public int id;

        public bool FruitsFloor = false;

        public  int idleFrames = 4;
        public  int currentFrame = 0;
        public int currentLimit;

        public Image texture;

        public Fruit(Image texture, int i, int j, int id)
        {
            this.i = i;
            this.j = j;
            this.id = id;
            this.texture = texture;

            this.FruitsFloor = true;
        }
        public void Draw(Graphics g, Entity player)
        {
            if (FruitsFloor)
            {
                if (this.id == 20)
                    g.DrawImage(this.texture, new Rectangle(new Point(32 * j, 32 * i), new Size(28, 28)), 32 * currentFrame, 0, 32, 32, GraphicsUnit.Pixel);

                if (this.id == 21)
                    g.DrawImage(this.texture, new Rectangle(new Point(32 * j, 32 * i), new Size(28, 28)), 32 * currentFrame, 32*5, 32, 32, GraphicsUnit.Pixel);

                if (this.id == 22)
                    g.DrawImage(this.texture, new Rectangle(new Point(32 * j, 32 * i), new Size(28, 28)), 32 * currentFrame, 32*4, 32, 32, GraphicsUnit.Pixel);
            }
            if (!FruitsFloor)
            {
                if (player.ToolIndex == 20)
                {
                    //player.SetAnimationConfiguration(7);
                }
                /*
                if (player.ToolIndex == 2)
                    player.SetAnimationConfiguration(14);

                if (player.ToolIndex == 3)
                    player.SetAnimationConfiguration(4);

                if (player.ToolIndex == 4)
                    player.SetAnimationConfiguration(11);*/
            }

        }
    }
    public class Roots
    {
        public int i;
        public int j;

        public int id;

        public int idleFrames = 4;
        public int currentFrame = 0;
        public int AnimationFrame;
        public Roots(int i, int j, int id)
        {
            this.i = i;
            this.j = j;
            this.id = id;
        }

    }
    public class Seeds
    {
        public List<int> roots2 = new List<int>();
        public List<Roots> roots = new List<Roots>();
        

        public int CountRoots = 0;

        public int posX;
        public int posY;

        public int MapPosX;
        public int MapPosY;

        public static int idleFrames = 4 ;
        public static int currentFrame = 0;
        public int currentLimit;


        public int SeedsIndex;

        public bool SeedsFloor;

        public static int AmountSeeds = 5;

        public Image texture;
        public Seeds(Image texture, int posX, int posY, int SeedsIndex)
        {
            this.texture = texture;
            this.posX = posX;
            this.posY = posY;

            this.SeedsIndex = SeedsIndex;
            this.SeedsFloor = true;
        }
        //public void DrawPl()
        public void Draw(Graphics g, Entity player)
        {

            if (this.SeedsFloor)
            {
                if (this.SeedsIndex == 10)
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY ), new Size(28, 28)), 0, 0, 32, 32, GraphicsUnit.Pixel);
                if (this.SeedsIndex == 11)
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY), new Size(28, 28)), 32 , 0, 32, 32, GraphicsUnit.Pixel);
                if (this.SeedsIndex == 12)                                      
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY), new Size(28, 28)), 32 * 2 , 0, 32, 32, GraphicsUnit.Pixel);
            }
            if (!this.SeedsFloor)
            {
                if (player.ToolIndex == 10)
                   player.SetAnimationConfiguration(7);
                /*
                if (player.ToolIndex == 2)
                    player.SetAnimationConfiguration(14);

                if (player.ToolIndex == 3)
                    player.SetAnimationConfiguration(4);*/

            }

        }
    }
    public class Tool
    {
        public int posX;
        public int posY;

        public int MapPosX;
        public int MapPosY;

        public int idleFrames = 5;
        public int currentFrame = 0;
        public int currentLimit;


        public int ToolIndex;

        public bool ToolFloor;

        public Image texture;
        public Tool(Image texture, int posX, int posY, int ToolIndex)
        {
            this.texture = texture;
            this.posX = posX;
            this.posY = posY;
            
            this.ToolIndex = ToolIndex;
            this.ToolFloor = true;
        }
        //public void DrawPl()
        public void Draw(Graphics g, Entity player)
        {

            if (this.ToolFloor)
            {
                if (this.ToolIndex == 1)
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY), new Size(28, 28)), 32 * currentFrame, 32, 32, 32, GraphicsUnit.Pixel);
                if (this.ToolIndex == 2)
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY), new Size(28, 28)), 32 * currentFrame, 0, 32, 32, GraphicsUnit.Pixel);
                if (this.ToolIndex == 3)
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY), new Size(28, 28)), 32 * currentFrame, 32 * 2, 32, 32, GraphicsUnit.Pixel);
                if (this.ToolIndex == 4)
                    g.DrawImage(this.texture, new Rectangle(new Point(posX, posY), new Size(28, 28)), 32 * currentFrame, 32 * 3, 32, 32, GraphicsUnit.Pixel);
            }
            if(!this.ToolFloor)
            {
                if (player.ToolIndex == 1)
                    player.SetAnimationConfiguration(4);

                if (player.ToolIndex == 2)
                    player.SetAnimationConfiguration(14);

                if (player.ToolIndex == 3)
                    player.SetAnimationConfiguration(4);

                //if (player.ToolIndex == 4)
                    //player.SetAnimationConfiguration(11);
                /*
                if (player.ToolIndex == 20)
                    player.SetAnimationConfiguration(7);*/
            }
            
        }
    }
    public class Entity
    {

        public int Water = 5;

        public int posX;
        public int posY;

        public int MapPosX = 4;
        public int MapPosY = 7;

        public int currentLimit;

        public int idleFrames = 13;
        public int runFrames = 8;

        public bool isMoving;

        public int currentAniation = 0;
        public int currentFrame = 0;

        public int size = 32;

        public  int dirX;
        public  int dirY;

        public int PlayerView;

        public int ToolIndex = 0;

        public bool ToolUse = false;
        public bool FrutsUse = true;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int runFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;

            this.idleFrames = idleFrames;
            this.runFrames = runFrames;


            //currentAniation = 0;
            //currentFrame = 0;
            currentLimit = idleFrames;

            //size = 32;

            this.spriteSheet = spriteSheet;

        }
        public void Move()
        {
            if (ActionControll.CoordinateDone)
            {
                if (ActionControll.isMoving) posX += dirX;
                if (!ActionControll.isMoving) posY += dirY;
            }
        }
        public void PlayAnimation(Graphics g)
        {
       
            if (this.PlayerView == 0)
                g.DrawImage(Res.PlayerAnimation, new Rectangle(new Point(posX, posY), new Size(size, size)), 32 * currentFrame, 32 * currentAniation, size, size, GraphicsUnit.Pixel);
            if (this.PlayerView == 1)
                g.DrawImage(Res.PlayerAnimation, new Rectangle(new Point(posX, posY), new Size(size, size)), 32 * currentFrame, 32 * currentAniation, size, size, GraphicsUnit.Pixel);
            if (this.PlayerView == 2)
                g.DrawImage(Res.PlayerAnimation, new Rectangle(new Point(posX, posY), new Size(size, size)), 32 * currentFrame, 32 * currentAniation, size, size, GraphicsUnit.Pixel);
            if (this.PlayerView == 3)
                g.DrawImage(Res.PlayerAnimation, new Rectangle(new Point(posX, posY), new Size(size, size)), 32 * currentFrame, 32 * currentAniation, size, size, GraphicsUnit.Pixel);
        }

        public void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAniation = currentAnimation;

            switch (currentAniation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = runFrames;
                    break;
                case 4:
                    currentLimit = runFrames;
                    break;
                case 6:
                    currentLimit = runFrames;
                    break;
                case 7:
                    currentLimit = runFrames;
                    break;
                case 9:
                    currentLimit = runFrames;
                    break;
                /*case 11:
                    currentLimit = runFrames;
                    break;*/
                case 14:
                    currentLimit = runFrames;
                    break;
            }
        }
    }
    public class HotPocket
    {
        public static int money = 200;

        public static int Carrot = 0;
        public static int Strawbery = 0;
        public static int Cabbage = 0;
        public static int CarrotSeeds= 2;
        public static int StrawberySeeds= 2;
        public static int CabbageSeeds= 200;

        public HotPocket(int money)
        {
            money = money;
        }
        public static void ConstHotPocket(int money1)
        {
            money = money1;
        }

    }
}

