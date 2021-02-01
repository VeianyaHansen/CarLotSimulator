using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars - DONE
            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car -DONE

            var lot = new CarLot();
            
            var myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Spark";
            myCar.Year = 2015;
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "beep";
            myCar.IsDriveable = true;

            lot.Cars.Add(myCar);

            var stevesCar = new Car()
            {
                Year = 2019, 
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = false
            };

            lot.Cars.Add(stevesCar);

            var brettsCar = new Car(2013, "Honda", "Civic", "vrroom", "honk", true);

            myCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();

            lot.Cars.Add(brettsCar);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class - DONE
            //It should have at least one property: a List of cars - DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - DONE

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
