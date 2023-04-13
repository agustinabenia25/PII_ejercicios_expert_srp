using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class AppointmentService
    {
        public int idunico {get ; set ;}
        public string texto {get ; set ;}
        private static int count = 52367;
        public AppointmentService(string name, string id, int phoneNumber, DateTime date, string appointmentPlace, string doctorName, int age, string specialty)
        {
            this.idunico = count;
            count++;
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            var resultado = DataCheck.Check(name, id, phoneNumber, date, appointmentPlace, doctorName, age, specialty);
            stringBuilder.Append(resultado.Item1);
            if (resultado.Item2)
            {
                stringBuilder.Append($"Appointment Reference Number: {this.idunico}\n");
            }

            this.texto = stringBuilder.ToString();
        }

    }
}
/*
    Esta clase no cumple con el principio SRP, ya que tiene dos responsabilidades.
    Por un lado, crear la cita con el medico, y por el otro corroborar que los datos son validos.
*/