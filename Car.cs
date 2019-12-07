using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myconsole
{
    class Car
    {
        private int padding = 10;
        private string carImage;
        private int currentSpeed;

        public int MaxSpeed { get; }

        public Car(string carImage, int maxSpeed)
        {
            this.carImage = carImage;
            MaxSpeed = maxSpeed;
        }

        public void TurnLeft()
        {
            IncreasePadding(false);
        }
        public void TurnRight()
        {
            IncreasePadding(true);
        }

        private void IncreasePadding(bool isIncrease)
        {
            if (isIncrease)
                padding++;
            else
                padding--;

            currentSpeed--;

            Print();
        }


        public void MoveForward()
        {
            if (currentSpeed > MaxSpeed)
                throw new Exception("engine is toasted");

            currentSpeed++;
            Print();
        }

        private void Print()
        {
            var padstringPadding = string.Join("", Enumerable.Repeat(" ", padding));
            Console.WriteLine($"{padstringPadding}{carImage}");
        }
    }

}
