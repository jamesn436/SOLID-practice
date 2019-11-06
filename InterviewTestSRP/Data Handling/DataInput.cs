using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{
    class DataInput
    {
        public void CreateFleet()
        {
            Factory factory = new Factory(); //ioc container upgrade
            Fleet fl = factory.GetFleet();
            

            IVehicle vehicle1 = factory.GetVehicle("car");
            if (vehicle1 is ICar car1)
            {
                car1.NumSeats = 4;
                car1.NumAirBags = 3;
                car1.NumDoors = 4;
                car1.Make = "Ford";
                car1.Model = "Focus";
                car1.Reg = "BD51 SMR";
                car1.Length = 4378;
                car1.Width = 1830;
                car1.ManufacturingDate = "11/12/2016";
                car1.ManufacturingTime = "21:05";
                fl.AddToFleet(car1);

            }

            IVehicle vehicle2 = factory.GetVehicle("car");
            if (vehicle2 is ICar car2)
            {
                car2.NumSeats = 4;
                car2.NumAirBags = 4;
                car2.NumDoors = 4;
                car2.Make = "BMW";
                car2.Model = "3 Series";
                car2.Reg = "BJ57 TWM";
                car2.Length = 4639.5;
                car2.Width = 1825;
                car2.ManufacturingDate = "30/01/2019";
                car2.ManufacturingTime = "08:20";
                fl.AddToFleet(car2);
            }

            IVehicle vehicle3 = factory.GetVehicle("car");
            if (vehicle3 is ICar car3)
            {
                car3.NumSeats = 2;
                car3.NumAirBags = 2;
                car3.NumDoors = 4;
                car3.Make = "Honda";
                car3.Model = "Civic";
                car3.Reg = "HU55 SEY";
                car3.Length = 4380;
                car3.Width = 1775.8;
                car3.ManufacturingDate = "25/12/2014";
                car3.ManufacturingTime = "13:40";
                fl.AddToFleet(car3);
            }

            IVehicle vehicle4 = factory.GetVehicle("motorbike");
            if (vehicle4 is IMotorBike bike1)
            {
                bike1.SingleSeat = true;
                bike1.Modified = false;
                bike1.Make = "Harley";
                bike1.Model = "Davidson";
                bike1.Reg = "YH74 BHM";
                bike1.Length = 2215;
                bike1.Width = 815;
                bike1.ManufacturingDate = "31/12/1993";
                bike1.ManufacturingTime = "13:45";
                fl.AddToFleet(bike1);
            }

            FleetPersistence fp = factory.GetFleetPersistence();
            fp.SaveFleet(fl);
        }
    }
}
