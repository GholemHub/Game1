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

namespace Game.Controllers
{
    
    public static class MapController
    {
        //public static int Different = ; 

        public static Bitmap grass = new Bitmap(Res.TX32_2_1);
        public static Bitmap Ex = new Bitmap(Res.exSeeds);
        public static Bitmap grass1 = grass.Clone(new Rectangle(32 * 8, 32* 2, 32, 32), grass.PixelFormat);
        public static Bitmap grass2 = grass.Clone(new Rectangle(32 * 6, 32* 2, 32, 32), grass.PixelFormat);
        public static Bitmap road1 = grass.Clone(new Rectangle(32 * 1, 32* 18, 32, 32), grass.PixelFormat);
        public static Bitmap road2 = grass.Clone(new Rectangle(32 * 0, 32* 2, 32, 32), grass.PixelFormat);
        
        public static Bitmap Garden1 = grass.Clone(new Rectangle((32 * 29), (32 * 0), 32, 32), grass.PixelFormat);
        public static Bitmap Garden2 = grass.Clone(new Rectangle((32 * 28), (32 * 3), 32, 32), grass.PixelFormat);




        public static Bitmap house = new Bitmap(Res.House1);


        public const int mapHeight = 20;
        public const int mapWidth = 27;
        public const int cellSize = 32;

