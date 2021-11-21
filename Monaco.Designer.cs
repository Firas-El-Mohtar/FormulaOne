namespace FormulaOne
{
    partial class Monaco
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
            this.RightCurb = new System.Windows.Forms.PictureBox();
            this.LeftCurb = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.BarrierLeft = new System.Windows.Forms.PictureBox();
            this.BarrierRight = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.MiddleBarrier = new System.Windows.Forms.PictureBox();
            this.MonacoScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RightCurb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCurb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleBarrier)).BeginInit();
            this.SuspendLayout();
            // 
            // RightCurb
            // 
            this.RightCurb.BackgroundImage = global::FormulaOne.Properties.Resources.RedCurb;
            this.RightCurb.Location = new System.Drawing.Point(716, 81);
            this.RightCurb.Name = "RightCurb";
            this.RightCurb.Size = new System.Drawing.Size(48, 653);
            this.RightCurb.TabIndex = 0;
            this.RightCurb.TabStop = false;
            // 
            // LeftCurb
            // 
            this.LeftCurb.BackgroundImage = global::FormulaOne.Properties.Resources.RedCurb;
            this.LeftCurb.Location = new System.Drawing.Point(220, 87);
            this.LeftCurb.Name = "LeftCurb";
            this.LeftCurb.Size = new System.Drawing.Size(54, 653);
            this.LeftCurb.TabIndex = 1;
            this.LeftCurb.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackgroundImage = global::FormulaOne.Properties.Resources.Ready;
            this.Car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Car.Location = new System.Drawing.Point(475, 542);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(54, 122);
            this.Car.TabIndex = 2;
            this.Car.TabStop = false;
            // 
            // BarrierLeft
            // 
            this.BarrierLeft.BackColor = System.Drawing.Color.Red;
            this.BarrierLeft.Location = new System.Drawing.Point(572, 130);
            this.BarrierLeft.Name = "BarrierLeft";
            this.BarrierLeft.Size = new System.Drawing.Size(141, 50);
            this.BarrierLeft.TabIndex = 3;
            this.BarrierLeft.TabStop = false;
            // 
            // BarrierRight
            // 
            this.BarrierRight.BackColor = System.Drawing.Color.Red;
            this.BarrierRight.Location = new System.Drawing.Point(273, 299);
            this.BarrierRight.Name = "BarrierRight";
            this.BarrierRight.Size = new System.Drawing.Size(168, 50);
            this.BarrierRight.TabIndex = 4;
            this.BarrierRight.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // MiddleBarrier
            // 
            this.MiddleBarrier.BackColor = System.Drawing.Color.Red;
            this.MiddleBarrier.Location = new System.Drawing.Point(455, -10);
            this.MiddleBarrier.Name = "MiddleBarrier";
            this.MiddleBarrier.Size = new System.Drawing.Size(98, 50);
            this.MiddleBarrier.TabIndex = 5;
            this.MiddleBarrier.TabStop = false;
            // 
            // MonacoScore
            // 
            this.MonacoScore.AutoSize = true;
            this.MonacoScore.BackColor = System.Drawing.Color.LimeGreen;
            this.MonacoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.MonacoScore.Location = new System.Drawing.Point(21, 18);
            this.MonacoScore.Name = "MonacoScore";
            this.MonacoScore.Size = new System.Drawing.Size(62, 22);
            this.MonacoScore.TabIndex = 6;
            this.MonacoScore.Text = "Score:";
            // 
            // Monaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormulaOne.Properties.Resources.Top_View;
            this.ClientSize = new System.Drawing.Size(1019, 746);
            this.Controls.Add(this.MonacoScore);
            this.Controls.Add(this.MiddleBarrier);
            this.Controls.Add(this.BarrierRight);
            this.Controls.Add(this.BarrierLeft);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.LeftCurb);
            this.Controls.Add(this.RightCurb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Monaco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monaco";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressedDown);
            ((System.ComponentModel.ISupportInitialize)(this.RightCurb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCurb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleBarrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RightCurb;
        private System.Windows.Forms.PictureBox LeftCurb;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox BarrierLeft;
        private System.Windows.Forms.PictureBox BarrierRight;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox MiddleBarrier;
        private System.Windows.Forms.Label MonacoScore;
    }
}