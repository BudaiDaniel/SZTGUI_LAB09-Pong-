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

        private int SpeedX;


        public Player(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }

        public override Geometry Area
        {
            get
            {
                return new RectangleGeometry(new Rect(displayWidth/2, displayHeight-10, 50, 5));
            }
        }
    }
}
