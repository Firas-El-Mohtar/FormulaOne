namespace FormulaOne
{
    partial class RedBullRing
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
            this.components = new System.ComponentModel.Container();
            this.BarrierBottom = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.BarrierTop = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BarrierBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierTop)).BeginInit();
            this.SuspendLayout();
            // 
            // BarrierBottom
            // 
            this.BarrierBottom.BackgroundImage = global::FormulaOne.Properties.Resources.Frame_1;
            this.BarrierBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BarrierBottom.Location = new System.Drawing.Point(400, 297);
            this.BarrierBottom.Name = "BarrierBottom";
            this.BarrierBottom.Size = new System.Drawing.Size(99, 137);
            this.BarrierBottom.TabIndex = 2;
            this.BarrierBottom.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackgroundImage = global::FormulaOne.Properties.Resources.pngfind_com_ferrari_car_png_2705256;
            this.Car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Car.Location = new System.Drawing.Point(12, 154);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(155, 38);
            this.Car.TabIndex = 1;
            this.Car.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FormulaOne.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-24, 433);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(821, 139);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // BarrierTop
            // 
            this.BarrierTop.BackgroundImage = global::FormulaOne.Properties.Resources.Frame_1;
            this.BarrierTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BarrierTop.Location = new System.Drawing.Point(368, 1);
            this.BarrierTop.Name = "BarrierTop";
            this.BarrierTop.Size = new System.Drawing.Size(99, 137);
            this.BarrierTop.TabIndex = 3;
            this.BarrierTop.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Score.Location = new System.Drawing.Point(8, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(55, 20);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // RedBullRing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(612, 567);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.BarrierTop);
            this.Controls.Add(this.BarrierBottom);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RedBullRing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedBullRing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BarrierBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox BarrierBottom;
        private System.Windows.Forms.PictureBox BarrierTop;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer GameTimer;
    }
}