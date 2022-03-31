using System;

namespace CarLotSimulator
{
    class Program
    {
        

        public static Car Ford { get; private set; }

        static void Main(string[] args)
        {
            //TODO

            //DONE- Create a seperate class file called Car
            // DONE- Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carLot = new CarLot();

            var briannasCar = new Car();
            briannasCar.Make = "Ford";
            briannasCar.Model = "Focus";
            briannasCar.Year = 2013;
            briannasCar.EngineNoise = "vroom";
            briannasCar.HonkNoise = "beep";
            briannasCar.IsDriveable = true;

            carLot.ParkingLot.Add(briannasCar);


            var michaelsCar = new Car()
            {
                Year = 2019,
                Make = "Telsa",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = false
            };

            carLot.ParkingLot.Add(michaelsCar); 




            var sarahsCar = new Car(2013, "Honda", "Civic", "vrrroom", "vruuuuga", true);

            carLot.ParkingLot.Add(sarahsCar);

        //Call each of the methods for each car

            //briannasCar.MakeEngineNoise(briannasCar.EngineNoise);
            //michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
            //sarahsCar.MakeEngineNoise(sarahsCar.EngineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //Instantiate CarLot

            foreach (var car in carLot.ParkingLot) 
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }
            

           
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }      
         
            
    } 
    
}

