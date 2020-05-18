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
        public House()
        {
            InitializeComponent();

            /*this.BackgroundImage = MapController.grass.Clone(new Rectangle(32 * 8, 32 * 2, 32, 32), MapController.grass.PixelFormat);

            this.Size = new Size(MapController.mapWidth * 32 + 16, MapController.mapHeight * 32 + 39);

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



            Init();*/
        }
    }
}
