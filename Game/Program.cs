using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu1());
            //Application.Run(new Form1());
            Application.Run(new RedMarket());
            //Application.Run(new Shop());
            //Application.Run(new House());



           /* for (int j = (Entity.posX + 16) / 32; j < (Entity.posX + 16 + 32) / 32; j++)
            {
                for (int i = (Entity.posY + 16) / 32; i < (Entity.posY + 16 + 32) / 32; i++)
                {
                    if (MapController.BigMap[j, i].NextRoom == true)
                    {
                        if (lol == 0)
                        {
                            RedMarket.NexRoom = MapController.BigMap[j, i].NextRoom;
                            lol = 1;
                        }
                    }
                }
            }*/
        }
    }
}
