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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();


            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                 );
            label1.Text = HotPocket.Carrot.ToString();
            label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            label2.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();

            CountSeedsCarrotsLable.Text = HotPocket.CarrotSeeds.ToString();
            SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }
       


        public int AmoutCarrot = 0;
        public int AmoutCarrotSeeds = 0;
        public int LabelTwo;
        public int AmoutCarrotSeedsEquales;

        ///////////////sell
        private void button2_Click(object sender, EventArgs e)
        {
            if(AmoutCarrot <= HotPocket.Carrot)
            {
                HotPocket.Carrot -= AmoutCarrot;
                HotPocket.money += AmoutCarrot * 10;
            }
            AmoutCarrot = 0;
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                  );
            label1.Text = AmoutCarrot.ToString();
        }


        /////////////////Buy
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (HotPocket.money >= LabelTwo)
            {
                HotPocket.Carrot += AmoutCarrot;
                HotPocket.money -= AmoutCarrot * 10;
            }
            AmoutCarrot = 0;
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds);
            label1.Text = AmoutCarrot.ToString();
            label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmoutCarrot++;
            LabelTwo = AmoutCarrot * 10;
            label2.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                 );
            label1.Text = AmoutCarrot.ToString();
            label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmoutCarrot--;
            LabelTwo = AmoutCarrot * 10;
            label2.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                 );
            label1.Text = AmoutCarrot.ToString();
            label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }

        private void SeedsCarrotPlus_Click(object sender, EventArgs e)
        {
            AmoutCarrotSeeds++;
            AmoutCarrotSeedsEquales = AmoutCarrotSeeds * 10;
            SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                "\nCarrot: " + HotPocket.Carrot +
                "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                );
            CountSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
        }
        private void SeedsCarrotMinus_Click(object sender, EventArgs e)
        {
            AmoutCarrotSeeds--;
            AmoutCarrotSeedsEquales = AmoutCarrotSeeds * 10;
            SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                "\nCarrot: " + HotPocket.Carrot +
                "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                );
            CountSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
        }
        private void BuySeedsCarrot_Click(object sender, EventArgs e)
        {
            if (HotPocket.money >= AmoutCarrotSeedsEquales)
            {
                HotPocket.CarrotSeeds += AmoutCarrotSeeds;
                HotPocket.money -= AmoutCarrotSeeds * 10;
            }
            
             AmoutCarrotSeedsEquales = AmoutCarrotSeeds * 10;
            AmoutCarrotSeeds = 0;
            SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                "\nCarrot: " + HotPocket.Carrot +
                "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                );
            CountSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
           
        }

        private void SellSeedsCarrots_Click(object sender, EventArgs e)
        {
            if (AmoutCarrotSeeds <= HotPocket.CarrotSeeds)
            {
                HotPocket.CarrotSeeds -= AmoutCarrotSeeds;
                HotPocket.money += AmoutCarrotSeeds * 10;
            }
            
            AmoutCarrotSeedsEquales = AmoutCarrotSeeds * 10;
            AmoutCarrotSeeds = 0;
            SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                "\nCarrot: " + HotPocket.Carrot +
                "\nCarrot Seeds: " + HotPocket.CarrotSeeds
                );
            CountSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            
        }

        
    }
}