        public static TheMap[,] BigMap = new TheMap[mapWidth, mapHeight]
       {      {new TheMap(Garden1,true),new TheMap(Garden1,true), new TheMap(Garden1),new TheMap(Garden1,true),           new TheMap(Garden1,true),     new TheMap(Garden1,true) ,new TheMap(Garden1,true),   new TheMap(Garden1,true), new TheMap(Garden1) ,new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),        new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),   new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road1) ,new TheMap(road1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(road1), new TheMap(road1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1),  new TheMap(road1),  new TheMap(road1),  new TheMap(road1), new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
             {new TheMap(Garden1,true),        new TheMap(Garden1,true), new TheMap(Garden1,true),     new TheMap(Garden1,true),     new TheMap(Garden1,true),   new TheMap(Garden1,true)  ,new TheMap(Garden1,true), new TheMap(Garden1,true), new TheMap(Garden1) ,new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true)}
                 };

        public static TheMap[, ] HomeMap= new TheMap[mapWidth, mapHeight]
      {      {new TheMap(Garden1,true),new TheMap(Garden1,true), new TheMap(Garden1),new TheMap(Garden1,true),           new TheMap(Garden1,true),     new TheMap(Garden1,true) ,new TheMap(Garden1,true),   new TheMap(Garden1,true), new TheMap(Garden1) ,new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),        new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1), new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),    new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),   new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road2) ,new TheMap(road2),new TheMap(road2),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road1) ,new TheMap(road1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(road1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(road1), new TheMap(road1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),  new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1),  new TheMap(road1),  new TheMap(road1),  new TheMap(road1), new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(road1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
              {new TheMap(Garden1,true),new TheMap(Garden2),   new TheMap(grass1),   new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1), new TheMap(grass1),new TheMap(grass1) ,new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),new TheMap(grass1),                                                                                                                 new TheMap(Garden1,true)},
             {new TheMap(Garden1,true),        new TheMap(Garden1,true), new TheMap(Garden1,true),     new TheMap(Garden1,true),     new TheMap(Garden1,true),   new TheMap(Garden1,true)  ,new TheMap(Garden1,true), new TheMap(Garden1,true), new TheMap(Garden1) ,new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true),new TheMap(Garden1,true)}
                };

        public static int DiffX = 0;

        public static void DrawMap(Graphics g, RedMarket redMarket)
        {
            DiffX = redMarket.Width/2 - 432;


            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    BigMap[j, i].posX = cellSize * j ;
                    BigMap[j, i].posY = cellSize * i ;

                    g.DrawImage(BigMap[j, i].Fon, new Rectangle(cellSize * j, cellSize * i, cellSize, cellSize));
                }
            }
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    /*if(i == 0 && j == 0)
                    {
                        int xJ = j;
                        
                        for (int x = 0; x < mapWidth; x++)
                        {
                           xJ = x;
                                g.DrawImage(grass.Clone(new Rectangle( (32 * 29), (32 * 0), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j + xJ), cellSize * 0, cellSize, cellSize));
                                g.DrawImage(grass.Clone(new Rectangle((32 * 28),  (32 * 3), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j + xJ), cellSize * 1, cellSize, cellSize));

                                g.DrawImage(grass.Clone(new Rectangle((32 * 29), (32 * 0), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j + xJ), cellSize * mapHeight-1, cellSize, cellSize));
                            for (int Y = 0; Y < mapHeight; Y++)
                            {
                                int yI = Y;
                                g.DrawImage(grass.Clone(new Rectangle((32 * 29),(32 * 0), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (0), cellSize * (i + Y), cellSize, cellSize));
                                g.DrawImage(grass.Clone(new Rectangle((32 * 29),(32 * 0), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (mapWidth-1), cellSize * (i + Y), cellSize, cellSize));
                            }
                        }
                        
    
                    }*/
                    if (i == 2 && j == 14) 
                    {
                        for (int x = 0; x < 7; x++)
                        {
                            int xJ = x;

                            //g.DrawImage(grass.Clone(new Rectangle( (32 * 45),  (32 * 9), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j + xJ), cellSize * (i ), cellSize, cellSize));
                        }
                          
                    }
                    if (i == 7 && j == 12)
                    {
                        g.DrawImage(grass.Clone(new Rectangle((32 * 2), (32 * 48), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j), cellSize * (i ), cellSize, cellSize));
                        g.DrawImage(grass.Clone(new Rectangle((32 * 2), (32 * 49), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j), cellSize * (i + 1), cellSize, cellSize));
                        g.DrawImage(grass.Clone(new Rectangle((32 * 2), (32 * 50), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j), cellSize * (i + 2), cellSize, cellSize));
                                                                                                                                          
                        g.DrawImage(grass.Clone(new Rectangle((32 * 3), (32 * 48), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j+1), cellSize * (i  ), cellSize, cellSize));
                        g.DrawImage(grass.Clone(new Rectangle((32 * 3), (32 * 49), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j + 1), cellSize * (i + 1), cellSize, cellSize));
                        g.DrawImage(grass.Clone(new Rectangle((32 * 3), (32 * 50), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j + 1), cellSize * (i + 2), cellSize, cellSize));
                        
                        g.DrawImage(grass.Clone(new Rectangle((32 * 11), (32 * 48), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j - 1), cellSize * (i + 2), cellSize, cellSize));



                        BigMap[j+1, i + 1].Wall = true;
                        BigMap[j + 1, i].Wall = true;
                        BigMap[j + 1, i + 2].Wall = true;
                        BigMap[j, i + 1].Wall = true;
                        BigMap[j, i + 2].Wall = true;
                        BigMap[j, i].Wall = true;

                        BigMap[j + 1, i + 1].Water = true;
                        BigMap[j + 1, i].Water = true;
                        BigMap[j + 1, i + 2].Water = true;
                        BigMap[j, i + 1].Water = true;
                        BigMap[j, i + 2].Water = true;
                        BigMap[j, i].Water = true;

                        BigMap[j-1, i+2].Water = true;
                        
                        BigMap[21, 5].NextRoom = true;




                    }

                    if (i == 0 && j == 20)
                    {
                        int xJ = j;
                        int yI = i;
                        for (int x = 0; x < 4; x++)
                        {
                            xJ = x;
                            for (int y = 0; y < 5; y++)
                            {
                                yI = y;
                                g.DrawImage(house.Clone(new Rectangle(26 +(38*x), 32 +(32 * y), 32, 32), grass.PixelFormat), new Rectangle(cellSize * (j+xJ), cellSize * (i+ yI), cellSize, cellSize));
                                BigMap[j+xJ, i+yI].Wall = true;
                                
                                //BigMap[j+xJ, i+yI].Home1 = true;

                            }
                        }


                    }
                    
                    
                    
                }

            }
        }
    }
}
