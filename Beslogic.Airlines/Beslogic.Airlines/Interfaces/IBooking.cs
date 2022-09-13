using Beslogic.Airlines.Models;

namespace Beslogic.Airlines.Interfaces
{
    public interface IBooking
    {
        /// <summary>
        /// This method return all bookings saved
        /// </summary>
        /// <returns>Booking saved</returns>
        public IEnumerable<Booking> GetBookings();

        /// <summary>
        /// Add a new booking to the booking list 
        /// </summary>
        /// <returns>Id of the new booking</returns>
        public int AddBooking();

        /// <summary>
        /// Delete a booking from the booking list
        /// </summary>
        /// <param name="id">Booking Id to delete</param>
        public void DeleteBooking(int id);

    }
}
