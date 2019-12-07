using System;
using System.Threading;

namespace myconsole
{

    class Program
    {
        static bool isDone;
        static void Main(string[] args)
        {
            var car = new Car("©", 500);
            car.MoveForward();


            Thread drawThread;
            ControllSetup(car, out drawThread);

            while (isDone)
            {
                Thread.Sleep(100);
                car.MoveForward();
            }
            Console.WriteLine("full stop");
        }

        private static void ControllSetup(Car car, out Thread drawThread)
        {
            isDone = true;
            drawThread = new Thread(() =>
            {
                while (isDone)
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
                        default:
                            isDone = false;
                            break;
                    }
                }
            });
            drawThread.Start();
        }
    }
}
