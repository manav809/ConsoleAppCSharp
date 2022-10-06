//Manav Minesh Patel

using System;

namespace ConsoleApp
{
    public class Appointment : Patient
    {
        public int age { get; set; }
        public string? name { get; set; }
        public double heightFt { get; set; }

        //public int age { get; set; }
        //public string? name { get; set; }
        //public double heightFt { get; set; }
        //public Appointment(int Age, string Name)
        //{
        //    age = Age;
        //    name = Name;
        //    DateTime checkedIn = new DateTime();
        //    checkIn = checkedIn;
        //}

        public void Welcome()
        {
            Console.WriteLine("Hello, you have an appointment today with Dr. Strange");
        }
    }
    //public class Appointment
    //{
    //    public string? checkupType;
    //}
    public class AppointmentProcessor
    {
        public delegate void AppointmentFinish(object source, EventArgs args);

        public event AppointmentFinish? AppointmentDone;

        public void AppointmentArrival(Appointment appointment)
        {
            appointment.Welcome();
            Console.WriteLine($"Appointment regarding checkup of '{appointment.name}', age: '{appointment.age}', height: '{appointment.heightFt}' is happening... ");
            Thread.Sleep(4000);
        }

        protected virtual void onAppointmentDone()
        {
            if(AppointmentDone != null)
            {
                AppointmentDone = null;
            }
        }

    }
    public class AppointmentService
    {
        public void onAppointmentDone(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Virtual appointment has been completed, see you next time!");
        }
    }

}

