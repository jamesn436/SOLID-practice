using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fleet
    {

        public List<IVehicle> VehicleList = new List<IVehicle>();

        public Fleet()
        { 
        }
        public Fleet(List<IVehicle> vehiclesInFleet)
        {
             VehicleList = vehiclesInFleet;
        }

        public void AddToFleet(IVehicle v)
        {
            VehicleList.Add(v);  
        }  
    }
}








