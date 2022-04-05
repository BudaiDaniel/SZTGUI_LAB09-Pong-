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

        public Wall(int displayWidth)
        {
            this.displayWidth = displayWidth;
        }

        public override Geometry Area
        {
            get
            {
                return new RectangleGeometry(new Rect(0, 0, displayWidth, 5));
            }
        }

    }
}
