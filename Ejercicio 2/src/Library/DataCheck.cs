using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class DataCheck
    {
        public bool isIdValid = false;
        public static bool Check(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            //StringBuilder stringBuilder = new StringBuilder("DataCheck");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                //stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (IdUtils.IdIsValid(id) == false)
            {
                //stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                //stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                //stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                //stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }
/*
            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");

            }
*/
            return isValid;
        }
    }
}