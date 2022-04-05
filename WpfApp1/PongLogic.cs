using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    
   

    public class PongLogic : IPongLogic
    {
        private int areawidth;
        private int areaheight;
        static Random r = new Random();
        public Ball ActualBall { get; set; }
        public Wall ActualWall { get; set; }
        public event EventHandler Changed;
        public event EventHandler GameOver;

        public Player ActualPlayer { get; set; }

        public enum Controls { Left, Right }
        public void Control(Controls control)
        {
            ;
            switch (control)
            {
                case Controls.Left:
                    ActualPlayer.CenterX -= 10;
                    break;
                case Controls.Right:
                    ActualPlayer.CenterX += 10;
                    break;
                default:
                    break;
            }
            Changed?.Invoke(this, null);
        }

        public PongLogic(int areawidth, int areaheight)
        {
            this.areawidth = areawidth;
            this.areaheight = areaheight;
            this.ActualBall = new Ball(r.Next(40, areawidth - 40), r.Next(40, areaheight - 40), 20, 4, 4);
            this.ActualWall = new Wall(areawidth,areaheight);
            this.ActualPlayer = new Player(areawidth, areaheight);
        }
        public void BounceBack()
        {
            if (ActualBall.CenterX <= 0 || ActualBall.CenterX > areawidth - 30)
            {
                ActualBall.SpeedX *= -1;
            }
            if (ActualBall.CenterY <= 0 || ActualBall.CenterY > areaheight - 70)
            {
                ActualBall.SpeedY *= -1;
            }
        }

        public void Timestep()
        {
            
            ActualBall.Move();
            if (!ActualBall.IsCollision(ActualWall))
            {
                if (ActualBall.IsCollision(ActualPlayer))
                {
                    ActualBall.Collision(areawidth, areaheight);
                }
                else
                {
                    BounceBack();
                }
            }
        }
    }
}
