using System;
using Creating_Personalized_Exceptions2.Entities;

namespace Creating_Personalized_Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out must be after Check-in");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null) {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine(reservation);
                }
            }
        }
    }
}
