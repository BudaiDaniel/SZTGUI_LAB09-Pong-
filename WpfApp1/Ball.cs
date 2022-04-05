﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PongGame
{
    class Ball : GameItem
    {
        private int centerX;
        private int centerY;
        private int radius;

        private int speedX;
        private int speedY;

        public Ball(int centerX, int centerY, int radius, int speedX, int speedY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.speedX = speedX;
            this.speedY = speedY;
        }
       

        public override Geometry Area 
        {
            get
            {
                return new EllipseGeometry(new Point(centerX, centerY), radius, radius);
            }
        
        }
    }
}
