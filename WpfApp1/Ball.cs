using System;
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
        private int speedy;
        public int SpeedY
        {
            get { return speedy; }
            set { speedy = value; }
        }
        private int speedx;
        public int SpeedX
        {
            get { return speedx; }
            set { speedx = value; }
        }



        public Ball(int centerX, int centerY, int radius, int speedx,int speedy)
        {
            this.CenterX = centerX;
            this.CenterY = centerY;
            this.radius = radius;
            this.SpeedX = speedx;
            this.SpeedY = speedy;
        }

        public void Move()
        {
            centerX += (int)speedx;
            centerY += (int)speedy;
        }

        public void Collision(int areawidth,int areaheight)
        {
                speedx *= -1;
                speedy *= -1;

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
