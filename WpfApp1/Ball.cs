﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PongGame
{
    public class Ball : GameItem
    {
        private int centerX;

        public int CenterX
        {
            get { return centerX; }
            set { centerX = value; }
        }
        private int centerY;

        public int CenterY
        {
            get { return centerY; }
            set { centerY = value; }
        }

        private int radius;
        private Vector speed;


        public Ball(int centerX, int centerY, int radius, Vector speed)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.speed = speed;
        }

        public void Move()
        {
            centerX += (int)speed.X;
            centerY += (int)speed.Y;
        }

        public void Collision(int areawidth,int areaheight)
        {

            if (CenterX <= 0 || CenterX > areawidth - 50)
            {
                speed.X = speed.X * -1;
            }
            if (CenterY <= 0 || CenterY > areaheight - 50)
            {
                speed.Y = speed.Y * -1;
            }

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
