﻿using System;
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
    public partial class MainMenu1 : Form
    {
        public MainMenu1()
        {
            InitializeComponent();
            Size Screen = SystemInformation.PrimaryMonitorSize;

            Play.Location = new Point(Screen.Width / 2 - 202, Screen.Height / 4 - 100);
            Exit.Location = new Point(Screen.Width / 2 - 202, Screen.Height / 2 - 100);
            Play.Size = new Size(404, 135);
            Exit.Size = new Size(404, 135);
           
            pl.Stream = Res.music1;
          
            pl.Play();
            Play.Refresh();
        }

        private void MainMenu1_Load(object sender, EventArgs e)
        {

        }

        private void Play_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RedMarket redMarket = new RedMarket();
            RedMarket form1 = redMarket;
            form1.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        System.Media.SoundPlayer pl = new System.Media.SoundPlayer();
        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
            
        }
    }
}
