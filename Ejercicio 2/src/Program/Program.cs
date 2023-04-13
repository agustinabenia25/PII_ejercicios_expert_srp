using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService appointment1 = new AppointmentService("Steven Jhonson", "4.921.839-5", 986782342, DateTime.Now, "Wall Street", "Armand", 25, "Cardiologo");
            Console.WriteLine(appointment1.texto);

            AppointmentService appointment2 = new AppointmentService("Ralf Manson", "5555-555-555", 0, DateTime.Now, "Queen Street", "", -13, "");
            Console.WriteLine(appointment2.texto);
        }
    }
}
