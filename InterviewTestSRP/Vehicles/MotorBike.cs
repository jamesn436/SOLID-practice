using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{
    public class MotorBike : Vehicle, IMotorBike
    {
        private Boolean singleSeat;
        private Boolean modified;

        public MotorBike(Boolean aSeat, Boolean isModified, String aMake, String aModel, String aReg, double aLength, double aWidth, String aDate, String aTime, String aType)
               : base(aMake, aModel, aReg, aLength, aWidth, aDate, aTime, aType)
        {
            singleSeat = aSeat;
            modified = isModified;
            aType = "motorbike";
        }

        public MotorBike()
        {
            VehicleType = "motorbike";
        }

        public override string ToString()
        {
            string bString = base.ToString();
            return bString + SingleSeat + ',' + modified;
        }


        #region "get + set"
        public Boolean SingleSeat
        {
            get { return singleSeat; }
            set { singleSeat = value; }
        }

        public Boolean Modified
        {
            get { return modified; }
            set { modified = value; }
        }
        #endregion
    }

}
