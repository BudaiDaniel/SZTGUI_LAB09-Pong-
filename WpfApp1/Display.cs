using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PongGame
{
    public class Display : FrameworkElement
    {
        IPongLogic pongLogic;

        public void SetupLogic(IPongLogic pongLogic)
        {
            this.pongLogic = pongLogic;
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (pongLogic != null)
            {
                drawingContext.DrawGeometry(Brushes.Black, null, pongLogic.ActualWall.Area);
                drawingContext.DrawGeometry(Brushes.Green,null,pongLogic.ActualBall.Area);
                drawingContext.DrawGeometry(Brushes.Aqua, null, pongLogic.ActualPlayer.Area);
                
            }
        }
    }
}
