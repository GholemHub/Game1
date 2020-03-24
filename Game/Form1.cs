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
    public partial class Form1 : Form
    {

        public Bitmap playerTexture = Res.player;
        public Bitmap animacja = Res.PlayerAnimatoin;
        public Bitmap GameBackGround = Res.backGround;

        Graphics g;
        
        public int SWidth;
        public int SHeight;

        private Point p;
        public Form1()
        {
            InitializeComponent();
            
            SWidth = this.Size.Width;
            SHeight = this.Size.Height;

            p = new Point(SWidth / 2, SHeight / 2);

            this.KeyDown += new KeyEventHandler(Control);

            DrawMap();
        }
        


        private void Control(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    p.X -= 100;
                    break;
                case Keys.Right:
                    p.X += 100;
                    break;
                case Keys.Down:
                    p.Y += 100;
                    break;
                case Keys.Up:
                    p.Y -= 100;
                    break;
            }
            DrawMap();
        }

        /*  TheMap[] BigMap =
          {
              new TheMap(),
              new TheMap(),
              new TheMap()
          };
          */

        public static object Resource1 { get; private set; }

        private void DrawMap()
        {
           pictureBox1.Size = new Size(this.Size.Width, this.Size.Height);
           pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            Image Part = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(Part);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int fielSizeX = pictureBox1.Width / 10;
                    int fielSizeY = pictureBox1.Height / 10;

                    Color c = Color.Red;                    
                    pictureBox1.Image = Part;
                    g.FillEllipse(new SolidBrush(c),
                                      i * fielSizeX,
                                      j * fielSizeY,
                                      fielSizeX,
                                      fielSizeY);
                }
            }
            g.DrawImage(playerTexture, new Rectangle(p.X, p.Y, 100, 100));
        }
    }

    public class TheMap
    {
        public Bitmap Fon = Res.player;
        TheMap(Bitmap F){ Fon = F; }
        TheMap(){ Fon = Res.player; }
    }
}
