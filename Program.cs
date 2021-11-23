using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to my Car Store\n please enjoy your visit and remember to enjoy the game!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" the weight of the Motorbike is 1\n the weight of the car is 2\n the weight of the truck is 3\n the weight of the train is 4\n");

            CargoShip Ship = new CargoShip();
            
           

            while (Ship.ShipCapacity != Ship.getCargoLoad())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("the ships capacity is: " + Ship.ShipCapacity);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("the ships has is: " + Ship.MotorBikeCount);
                Console.WriteLine("the ships has is: " + Ship.CarCount);
                Console.WriteLine("the ships has is: " + Ship.TruckCount);
                Console.WriteLine("the ships has is: " + Ship.TrainCount);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("the current weight on the ship is: " + Ship.getCargoLoad() + ", this is the total of the ship's weight");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("How many motorbikes do you want to add to the ship?\n");
                int motorbike = int.Parse(Console.ReadLine());

                Ship.MotorBikeCount = motorbike;

                Console.WriteLine("How many cars do you want to add to the ship?\n");
                int car = int.Parse(Console.ReadLine());

                Ship.CarCount = car;

                Console.WriteLine("How many trucks do you want to add to the ship?\n");
                int truck = int.Parse(Console.ReadLine());

                Ship.TruckCount = truck;

                Console.WriteLine("How many trains do you want to add to the ship?\n");
                int train = int.Parse(Console.ReadLine());

                Ship.TrainCount = train;

                if (Ship.CargoOverLoad() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("There is still space to load more!");
                }

                if (Ship.CargoOverLoad() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship is overloaded! remove items from ship");
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The ship is loaded we ready to sail!!!");
           
            Console.ReadLine();
        }
    }
}
