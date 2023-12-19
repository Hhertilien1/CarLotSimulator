﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            var car1 = new Car();

            car1.Year = 2020;
            car1.Make = "Kia";
            car1.Model = "Forte";
            car1.EngineNoise = "Vroomm";
            car1.HonkNoise = "Beep";
            car1.IsDrivable = true;
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            var car2 = new Car()
            {
                Year = 2019,
                Make = "Toyoya",
                Model = "Camery",
                EngineNoise = "cling",
                HonkNoise = "peep",
                IsDrivable = false,
            };
            car2.MakeEngineNoise(car1.EngineNoise);
            car2.MakeHonkNoise(car1.HonkNoise);


            var car3 = new Car(2000, "Honda", "Acord", "STTTT", "Peep", true);
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            
           





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
