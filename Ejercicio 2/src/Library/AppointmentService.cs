using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class AppointmentService
    {
        public static int idunico = 0;
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (DataCheck.Check(name, id, phoneNumber, date, appointmentPlace, doctorName))
            {
                stringBuilder.Append("Appointment scheduled");
            }
            else
            {
                stringBuilder.Append("Unable to schedule appointment");
            }

            return stringBuilder.ToString();
        }

    }
}
/*
    Esta clase no cumple con el principio SRP, ya que tiene dos responsabilidades.
    Por un lado, crear la cita con el medico, y por el otro corroborar que los datos son validos.
*/