using System;

namespace myconsole
{
    internal class Engine
    {
        private readonly Action draw;
        private readonly Action moveForward;
        private readonly Action turnLeft;
        private readonly Action turnRight;

        public Engine(Action draw, Action moveForward, Action turnLeft, Action turnRight)
        {
            this.draw = draw;
            this.moveForward = moveForward;
            this.turnLeft = turnLeft;
            this.turnRight = turnRight;
        }

        internal void Go()
        {
            var isDone = true;

            while (isDone)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        turnLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        turnRight();
                        break;
                    case ConsoleKey.UpArrow:
                        moveForward();
                        break;
                    default:
                        isDone = false;
                        break;
                }
            }
        }
    }
}