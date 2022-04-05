using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public enum Controls { Left,Right}

    public class PongLogic : IPongLogic
    {
        static Random r = new Random();
        public Ball ActualBall { get; set; }
        public Wall ActualWall { get; set; }

        public PongLogic(int areawidth, int areaheight)
        {
            this.ActualBall = new Ball(r.Next(40, areawidth - 40), r.Next(40, areaheight - 40), 20, new System.Windows.Vector(1, 1));
            this.ActualWall = new Wall(areawidth);
        }

        











        


        public void TimeStep()
        {

        }
    }
}
