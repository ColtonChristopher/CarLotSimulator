using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            

            //Done-Create a seperate class file called Car
            //Done-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done-Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //done-Now that the Car class is created we can instanciate 3 new cars
            //done-Set the properties for each of the cars
            //done-Call each of the methods for each car

            var fordcar = new Car();
            fordcar.Make = "Ford";
            fordcar.Model = "Focus";
            fordcar.Year = 2013;
            fordcar.EngineNoise = "vroom";
            fordcar.HonkNoise = "beep";
            fordcar.IsDrivable = true;

            lot.Cars.Add(fordcar);

            var chevycar = new Car()
            {
                Year = 2019,
                Make = "chevrolet",
                Model = "corvette",
                EngineNoise = "vroom",
                HonkNoise = "beep",
                IsDrivable = true
            };

            lot.Cars.Add(chevycar);

            var teslacar = new Car(2023, "Tesla", "Modle 3", "...", "brmmp", false);

            lot.Cars.Add(teslacar);

            fordcar.MakeEngineNoise(fordcar.EngineNoise);
            chevycar.MakeEngineNoise(chevycar.EngineNoise);
            teslacar.MakeEngineNoise(teslacar.EngineNoise);

            //*************BONUS*************//

            // done-Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
