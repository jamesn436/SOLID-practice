using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP

{
    class Program
    {
        static void Main(string[] args)
            //integrate with git version control before proceding with work
        {
            Factory factory = new Factory();
            FleetPersistence fp = factory.GetFleetPersistence(); 
            DataInput di = new DataInput();
            di.CreateFleet();
            fp.OpenFleet();
            Console.ReadKey();
            ConsoleMessages.CloseProgramMessage();
        }
    }
}

