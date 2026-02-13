using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class Seat
{
    public int SeatNo { get; set; }
    public bool IsBooked { get; set; }
    public string? BookedBy { get; set; }
}

public class TicketBookingService
{
    private List<Seat> seats = new List<Seat>();
    private ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();

    public TicketBookingService(int totalSeats)
    {
        for (int i = 1; i <= totalSeats; i++)
        {
            seats.Add(new Seat { SeatNo = i });
        }
    }

    public bool CheckAvailability(int seatNo)
    {
        _rwLock.EnterReadLock();
        try
        {
            Seat seat = seats.FirstOrDefault(s => s.SeatNo == seatNo);
            return seat != null && !seat.IsBooked;
        }
        finally
        {
            _rwLock.ExitReadLock();
        }
    }

    public bool BookSeat(int seatNo, string userId)
    {
        _rwLock.EnterWriteLock();
        try
        {
            Seat seat = seats.FirstOrDefault(s => s.SeatNo == seatNo);

            if (seat == null || seat.IsBooked)
                return false;

            seat.IsBooked = true;
            seat.BookedBy = userId;

            Console.WriteLine($"Seat {seatNo} booked by {userId}");
            return true;
        }
        finally
        {
            _rwLock.ExitWriteLock();
        }
    }
}

public class Program
{
   public static void Main()
    {
        var service = new TicketBookingService(5);

        Parallel.Invoke(
            () => Console.WriteLine(service.CheckAvailability(2)),
            () => Console.WriteLine(service.CheckAvailability(2)),
            () => service.BookSeat(2, "UserA"),
            () => service.BookSeat(2, "UserB")
        );

        Console.ReadLine();
    }
}
