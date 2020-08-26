﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherPacman
{
    class Score : PictureBox
    {
        private int frameCounter = 0;
        public string scoreType { get; private set; } = null;
        private Timer animationTimer = null;

        public Score(int score)
        {
            this.scoreType = "score_" + score.ToString();
            InitializeScore();
            InitializeAnimationTimer();
        }

        public void InitializeScore()
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(30, 15);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(this.scoreType);

        }
        private void InitializeAnimationTimer()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 30;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Animate();
        }

        private void Animate()
        {
            this.Top -= 1;
            
            frameCounter += 1;
            if (frameCounter > 50)
            {
                animationTimer.Stop();
                this.Dispose();
            }
        }

    }
}
