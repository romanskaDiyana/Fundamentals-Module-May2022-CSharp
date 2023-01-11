using System;
using System.Collections.Generic;
using System.Linq;

namespace _07VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //07.Vehicle Catalogue
            //Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
            //Define a class Truck with the following properties: Brand, Model, and Weight.
            //Define a class Car with the following properties: Brand, Model, and Horse Power.
            //Define a class Catalog with the following properties: Collections of Trucks and Cars.
            //You must read the input, until you receive the "end" command.
            //It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
            //In the end, you have to print all of the vehicles ordered alphabetical
            //by brand, in the following format:
            //"Cars:{ Brand}: { Model} - { Horse Power}hp
            //Trucks:{ Brand}: { Model} { Weight}kg"


            string command = Console.ReadLine();

            Catalogue catalogueOfVehicle = new Catalogue();

            while (command != "end")
            {
                string[] catalogue = command.Split("/");

                string type = catalogue[0];

                switch (type)
                {
                    case "Car":
                        Car car = new Car
                        {
                            Brand = catalogue[1],
                            Model = catalogue[2],
                            HorsePower = int.Parse(catalogue[3])
                        };

                        catalogueOfVehicle.Cars.Add(car);
                        break;


                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = catalogue[1],
                            Model = catalogue[2],
                            Weight = int.Parse(catalogue[3])
                        };

                        catalogueOfVehicle.Trucks.Add(truck);
                        break;
                }

                command = Console.ReadLine();
            }

            if (catalogueOfVehicle.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogueOfVehicle.Cars.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogueOfVehicle.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalogueOfVehicle.Trucks.OrderBy(t => t.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }


    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}
