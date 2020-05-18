﻿namespace Game
{
    partial class MainMenu1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.AutoEllipsis = true;
            this.Play.BackgroundImage = global::Game.Res.Play;
            this.Play.Location = new System.Drawing.Point(385, 91);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(401, 134);
            this.Play.TabIndex = 0;
            this.Play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click_1);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::Game.Res.Exit;
            this.Exit.Location = new System.Drawing.Point(385, 587);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(381, 131);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Res.ShopWallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 772);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play);
            this.Name = "MainMenu1";
            this.Text = "MainMenu1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Exit;
    }
}