using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PongGame
{
    public class Player : GameItem
    {
        private int displayHeight;
        private int displayWidth;
        private int centerX;
        private int centerY;
        public int CenterX { get; set; }
        public int CenterY { get; set; }

        private int SpeedX;


        public Player(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
            centerX = displayWidth / 2;
            centerY = displayHeight - 57;
            
        }

        public override Geometry Area
        {
            get
            {
                return new RectangleGeometry(new Rect(centerX, centerY, displayWidth/10, 5));
            }
        }

  
    }
}
