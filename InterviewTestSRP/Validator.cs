using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewTestSRP
    //bug, validation only works through setter not constructor, fix
{
    public class Validator 
    {
        //regular expressions for data validation
        private readonly String RegIDRegExp = @"^([A-HK-PRSVWY][A-HJ-PR-Y])\s?([0][2-9]|[1-9][0-9])\s?[A-HJ-PR-Z]{3}$";
        private readonly String TimeRegExp = @"^(?:[01][0-9]|2[0-3]):[0-5][0-9]$";
        private readonly String DateRegExp = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)? (?:0[48]|[2468] [048]|[13579] [26])|(?:(?:16|[2468][048]|[3579] [26])00))))$|^(?:0?[1 - 9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1 - 9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";

        public bool ValidateCarSeats(int seats)
        {
            if (seats <= 8 && seats > 0)
            {
                return true;
            }

            else
            {
                ConsoleMessages.InvalidCarSeats(seats);
                return false;
            }
        }

        public bool ValidateAirBags(int bags)
        {
            if (bags <= 10 && bags > 0)
            {
                return true;
            }

            else
            {
                ConsoleMessages.InvalidAirBags(bags);
                return false;
            }
        }

        public bool ValidateDoors(int doors)
        {
            if (doors <= 5 && doors >= 2)
            {
                return true;
            }

            else
            {
                ConsoleMessages.InvalidDoors(doors);
                return false;
            }
        }

        public bool ValidateReg(string registration)
        {
           if (Regex.Match(registration, RegIDRegExp).Success)
           {
                return true;
           }

           else
           {
                ConsoleMessages.InvalidReg(registration);
                return false;
           }
        }

        public bool ValidateDate(String date)
        {
            if (Regex.Match(date, DateRegExp).Success)
            {
                return true;
            }

            else
            {
                ConsoleMessages.InvalidDate(date);
                return false;
            }
        }

        public bool ValidateTime(String time)
        {
            if (Regex.Match(time, TimeRegExp).Success)
            {
                return true;
            }

            else
            {
                ConsoleMessages.InvalidTime(time);
                return false;
            }
        }
    }

 }

