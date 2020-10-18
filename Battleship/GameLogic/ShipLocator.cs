namespace GameLogic 
{
    public class ShipLocator 
    {
        public int x, y;
        public Ship ship;
        public ShipLocator(int x, int y, Ship ship)
        {
            this.x = x;
            this.y = y;
            this.ship = ship;
        }
    }
}