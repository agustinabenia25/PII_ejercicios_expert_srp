using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class DataCheck
    {
        public bool isIdValid = false;
        public static (StringBuilder, bool) Check(string name, string id, int phoneNumber, DateTime date, string appointmentPlace, string doctorName, int age, string specialty)
        {
            StringBuilder stringBuilder = new StringBuilder("DataCheck");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (IdUtils.IdIsValid(id) == false)
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required or invalid\n");
                isValid = false;
            }

            if (phoneNumber > 90999999 && phoneNumber < 100000000)
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required or invalid\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (age <= 0 || age >= 110)
            {
                stringBuilder.Append("Unable to schedule appointment, 'age' is required or invalid\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(specialty))
            {
                stringBuilder.Append("Unable to schedule appointment, 'specialty' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment scheduled\n");

            }
            return (stringBuilder, isValid);
        }
    }
}