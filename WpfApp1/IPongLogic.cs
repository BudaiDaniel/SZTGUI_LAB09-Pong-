namespace PongGame
{
    public interface IPongLogic
    {
        Ball ActualBall { get; set; }
        Wall ActualWall { get; set; }

        Player ActualPlayer { get; set; }
    }
}