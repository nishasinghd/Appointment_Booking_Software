using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    public class Office
    {
        private List<Appointment> Appointments { get; set; }

        public Office()
        {
            Appointments = new List<Appointment>();
        }
/*        public void BookAppointment()
        {
            // validate data appoint doesn't exist

        }*/

        public bool BookAppointment(DateTime AppTime, int AppDuration)
        {
            DateTime startTime = AppTime;
            DateTime endTime = AppTime.AddMinutes(AppDuration);

            foreach (var Appointment in Appointments)
            {
                DateTime existingStartTime = Appointment.AppTime;
                DateTime existingEndTime = existingStartTime.AddMinutes(Appointment.AppDuration);

                if ((startTime >= existingStartTime && startTime < existingEndTime) ||
                    (endTime > existingStartTime && endTime <= existingEndTime) ||
                    (existingStartTime >= startTime && existingEndTime <= endTime))
                {
                    // Appointment time slot is not available
                    return false;
                }
            }

            return true;

        }
        public void AddAppointment(Appointment Appointment) 
        {
            Appointments.Add(Appointment); 
        }

        public void PrintApp()
        {
            string dictionaryPath = "C:\\Temp";
            string fileName = "Appointments.txt";
            if (!Directory.Exists(dictionaryPath))
                Directory.CreateDirectory(dictionaryPath);
            string filePath = Path.Combine(dictionaryPath, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (StreamWriter writer = new StreamWriter($"{filePath}"))
            {
                string appointmentsTxt = "";
                if (Appointments.Count == 0)
                {
                    MessageBox.Show("There are currently no scheduled appointments to print");
                }
                else
                {
                    foreach (var appointment in Appointments)
                    {
                        writer.Write(appointment.Print());
                    }
                    MessageBox.Show($"Successfully printed {Appointments.Count} appointment(s) to Appointments.txt", "Printed");
                }
               
            }
        }
    }
}
