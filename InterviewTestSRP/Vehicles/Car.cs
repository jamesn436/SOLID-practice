using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{

    public class Car : Vehicle, ICar
    {
        private int numSeats;
        private int numAirBags;
        private int numDoors;
        


        Validator v = new Validator();
        public Car(int NumOfSeats, int NumOfAirBags, int NumOfDoors, String aMake, String aModel, String aReg, double aLength, double aWidth, String aDate, String aTime, String aType)
               : base(aMake, aModel, aReg, aLength, aWidth, aDate, aTime, aType)
        {
            numAirBags = NumOfAirBags;
            numDoors = NumOfDoors;
            NumSeats = NumOfSeats;
            aType = "car";

        }

        public Car()
        {
            VehicleType = "car";
        }

        public override string ToString()
        {
            string bString = base.ToString();
            return bString + NumSeats + ',' + NumAirBags + ',' + NumDoors;
        }

        #region "get + set"
        public int NumSeats
        {
            get { return numSeats; }
            set
            {
                if (v.ValidateCarSeats(value) == true)
                {
                    numSeats = value;
                }
            }
        }

        public int NumAirBags
        {
            get { return numAirBags; }
            set
            {
                if (v.ValidateAirBags(value) == true)
                {
                    numAirBags = value;
                }
            }
        }

        public int NumDoors
        {
            get { return numDoors; }
            set
            {
                if (v.ValidateDoors(value) == true)
                {
                    numDoors = value;
                }
            }
        }
        #endregion
    }
}

