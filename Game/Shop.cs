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
            this.KeyPreview = true;


            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
            label1.Text = 0.ToString();
            //label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            label2.Text = 0.ToString() + "*" + 10.ToString() + "=" + 0.ToString();
            CountSeedsCarrotsLable.Text = 0.ToString();

            CountSeedsCarrotsLable.Text = 0.ToString();
            //SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            BuySeedsCarrotsLable.Text = 0.ToString() + "*" + 10.ToString() + "=" + 0.ToString();

            LabelS.Text = 0.ToString();
            LabelSS.Text = 0.ToString();
            labelC.Text = 0.ToString();
            labelCS.Text = 0.ToString();

            LabelSelS.Text = 0.ToString() + "*" + 10.ToString() + "=" + 0.ToString();
            LabelBuySS.Text = 0.ToString() + "*" + 10.ToString() + "=" + 0.ToString();
            labelSellC.Text = 0.ToString() + "*" + 10.ToString() + "=" + 0.ToString();
            labelBuyCS.Text = 0.ToString() + "*" + 10.ToString() + "=" + 0.ToString();

            this.KeyDown += new KeyEventHandler(OnPress1);
            this.KeyUp += new KeyEventHandler(OnKeyUp);
        }
        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("qwe");
            //Application.Exit();
            //this.Close();
        }
        public void OnPress1(object sender, KeyEventArgs e)
        {
            MessageBox.Show("qwe");
            switch (e.KeyCode)
            {
                case Keys.Space:
                    //MessageBox.Show("qwe");
                    //Application.Exit();
                    this.Close();
                    break;
            }
        }

        public int AmoutCarrot = 0;
        public int Strawbery = 0;
        public int Cabbage = 0;

        public int AmoutCarrotSeeds = 0;
        public int StrawberySeeds = 0;
        public int CabbageSeeds = 0;


        public int LabelTwo;
        public int HelpS;
        public int HelpSS;
        public int HelpC;
        public int HelpCS;

        public int AmoutCarrotSeedsEquales;
        public int StrawberryAmout;
        public int CabbageAmout;

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
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
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
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
            label1.Text = AmoutCarrot.ToString();
            //label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmoutCarrot++;
            LabelTwo = AmoutCarrot * 10;
            label2.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
           
            
            
            
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
            label1.Text = AmoutCarrot.ToString();
            //label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmoutCarrot--;
            LabelTwo = AmoutCarrot * 10;
            label2.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
            
            
            
            
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
            label1.Text = AmoutCarrot.ToString();
            //label4.Text = AmoutCarrot.ToString() + "*" + 10.ToString() + "=" + LabelTwo.ToString();
        }

        private void SeedsCarrotPlus_Click(object sender, EventArgs e)
        {
            AmoutCarrotSeeds++;
            AmoutCarrotSeedsEquales = AmoutCarrotSeeds * 10;
            //SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            
            
            
            
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
            CountSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
        }
        private void SeedsCarrotMinus_Click(object sender, EventArgs e)
        {
            AmoutCarrotSeeds--;
            AmoutCarrotSeedsEquales = AmoutCarrotSeeds * 10;
            //SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            
            
            
            
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
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
            //SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            
            
            
            
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
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
            //SellSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            
            
            
            
            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
            CountSeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString();
            BuySeedsCarrotsLable.Text = AmoutCarrotSeeds.ToString() + "*" + 10.ToString() + "=" + AmoutCarrotSeedsEquales.ToString();
            
        }

        ///Strawberry------------------------

        private void PlusS_Click(object sender, EventArgs e)
        {
            Strawbery++;
            
            LabelS.Text = Strawbery.ToString();
            HelpS = Strawbery * 10;
            LabelSelS.Text = Strawbery.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();
           // LabelBuyS.Text = Strawbery.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );

        }
        private void MinusS_Click(object sender, EventArgs e)
        {
            Strawbery--;

            LabelS.Text = Strawbery.ToString();
            HelpS = Strawbery * 10;
            LabelSelS.Text = Strawbery.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();
           // LabelBuyS.Text = Strawbery.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }
        private void SellS_Click(object sender, EventArgs e)
        {
            if (Strawbery <= HotPocket.Strawbery)
            {
                HotPocket.Strawbery -= Strawbery;
                HotPocket.money += Strawbery * 10;
            }
            Strawbery = 0;
            HelpS = Strawbery * 10;
            LabelSelS.Text = Strawbery.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();
            LabelS.Text = Strawbery.ToString();



            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
        }

        //////////////////--------------------
        ///StrawberrySeeds
        private void PlusSS_Click(object sender, EventArgs e)
        {
            StrawberySeeds++;

            LabelSS.Text = StrawberySeeds.ToString();
            HelpSS = StrawberySeeds * 10;
            //LabelSelSS.Text = StrawberySeeds.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();
            LabelBuySS.Text = StrawberySeeds.ToString() + "*" + 10.ToString() + "=" + HelpSS.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }
        private void MinusSS_Click(object sender, EventArgs e)
        {
            StrawberySeeds--;

            LabelSS.Text = StrawberySeeds.ToString();
            HelpSS = StrawberySeeds * 10;
            //LabelSelSS.Text = StrawberySeeds.ToString() + "*" + 10.ToString() + "=" + HelpS.ToString();
            LabelBuySS.Text = StrawberySeeds.ToString() + "*" + 10.ToString() + "=" + HelpSS.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }
        private void BuySS_Click(object sender, EventArgs e)
        {
            StrawberryAmout = StrawberySeeds * 10;
                
            if(HotPocket.money >= StrawberryAmout)
            {
                HotPocket.StrawberySeeds += StrawberySeeds;
                HotPocket.money -= StrawberySeeds * 10;
            }
            
            StrawberySeeds = 0;
            LabelBuySS.Text = StrawberySeeds.ToString() + "*" + 10.ToString() + "=" + 0.ToString();
            LabelSS.Text = StrawberySeeds.ToString(); 

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
                       
        }

        //////////////////--------------------
        ///Cabbade
        private void plusC_Click(object sender, EventArgs e)
        {
            Cabbage++;

            labelC.Text = Cabbage.ToString();
            HelpC = Cabbage * 10;
            labelSellC.Text = Cabbage.ToString() + "*" + 10.ToString() + "=" + HelpC.ToString();
            //labelBuyC.Text = Cabbage.ToString() + "*" + 10.ToString() + "=" + HelpC.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }
        private void minusC_Click(object sender, EventArgs e)
        {
            Cabbage--;

            labelC.Text = Cabbage.ToString();
            HelpC = Cabbage * 10;
            labelSellC.Text = Cabbage.ToString() + "*" + 10.ToString() + "=" + HelpC.ToString();
            //labelBuyC.Text = Cabbage.ToString() + "*" + 10.ToString() + "=" + HelpC.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }

        private void sellC_Click(object sender, EventArgs e)
        {
            if (Cabbage <= HotPocket.Cabbage)
            {
                HotPocket.Cabbage -= Cabbage;
                HotPocket.money += Cabbage * 10;
            }
            Cabbage = 0;
            HelpC = Cabbage * 10;
            labelSellC.Text = Cabbage.ToString() + "*" + 10.ToString() + "=" + HelpC.ToString();
            labelC.Text = Cabbage.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
        }
        //////////////////--------------------
        ///CabbadeSeed
        private void plusCS_Click(object sender, EventArgs e)
        {
            CabbageSeeds++;

            labelCS.Text = CabbageSeeds.ToString();
            HelpCS = CabbageSeeds * 10;
            //labelSellCS.Text = CabbageSeeds.ToString() + "*" + 10.ToString() + "=" + HelpCS.ToString();
            labelBuyCS.Text = CabbageSeeds.ToString() + "*" + 10.ToString() + "=" + HelpCS.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }
        private void minusCS_Click(object sender, EventArgs e)
        {
            CabbageSeeds--;

            labelCS.Text = CabbageSeeds.ToString();
            HelpCS = CabbageSeeds * 10;
            //labelSellCS.Text = CabbageSeeds.ToString() + "*" + 10.ToString() + "=" + HelpCS.ToString();
            labelBuyCS.Text = CabbageSeeds.ToString() + "*" + 10.ToString() + "=" + HelpCS.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                  "\nCarrot: " + HotPocket.Carrot +
                  "\nStrawbery: " + HotPocket.Strawbery +
                  "\nCabbage: " + HotPocket.Cabbage +
                  "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                  "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                  "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                  );
        }

        private void buyCS_Click(object sender, EventArgs e)
        {
            CabbageAmout = CabbageSeeds * 10;

            if (HotPocket.money >= CabbageAmout)
            {
                HotPocket.CabbageSeeds += CabbageSeeds;
                HotPocket.money -= CabbageSeeds * 10;
            }

            CabbageSeeds = 0;
            labelBuyCS.Text = CabbageSeeds.ToString() + "*" + 10.ToString() + "=" + 0.ToString();
            labelCS.Text = CabbageSeeds.ToString();

            label3.Text = Convert.ToString("Money: " + HotPocket.money +
                 "\nCarrot: " + HotPocket.Carrot +
                 "\nStrawbery: " + HotPocket.Strawbery +
                 "\nCabbage: " + HotPocket.Cabbage +
                 "\nCarrot Seeds: " + HotPocket.CarrotSeeds +
                 "\nStrawbery Seeds: " + HotPocket.StrawberySeeds +
                 "\nCabbage Seeds: " + HotPocket.CabbageSeeds
                 );
        }


        //////////////////--------------------

    }
}
