using System;

namespace Creating_Personalized_Exceptions2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for updates must be future dates";
            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after Check-in date";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "Reservation: Room "
                + RoomNumber
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
