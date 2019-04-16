using System;
using System.Collections.Generic;

namespace customColorsAndSounds
{


    public interface IElectricPowered
    {
        double BatteryKWh { get; set; }

        void ChargeBattery();
    }

    public interface IGasPowered
    {

        double FuelCapacity { get; set; }

        void RefuelTank();
    }

    public class Zero : Vehicle, IElectricPowered
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { Console.WriteLine("Charging battery"); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {ToString()} goes Vrooom!");
        }

        public override string ToString()
        {
            return "Zero";
        }
    }
    public class Cessna : Vehicle, IGasPowered
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank() { Console.WriteLine("filling gas"); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {ToString()} goes Vrooom!");
        }
        public override string ToString()
        {
            return "Cessna";
        }
    }
    public class Tesla : Vehicle, IElectricPowered
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { Console.WriteLine("Charging battery"); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {ToString()} goes Vrooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {ToString()} turns to the {direction}!");
        }
        public override string ToString()
        {
            return "Tesla";
        }
    }
    public class Ram : Vehicle, IGasPowered
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() { Console.WriteLine("filling gas"); }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {ToString()} goes Vrooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {ToString()} stops to a halt!");
        }

        public override string ToString()
        {
            return "Ram";
        }


    }


    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"turning to the {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The car stops");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }









    class Program
    {
        static void Main(string[] args)
        {


            Zero fxs = new Zero();
            fxs.BatteryKWh = 20;
            fxs.MainColor = "blue";
            fxs.MaximumOccupancy = "four";


            Ram ram = new Ram();
            ram.FuelCapacity = 30;
            ram.MainColor = "black";
            ram.MaximumOccupancy = "two";

            Tesla tesla = new Tesla();
            tesla.BatteryKWh = 40;
            tesla.MainColor = "green";
            tesla.MaximumOccupancy = "four";

            Cessna cessna = new Cessna();
            cessna.FuelCapacity = 25;
            cessna.MainColor = "red";
            cessna.MaximumOccupancy = "two";

            List<Vehicle> cars = new List<Vehicle>() {
                ram, fxs, tesla, cessna
            };

            cars.ForEach(car =>
            {
                car.Drive();
                car.Stop();
                car.Turn("right");
            });

            /*
                Create some gas vehicles, add them to a List
                and then iterate the List to fill all of their
                fuel tanks.
            */



        }
    }
}
