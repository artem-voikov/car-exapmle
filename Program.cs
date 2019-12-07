    using System;

namespace myconsole
{
  
    class Program
    {
        
        static void Main(string[] args)
        {
            var car = new Car("©", 10);
            car.MoveForward();

            var isDone = true;

            while(isDone)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        car.TurnLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        car.TurnRight();
                        break;
                    case ConsoleKey.UpArrow:
                        car.MoveForward();
                        break;
                    default:
                        isDone = false;
                        break;
                }
            }
        }
    }
}
