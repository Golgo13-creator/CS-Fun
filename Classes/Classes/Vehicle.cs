using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { car, truck, van, motorcycle, plane, boat, spaceship}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }
        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("The vehicle is turning on");
        }
        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("The vehicle is turning off");

        }
        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }
        public void IndicateRight()
        {
            RightIndicator.Flashing();
            RightIndicator.FlashNicht();
        }
        public void IndicateLeft()
        {
            LeftIndicator.Flashing();
            LeftIndicator.FlashNicht();
        }
        public void TurnOnHazards()
        {
            RightIndicator.Flashing();
            LeftIndicator.Flashing();
        }
        public void ClearIndicators()
        {
            RightIndicator.FlashNicht();
            LeftIndicator.FlashNicht();
        }
    }
    public class Indicator
    {
        public bool IsFlashing { get; private set; }
        public void Flashing()
        {
            IsFlashing = true;
            Console.WriteLine("The flashers are on"); 
        }
        public void FlashNicht()
        {
            IsFlashing = false;
            Console.WriteLine("The flashers are off");
        }
    }
}
