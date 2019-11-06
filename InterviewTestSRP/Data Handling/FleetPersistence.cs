using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{
    public class FleetPersistence
    {
        public String filePath = "";
        Factory factory = new Factory(); //ioc

        public void SaveFleet(Fleet fleet)
        {
            Console.WriteLine("Enter a file name to save to");
            filePath = Console.ReadLine();

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
                {
                    for (int i = 0; i < fleet.VehicleList.Count; i++)
                    {
                        file.WriteLine(fleet.VehicleList[i].ToString());
                    }
                }
            }

            catch (Exception e)
            {
                throw new ApplicationException("error : " + e, e);
            }
        }

        public void OpenFleet()
        {
            Console.WriteLine("Enter a file name to load from");
            filePath = Console.ReadLine();
            
            try
            {
                Fleet fl = factory.GetFleet();
                string[] data = System.IO.File.ReadAllLines(filePath);

                for (int i = 0; i < data.Length; i++)
                {
                    
                    string[] fields = data[i].Split(',');
                    string typeOfVehicle = (fields[0]);

                    IVehicle v1 = factory.GetVehicle(typeOfVehicle);
                    if (v1 is ICar car)
                    {
                            //conversions
                            int seats = Int32.Parse(fields[8]);
                            int airbags = Int32.Parse(fields[9]);
                            int doors = Int32.Parse(fields[10]);
                            double length = Convert.ToDouble(fields[4]);
                            double width = Convert.ToDouble(fields[5]);


                                car.NumSeats = seats;
                                car.NumAirBags = airbags;
                                car.NumDoors = doors;
                                car.Make = fields[1];
                                car.Model = fields[2];
                                car.Reg = fields[3];
                                car.Length = length;
                                car.Width = width;
                                car.ManufacturingDate = fields[6];
                                car.ManufacturingTime = fields[7];
                                Console.WriteLine(car.ToString());
                                fl.AddToFleet(car);
                            
                    }

                    else if (v1 is IMotorBike bike)
                        {
                        //conversions
                        Boolean singleSeat = Convert.ToBoolean(fields[8]);
                        Boolean isModded = Convert.ToBoolean(fields[9]);
                        double length = Convert.ToDouble(fields[4]);
                        double width = Convert.ToDouble(fields[5]);

                        bike.SingleSeat = singleSeat;
                        bike.Modified = isModded;
                        bike.Make = fields[1];
                        bike.Model = fields[2];
                        bike.Reg = fields[3];
                        bike.Length = length;
                        bike.Width = width;
                        bike.ManufacturingDate = fields[6];
                        bike.ManufacturingTime = fields[7];
                        Console.WriteLine(bike.ToString()); // create print fleet method in fleet class.
                        fl.AddToFleet(bike);
                        }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error", e);
            }
        }
    }
}
