using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car1 = new Car();

            car1.Year = 2016;
            car1.Make = "Jeep";
            car1.Model = "Cherokee";
            car1.EngineNoise = "Vroom Vroom";
            car1.HonkNoise = "Beep Beep";

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            carLot.Add(car1);


            Car car2 = new Car()
            {
                Year = 2022,
                Make = "Tesla",
                Model = "S Plaid",
                EngineNoise = "whine",
                HonkNoise = "Honk Honk"
            };

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

          carLot.Add(car2);                                                         


            Car car3 = new Car(1964, "Ford", "Mustang", "roar", "Beep Beep" );

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            carLot.Add(car3);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            for(int i = 0; i < carLot.Count; i++)
            {
                Console.WriteLine($"The {i+1}st Car in our car lot is a {carLot[i].Make} {carLot[i].Model}." +
                    $" This car was build in the year {carLot[i].Year}. ");
            }
        }
    }
}
