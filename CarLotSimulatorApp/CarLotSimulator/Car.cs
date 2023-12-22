using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {
            CarLot._numberOfCars++;
        }

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

  
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine($"My engine sounds like {EngineNoise}.");
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine($"My honk sounds like {HonkNoise}");
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
            CarLot._numberOfCars++;

            Console.WriteLine($"Current number of cars in our car Lot is : {CarLot._numberOfCars}");

        }

       

        
    }
}

