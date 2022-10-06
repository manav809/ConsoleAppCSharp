//Manav Minesh Patel

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            Console.WriteLine("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            string? Name;
            Console.WriteLine("Enter Patient Name: ");
            Name = Console.ReadLine();

            double HeightFt;
            Console.WriteLine("Enter Height in Feet: ");
            HeightFt = Convert.ToDouble(Console.ReadLine());
        
            var appointment = new Appointment { age = Age, name = Name, heightFt = HeightFt};

            var appointmentProcessor = new AppointmentProcessor();
            //var appointmentService = new AppointmentService();
            appointmentProcessor.AppointmentDone += appointmentProcessor.onAppointmentDone;
            appointmentProcessor.AppointmentArrival(appointment);

        }
    }
}