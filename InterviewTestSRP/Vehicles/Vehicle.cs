using System;


namespace InterviewTestSRP
{
    public abstract class Vehicle : IVehicle
    {
        protected String make;
        protected String model;
        protected String reg;
        protected double length;
        protected double width;
        protected String manufacturingDate;
        protected String manufacturingTime;
        protected String vehicleType;



        Validator v = new Validator();
        protected Vehicle(String aMake, String aModel, String aReg, double aLength, double aWidth, String aDate, String aTime, String aType)
        {
            make = aMake;
            model = aModel;
            reg = aReg;
            length = aLength;
            width = aWidth;
            manufacturingDate = aDate;
            manufacturingTime = aTime;
            vehicleType = aType;
        }

        public Vehicle()
        {

        }
        public virtual string ToString()
        {
            return VehicleType + ',' + Make + ',' + Model + ',' + Reg + ',' + Length + ',' + Width + ',' + ManufacturingDate + ',' + ManufacturingTime + ',';
        }

        #region "get + set"

        public String VehicleType
        {
            get { return vehicleType; }
            protected set { vehicleType = value; }
        }
        public String Make
        {
            get { return make; }
            set { make = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String Reg
        {
            get { return reg; }

            set
            {
                if (v.ValidateReg(value) == true)
                {
                    reg = value;
                }
            }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public String ManufacturingDate
        {
            get { return manufacturingDate; }
            set
            {
                if (v.ValidateDate(value) == true)
                {
                    manufacturingDate = value;
                }
            }
        }

        public String ManufacturingTime
        {
            get { return manufacturingTime; }
            set
            {
                if (v.ValidateTime(value) == true)
                {
                    manufacturingTime = value;
                }

            }
        }
        #endregion
    }

}
