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
using System.Threading;
using System.Timers;

namespace Game.Controllers
{
    class ActionControll
    {
        public static int DifferentX;
        public static int DifferentY;
        public static bool isMoving = true;
        public static bool isMoving1 = false;

        public static bool OutOfBorder = false;
        public static void ClickLeftY(Entity player, int mY)
        {
            //MessageBox.Show("2324");
            if (!OutOfBorder)
            {

                int MapI = 0;
                int MapJ = 0;
                int CenterCell = 0;
                for (int j = (mY) / MapController.cellSize; j < (mY + MapController.cellSize) / MapController.cellSize; j++)
                {
                    DifferentY = -(player.posY - (j * MapController.cellSize));
                    CenterCell = j * 32;
                    str2 = ":" + mY + "::" + player.posX + ":::" + DifferentX.ToString() + ":::" + (j * 32 + 16).ToString();
                }
                if (DifferentY != 0)
                {
                    if (player.posY < CenterCell)
                    {
                        for (int j = (player.posX) / MapController.cellSize; j < (player.posX + MapController.cellSize) / MapController.cellSize; j++)
                        {
                            for (int i = (player.posY) / MapController.cellSize; i < (player.posY + MapController.cellSize) / MapController.cellSize; i++)
                            {
                                MapI = i;
                                MapJ = j;
                            }
                        }
                        if (MapController.BigMap[MapJ, MapI + 1].Wall)
                        {
                            player.SetAnimationConfiguration(1);
                            player.posX += 1;
                            isMoving = false;
                        }
                        else
                        {
                            player.SetAnimationConfiguration(9);
                            DifferentY -= 1;
                            player.dirY = +1;
                            player.isMoving = true;
                        }
                    }
                    else if (player.posY >= CenterCell)
                    {
                        for (int j = (player.posX) / MapController.cellSize; j < (player.posX + MapController.cellSize) / MapController.cellSize; j++)
                        {
                            for (int i = (player.posY) / MapController.cellSize; i < (player.posY + MapController.cellSize) / MapController.cellSize; i++)
                            {
                                MapI = i;
                                MapJ = j;
                            }
                        }
                        if (MapController.BigMap[MapJ, MapI - 1].Wall)
                        {
                            player.SetAnimationConfiguration(1);
                            player.posX += 1;
                            isMoving = false;
                        }
                        else
                        {
                            player.SetAnimationConfiguration(1);
                            DifferentY += 1;
                            player.dirY = -1;
                            player.isMoving = true;
                        }
                    }
                    else { }
                }
                else
                {
                    player.SetAnimationConfiguration(0);
                    DifferentY = 0;
                    // isMoving = false;
                    player.isMoving = false;
                }
            }
        }
        public static bool CoordinateDone = true;
        public static void ClickLeftX(Entity player, int mX)
        {

            int MapI = 0;
            int MapJ = 0;
            int CenterCell = 0;
            for (int j = (mX) / MapController.cellSize; j < (mX + MapController.cellSize) / MapController.cellSize; j++)
            {
                DifferentX = -(player.posX - (j * MapController.cellSize));
                CenterCell = j * 32;

            }



            if (DifferentX != 0)
            {
                if (player.posX < CenterCell)
                {
                    for (int j = (player.posX) / MapController.cellSize; j < (player.posX + MapController.cellSize) / MapController.cellSize; j++)
                    {
                        for (int i = (player.posY) / MapController.cellSize; i < (player.posY + MapController.cellSize) / MapController.cellSize; i++)
                        {
                            MapI = i;
                            MapJ = j;
                        }
                    }
                    if (MapController.BigMap[MapJ + 1, MapI].Wall)
                    {
                        player.SetAnimationConfiguration(1);
                        player.posY += 1;
                    }
                    else
                    {
                        player.SetAnimationConfiguration(1);
                        DifferentX -= 1;
                        player.dirX = +1;
                        player.isMoving = true;
                    }
                }
                else if (player.posX >= CenterCell)
                {
                    for (int j = (player.posX) / MapController.cellSize; j < (player.posX + MapController.cellSize) / MapController.cellSize; j++)
                    {
                        for (int i = (player.posY) / MapController.cellSize; i < (player.posY + MapController.cellSize) / MapController.cellSize; i++)
                        {
                            MapI = i;
                            MapJ = j;
                        }
                    }
                    if (MapController.BigMap[MapJ - 1, MapI].Wall)
                    {
                        player.SetAnimationConfiguration(1);
                        player.posY += 1;
                    }
                    else
                    {
                        player.SetAnimationConfiguration(9);
                        DifferentX += 1;
                        player.dirX = -1;
                        player.isMoving = true;
                    }
                }
                else { }
            }
            else
            {
                player.SetAnimationConfiguration(0);
                //RedMarket.FirstTime = false;
                DifferentX = 0;
                isMoving = false;
                player.isMoving = false;

            }

        }

