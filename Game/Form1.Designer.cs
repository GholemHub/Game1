namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxInventory = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox1)).BeginInit();
            //this.SuspendLayout();
            // 
            // TextBoxInventory
            // 
            this.TextBoxInventory.BackColor = System.Drawing.Color.YellowGreen;
            this.TextBoxInventory.Enabled = false;
            this.TextBoxInventory.Location = new System.Drawing.Point(765, 12);
            this.TextBoxInventory.Multiline = true;
            this.TextBoxInventory.Name = "TextBoxInventory";
            this.TextBoxInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInventory.Size = new System.Drawing.Size(405, 60);
            this.TextBoxInventory.TabIndex = 1;
            this.TextBoxInventory.TabStop = false;
            this.TextBoxInventory.Text = " ";
            this.TextBoxInventory.WordWrap = false;
            // 
            // PlayerBox1
            // 
            this.PlayerBox1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBox1.Enabled = false;
            this.PlayerBox1.Location = new System.Drawing.Point(831, 269);
            this.PlayerBox1.Name = "PlayerBox1";
            this.PlayerBox1.Size = new System.Drawing.Size(66, 115);
            this.PlayerBox1.TabIndex = 2;
            this.PlayerBox1.TabStop = false;
            // 
            // Form1
            // 
            /*this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Game.Res.Water;
            this.ClientSize = new System.Drawing.Size(1208, 537);
            this.Controls.Add(this.PlayerBox1);
            this.Controls.Add(this.TextBoxInventory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            */
        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxInventory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PlayerBox1;
    }
}

