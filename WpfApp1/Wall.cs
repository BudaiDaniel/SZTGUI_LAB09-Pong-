using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PongGame
{
    class Wall : GameItem
    {
        private int displayWidth;
        private int displayHeight;

        public Wall(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }

        public override Geometry Area
        {
            get
            {
                GeometryGroup gg = new GeometryGroup();
                gg.Children.Add(new RectangleGeometry(new Rect(0, 0, displayWidth, 5)));
                gg.Children.Add(new RectangleGeometry(new Rect(0, 0, 5, displayHeight)));
                gg.Children.Add(new RectangleGeometry(new Rect(displayWidth - 5, 0, 5, displayHeight)));
                gg.Children.Add(new RectangleGeometry(new Rect(0, displayHeight - 5, displayWidth, 5)));
                return gg;
            }
        }

    }
}
