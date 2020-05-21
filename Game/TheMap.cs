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
    public class TheMap
    {

        public static Bitmap[,] Texture = new Bitmap[40, 36];
        public static Bitmap Texture1;
        public static Bitmap grass = new Bitmap(Res.TexturPak1);
        
        public bool NextRoom = false;
        public static void CatMap()
        {
            //Bitmap grass = new Bitmap(Res.TexturPak1);
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 36; j++)
                {
                    //Texture[i,j] = grass.Clone(new Rectangle(16*i, 16*j, 16, 16), grass.PixelFormat);
                    // = grass.Clone(new Rectangle(16*i, 16*j, 16, 16), grass.PixelFormat);
                }
            }
            Texture1 = grass.Clone(new Rectangle(16 * 0, 16 * 0, 16, 16), grass.PixelFormat);
        }

        public bool Home1 = true;

        public bool Wall = false;
        public bool Water = false;

        public int currentFrame = 0;

        public Bitmap Fon;
        //public Form1 NewForm;

        public bool RedMarket;

        public int posX;
        public int posY;

        public TheMap(Bitmap Fon) { 
            CatMap();
                this.Fon = Fon;
        }
        public TheMap(Bitmap Fon, bool Wall)
        {
            this.Fon = Fon;
            this.Wall = Wall;
        }
        
        public TheMap(Bitmap Fon, bool Wall, bool RedMarket)
        {
            this.Fon = Fon;
            this.Wall = Wall;
            this.RedMarket = RedMarket;
        }
        /*public TheMap(Bitmap Fon,bool Wall,bool Water)
        {
            this.Wall = Wall;
            this.Fon = Fon;
            this.Water = Water;
        }*/


    }
   

}
