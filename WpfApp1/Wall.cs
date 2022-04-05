using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PongGame
{
    public class Wall : GameItem
    {
        private int displayWidth;
        private int displayHeight;


        public Wall(int displayWidth,int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }

        public override Geometry Area
        {
            get
            {
                return new RectangleGeometry(new Rect(0, displayHeight-50, displayWidth, 10));
            }
        }

    }
}