        public static void ClickRight(int mX, int mY, Entity entity, List<Seeds> seeds)
        {
            for (int j = (entity.posX) / MapController.cellSize; j < (entity.posX + MapController.cellSize) / MapController.cellSize; j++)
            {
                for (int i = (entity.posY) / MapController.cellSize; i < (entity.posY + MapController.cellSize) / MapController.cellSize; i++)
                {
                    if (i < MapController.mapHeight - 1 && i > 1 && j < MapController.mapWidth - 1 && j > 0)
                    {
                        for (int m = (mX) / MapController.cellSize; m < (mX + MapController.cellSize) / MapController.cellSize; m++)
                        {
                            for (int n = (mY) / MapController.cellSize; n < (mY + MapController.cellSize) / MapController.cellSize; n++)
                            {
                                if (j == m && i == n)
                                {
                                    ToollUse(entity, i, j, seeds);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static Bitmap Dirt_No_Water = MapController.grass.Clone(new Rectangle(32 * 17, 32 * 10, 32, 32), MapController.grass.PixelFormat);
        public static Bitmap DirtWatered = MapController.grass.Clone(new Rectangle(32 * 16, 32 * 10, 32, 32), MapController.grass.PixelFormat);

        public static int Mapi = 0;
        public static int Mapj = 0;

        public static void ToollUse(Entity entity, int i, int j, List<Seeds> seeds)
        {

            if (entity.ToolIndex == 1)
            {
                MapController.BigMap[j, i].Fon = Dirt_No_Water;
                //MessageBox.Show("234");
            }
            if (entity.ToolIndex == 3)
            {
                if (MapController.BigMap[j, i].Water)
                    entity.Water = 5;

                if (entity.Water != 0)
                {
                    if (MapController.BigMap[j, i].Fon == Dirt_No_Water)
                    {
                        MapController.BigMap[j, i].Fon = DirtWatered;
                        entity.Water--;
                    }
                    else { }
                }
            }

            if (entity.ToolIndex == 4)
            {
                int id;
                foreach (var seed in seeds)
                {
                    for (int l = 0; l < seed.roots.Count; l++)
                    {
                        if (seed.roots[l].i == i && seed.roots[l].j == j)
                        {
                            MapController.BigMap[j, i].Fon = Dirt_No_Water;
                            //id = seed.roots[l].id + 10;

                            RedMarket.fruits.Add(new Fruit(Res.fruits, i, j, seed.roots[l].id + 10));
                            seed.roots.Remove(seed.roots[l]);
                        }
                    }
                }
            }
            foreach (var seed in seeds)
            {
                if (entity.ToolIndex == 10)
                {
                    if (MapController.BigMap[j, i].Fon == DirtWatered && HotPocket.CarrotSeeds != 0)
                    {
                        HotPocket.CarrotSeeds -= 1;
                        seed.CountRoots++;

                        Roots newRoot = new Roots(i, j, 10);
                        seed.roots.Add(newRoot);
                        str = seed.CountRoots.ToString() + " " + seed.roots.Count.ToString();
                        return;
                    }
                }


                if (entity.ToolIndex == 11)
                {
                    if (MapController.BigMap[j, i].Fon == DirtWatered && HotPocket.StrawberySeeds != 0)
                    {
                        seed.CountRoots++;

                        Roots newRoot = new Roots(i, j, 11);
                        seed.roots.Add(newRoot);
                        HotPocket.StrawberySeeds--;
                        str = seed.CountRoots.ToString() + " " + seed.roots.Count.ToString();
                        return;
                    }
                }

                if (entity.ToolIndex == 12)
                {
                    if (MapController.BigMap[j, i].Fon == DirtWatered && HotPocket.CabbageSeeds != 0)
                    {
                        seed.CountRoots++;

                        Roots newRoot = new Roots(i, j, 12);
                        seed.roots.Add(newRoot);
                        HotPocket.CabbageSeeds--;
                        str = seed.CountRoots.ToString() + " " + seed.roots.Count.ToString();
                        return;
                        //seed.roots.Add(newRoot);
                    }
                }
            }
        }
        public static void CursoreView(int x, int y, Entity player)
        {
            if (player.posX < x && player.posY < y) player.PlayerView = 1;
            if (player.posX > x && player.posY > y) player.PlayerView = 3;
            if (player.posX > x && player.posY < y) player.PlayerView = 2;
            if (player.posX < x && player.posY > y) player.PlayerView = 0;

            if (player.ToolIndex == 1)
                player.SetAnimationConfiguration(4);
            else if (player.ToolIndex == 2)
                player.SetAnimationConfiguration(6);
            else if (player.ToolIndex == 3)
                player.SetAnimationConfiguration(14);
            else if (player.ToolIndex == 4)
                player.SetAnimationConfiguration(11);
            else if (player.ToolIndex == 10)
                player.SetAnimationConfiguration(10);
            else if (player.ToolIndex == 11)
                player.SetAnimationConfiguration(12);
            else if (player.ToolIndex == 12)
                player.SetAnimationConfiguration(13);
            /* else if (player.ToolIndex == 20)
                 player.SetAnimationConfiguration(7);*/
            else { }

            //str2 = ":::" + player.PlayerView.ToString();
        }

        public static bool RootMove(int x, int y)
        {
            for (int j = (x) / MapController.cellSize; j < (x + MapController.cellSize) / MapController.cellSize; j++)
            {
                for (int i = (y) / MapController.cellSize; i < (y + MapController.cellSize) / MapController.cellSize; i++)
                {
                    if (i < MapController.mapHeight - 1 && i > 1 && j < MapController.mapWidth - 1 && j > 0)
                    {
                        if (MapController.BigMap[j, i].Wall) return false;
                        else return true;
                    }
                    else
                    {
                        OutOfBorder = true;
                        return false;
                    }
                }
            }
            return true;
        }

       /* public static void Fun_E(Entity entity)
        {
            for (int j = (entity.posX + 8) / MapController.cellSize; j < (entity.posX + 8 + MapController.cellSize) / MapController.cellSize; j++)
            {
                for (int i = (entity.posY + 8) / MapController.cellSize; i < (entity.posY + 8 + MapController.cellSize) / MapController.cellSize; i++)
                {
                    if (entity.ToolIndex == 1)
                    {

                        switch (entity.PlayerView)
                        {
                            case 0:
                                if (!MapController.BigMap[j, i - 1].Wall)
                                    MapController.BigMap[j, i - 1].Fon = Res.GroundUnWatered;
                                break;
                            case 1:
                                if (!MapController.BigMap[j + 1, i].Wall)
                                    MapController.BigMap[j + 1, i].Fon = Res.GroundUnWatered;
                                break;
                            case 2:
                                if (!MapController.BigMap[j, i + 1].Wall)
                                    MapController.BigMap[j, i + 1].Fon = Res.GroundUnWatered;
                                break;
                            case 3:
                                if (!MapController.BigMap[j - 1, i].Wall)
                                    MapController.BigMap[j - 1, i].Fon = Res.GroundUnWatered;
                                break;
                        }

                    }
                }
            }
        }*/

        public static int lol = 0;
        public static void Fun_Q(Entity entity, List<Tool> tool, List<Seeds> seed)
        {
            for (int sed = 0; sed < seed.Count; sed++)
            {
                for (int i = 0; i < tool.Count; i++)
                {
                    if (!tool[i].ToolFloor)
                    {
                        for (int j = (entity.posX) / MapController.cellSize; j < (entity.posX + MapController.cellSize) / MapController.cellSize; j++)
                        {
                            for (int i1 = (entity.posY) / MapController.cellSize; i1 < (entity.posY + MapController.cellSize) / MapController.cellSize; i1++)
                            {

                                //MessageBox.Show("wer");
                                tool[i].ToolFloor = true;


                                if (entity.PlayerView == 0)
                                {
                                    if (!MapController.BigMap[j, i1 - 1].Wall)
                                    {
                                        tool[i].posY = (i1 - 1) * 32;
                                        tool[i].posX = j * 32;

                                    }
                                    // MessageBox.Show("0");
                                }
                                //tool[i].posY = (j-1) * 32;
                                if (entity.PlayerView == 1)
                                {
                                    if (!MapController.BigMap[j + 1, i1].Wall)
                                    {
                                        tool[i].posY = (i1) * 32;
                                        tool[i].posX = (j + 1) * 32;
                                    }
                                    //     MessageBox.Show("1");
                                }
                                //tool[i].posX = (i1 + 1) * 32;
                                if (entity.PlayerView == 2)
                                {
                                    if (!MapController.BigMap[j, i1 + 1].Wall)
                                    {
                                        tool[i].posY = (i1 + 1) * 32;
                                        tool[i].posX = (j) * 32;
                                    }
                                    //     MessageBox.Show("2");
                                }    //tool[i].posY = (j + 1) * 32;
                                if (entity.PlayerView == 3)
                                {
                                    if (!MapController.BigMap[j - 1, i1].Wall)
                                    {
                                        tool[i].posY = (i1) * 32;
                                        tool[i].posX = (j - 1) * 32;
                                    }
                                    //   MessageBox.Show("3");
                                }//tool[i].posX = (i1 - 1) * 32;
                            }
                        }

                        entity.ToolIndex = 0;
                        entity.ToolUse = false;
                    }
                    if (!seed[sed].SeedsFloor)
                    {
                        for (int j = (entity.posX) / MapController.cellSize; j < (entity.posX + MapController.cellSize) / MapController.cellSize; j++)
                        {
                            for (int i1 = (entity.posY) / MapController.cellSize; i1 < (entity.posY + MapController.cellSize) / MapController.cellSize; i1++)
                            {

                                //MessageBox.Show("wer");

                                seed[sed].SeedsFloor = true;

                                if (entity.PlayerView == 0)
                                {
                                    if (!MapController.BigMap[j, i1 - 1].Wall)
                                    {


                                        seed[sed].posY = (i1 - 1) * 32;
                                        seed[sed].posX = j * 32;
                                    }
                                    // MessageBox.Show("0");
                                }
                                //tool[i].posY = (j-1) * 32;
                                if (entity.PlayerView == 1)
                                {
                                    if (!MapController.BigMap[j + 1, i1].Wall)
                                    {


                                        seed[sed].posY = (i1) * 32;
                                        seed[sed].posX = (j + 1) * 32;
                                    }
                                    //     MessageBox.Show("1");
                                }
                                //tool[i].posX = (i1 + 1) * 32;
                                if (entity.PlayerView == 2)
                                {
                                    if (!MapController.BigMap[j, i1 + 1].Wall)
                                    {


                                        seed[sed].posY = (i1 + 1) * 32;
                                        seed[sed].posX = (j) * 32;
                                    }
                                    //     MessageBox.Show("2");
                                }    //tool[i].posY = (j + 1) * 32;
                                if (entity.PlayerView == 3)
                                {
                                    if (!MapController.BigMap[j - 1, i1].Wall)
                                    {


                                        seed[sed].posY = (i1) * 32;
                                        seed[sed].posX = (j - 1) * 32;
                                    }
                                    //   MessageBox.Show("3");
                                }//tool[i].posX = (i1 - 1) * 32;
                            }
                        }
                        entity.ToolIndex = 0;
                        entity.ToolUse = false;
                    }


                    for (int frut = 0; frut < RedMarket.fruits.Count; frut++)
                    {
                        if (!RedMarket.fruits[frut].FruitsFloor)
                        {
                            for (int j = (entity.posX) / MapController.cellSize; j < (entity.posX + MapController.cellSize) / MapController.cellSize; j++)
                            {
                                for (int i1 = (entity.posY) / MapController.cellSize; i1 < (entity.posY + MapController.cellSize) / MapController.cellSize; i1++)
                                {
                                    RedMarket.fruits[frut].FruitsFloor = true;

                                    if (entity.PlayerView == 0)
                                    {
                                        if (!MapController.BigMap[j, i1 - 1].Wall)
                                        {
                                            RedMarket.fruits[frut].i = (i1 - 1) * 32;
                                            RedMarket.fruits[frut].j = j * 32;
                                        }
                                    }
                                    if (entity.PlayerView == 1)
                                    {
                                        if (!MapController.BigMap[j + 1, i1].Wall)
                                        {
                                            RedMarket.fruits[frut].i = (i1) * 32;
                                            RedMarket.fruits[frut].j = (j + 1) * 32;
                                        }
                                    }
                                    if (entity.PlayerView == 2)
                                    {
                                        if (!MapController.BigMap[j, i1 + 1].Wall)
                                        {
                                            RedMarket.fruits[frut].i = (i1 + 1) * 32;
                                            RedMarket.fruits[frut].j = (j) * 32;
                                        }
                                    }   
                                    if (entity.PlayerView == 3)
                                    {
                                        if (!MapController.BigMap[j - 1, i1].Wall)
                                        {
                                           RedMarket.fruits[frut].i = (i1) * 32;
                                            RedMarket.fruits[frut].j = (j - 1) * 32;
                                        }                                     
                                    }
                                }
                            }
                            entity.ToolIndex = 0;
                            entity.ToolUse = false;
                        }
                    }
                }
            }
        }
        public static void ToolColision(Entity entity, List<Tool> tool, List<Seeds> seeds)
        {
            for (int sed = 0; sed < seeds.Count; sed++)
            {
                for (int o = 0; o < tool.Count; o++)
                {
                    if (entity.ToolUse != true)
                    {
                        for (int j = (entity.posX + 16) / MapController.cellSize; j < (entity.posX + 16 + MapController.cellSize) / MapController.cellSize; j++)
                        {
                            for (int i = (entity.posY + 16) / MapController.cellSize; i < (entity.posY + 16 + MapController.cellSize) / MapController.cellSize; i++)
                            {
                                for (int j1 = (tool[o].posX + 16) / MapController.cellSize; j1 < (tool[o].posX + 16 + MapController.cellSize) / MapController.cellSize; j1++)
                                {
                                    for (int i1 = (tool[o].posY + 16) / MapController.cellSize; i1 < (tool[o].posY + 16 + MapController.cellSize) / MapController.cellSize; i1++)
                                    {
                                        for (int sedX = (seeds[sed].posX + 16) / MapController.cellSize; sedX < (seeds[sed].posX + 16 + MapController.cellSize) / MapController.cellSize; sedX++)
                                        {
                                            for (int sedY = (seeds[sed].posY + 16) / MapController.cellSize; sedY < (seeds[sed].posY + 16 + MapController.cellSize) / MapController.cellSize; sedY++)
                                            {

                                                //str = j.ToString() + "::" + i.ToString() + "::" + j1.ToString() + "::" + i1.ToString();


                                                if (j == j1 && i == i1)
                                                {
                                                    tool[o].ToolFloor = false;
                                                    entity.ToolIndex = tool[o].ToolIndex;
                                                    entity.ToolUse = true;


                                                }
                                                else if (sedX == j && sedY == i)
                                                {
                                                    seeds[sed].SeedsFloor = false;
                                                    entity.ToolIndex = seeds[sed].SeedsIndex;
                                                    entity.ToolUse = true;

                                                }
                                                else// if()
                                                {
                                                    for (int frut = 0; frut < RedMarket.fruits.Count; frut++)
                                                    {
                                                        //str = RedMarket.fruits[frut].j.ToString() + " " + RedMarket.fruits[frut].i.ToString() + " " + j.ToString()+ " " + i.ToString();
                                                        if (RedMarket.fruits[frut].j  == j && RedMarket.fruits[frut].i  == i)
                                                        {
                                                            if (RedMarket.fruits[frut].id == 20) HotPocket.Carrot++;
                                                            else if (RedMarket.fruits[frut].id == 21) HotPocket.Strawbery++;
                                                            else if (RedMarket.fruits[frut].id == 22) HotPocket.Cabbage++;
                                                            else { }

                                                            RedMarket.fruits[frut].FruitsFloor = false;
                                                            RedMarket.fruits.Remove(RedMarket.fruits[frut]);

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                //if (j == 4 && i == 4)
                                
                                if (MapController.BigMap[j, i].NextRoom == true)
                                {
                                    if (lol == 0)
                                    {
                                        RedMarket.NexRoom = MapController.BigMap[j, i].NextRoom;
                                        MapController.BigMap[j, i].NextRoom = false;
                                        lol = 1;
                                    }
                                }
                                str = MapController.BigMap[j, i].NextRoom.ToString() + RedMarket.NexRoom.ToString();
                            }
                        }
                    }
                }
            }
        }
        public static void CursorDraw(Point cursor, Entity entity, Graphics g)
        {

            for (int j = (cursor.X) / MapController.cellSize ; j < (cursor.X + MapController.cellSize ) / MapController.cellSize; j++)
            {
                for (int i = (cursor.Y) / MapController.cellSize; i < (cursor.Y + MapController.cellSize) / MapController.cellSize; i++)
                {
                    if (i < MapController.mapHeight - 1 && i > 1 && j < MapController.mapWidth - 1 && j > 0)
                    {
                        if (MapController.BigMap[j, i].Wall)
                        {

                            g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 4), (32 * 1), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));
                        }
                        else if (MapController.BigMap[j, i].Water)
                            g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 3), (32 * 0), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));
                        else
                        {
                            g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 4), (32 * 0), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));

                            for (int pj = (entity.posX + 16) / MapController.cellSize; pj < (entity.posX + 16 + MapController.cellSize) / MapController.cellSize; pj++)
                            {
                                for (int pi = (entity.posY + 16) / MapController.cellSize; pi < (entity.posY + 16 + MapController.cellSize) / MapController.cellSize; pi++)
                                {
                                    if (i == pi && j == pj) g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 6), (32 * 1), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));

                                    //if (i == pi && j == pj + 1) g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 6), (32 * 1), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));if (i == pi - 1) ;
                                    //if (i == pi && j == pj - 1)g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 6), (32 * 1), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));

                                    //if (i == pi+1 && j == pj) g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 6), (32 * 1), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));
                                    //if (i == pi-1 && j == pj) g.DrawImage(MapController.grass.Clone(new Rectangle((32 * 6), (32 * 1), 32, 32), MapController.grass.PixelFormat), new Rectangle(MapController.cellSize * (j), MapController.cellSize * (i), MapController.cellSize, MapController.cellSize));

                                }
                            }
                        }
                    }
                }
            }
        }


        public static string str;
        public static string str2;
        public static string GetString()
        {
            return str;
        }
        public static string GetString2()
        {
            return str2;
        }

        public static bool IsCollize = false;

      


    }
}
  

