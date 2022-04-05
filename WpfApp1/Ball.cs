using System;
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

        public void CollisionY()
        {
            speed.Y *= -1;
        }
        public void CollisionX()
        {
            speed.X *= -1;
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
