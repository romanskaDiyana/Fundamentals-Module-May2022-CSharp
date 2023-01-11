using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Vehicle Catalogue
            //Until you receive the "End" command, you will be receiving lines of
            //input in the following format:
            //            "{typeOfVehicle} {model} {color} {horsepower}"
            //When you receive the "End" command, you will start receiving
            //information about some vehicles.
            //For every vehicle, print out the information about it in the
            //following format:
            //            "Type: {typeOfVehicle}
            //Model: { modelOfVehicle}
            //        Color: { colorOfVehicle}
            //        Horsepower: { horsepowerOfVehicle}
            //            "

            //When you receive the "Close the Catalogue" command, print out the average
            //horsepower of the cars and the average horsepower of the trucks in the format:
            //"{typeOfVehicles} have average horsepower of {averageHorsepower}."
            //The average horsepower is calculated by dividing the sum of the horsepower
            //of all vehicles of the given type by the total count of all vehicles from that type.
            //Format the answer to the second digit after the decimal point.
            //Constraints
            //    • The type of vehicle will always be either a car or a truck.
            //    • You will not receive the same model twice.
            //    • The received horsepower will be an integer in the range[1…1000].
            //    • You will receive at most 50 vehicles.
            //    • The separator will always be single whitespace.

            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs[0] == "End")
                {
                    break;
                }

                VehicleType vehicleType;

                bool isVehicleTypeParseSuccessful = Enum.TryParse(inputArgs[0], true, out vehicleType);

                if (isVehicleTypeParseSuccessful)
                {
                    string vehicleModel = inputArgs[1];
                    string vehicleColor = inputArgs[2];
                    double vehicleHorsePower = double.Parse(inputArgs[3]);

                    var currentVehicle = new Vehicle(vehicleModel, vehicleColor, vehicleHorsePower, vehicleType);

                    vehicles.Add(currentVehicle);
                }
            }

            while (true)
            {
                string cmds = Console.ReadLine();

                if (cmds == "Close the Catalogue")
                {
                    break;
                }

                var searchedVehicle = vehicles.FirstOrDefault(x => x.Model == cmds);

                Console.WriteLine(searchedVehicle);
            }

            var cars = vehicles.Where(x => x.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(x => x.Type == VehicleType.Truck).ToList();

            double carsAverageHoursePower = cars.Count > 0 ? cars.Average(x => x.HorsePower) : 0.00;
            double trucksAverageHoursePower = trucks.Count > 0 ? trucks.Average(x => x.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHoursePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHoursePower:f2}.");

        }
    }

    enum VehicleType
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Vehicle(string model, string color, double horsePower, VehicleType type)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public VehicleType Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();


        }

    }
}
