using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{
    public class Factory
    {
        public IVehicle GetVehicle(string vehicleType)
        {
            
            if(vehicleType == null)
            {
                return null;
            }

            if (vehicleType == "car") 
            {
                return new Car();
            }

            else if (vehicleType == "motorbike")
            {
                return new MotorBike();
            }
            return null;
        }

        public FleetPersistence GetFleetPersistence()
        {
            return new FleetPersistence();
        }

        public Fleet GetFleet()
        {
            return new Fleet();
        }

       
    }
}
