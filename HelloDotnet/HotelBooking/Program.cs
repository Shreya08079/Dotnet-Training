using System;
using System.Collections.Generic;

public class Room{
    public int RoomNumber{ get; set;}
    public string RoomType{get; set;}
    public double PricePerNight{get; set;}
    public bool IsAvailable{get; set;}
}

public class HotelManager
{
    private Dictionary<int, Room> _rooms = new Dictionary<int , Room>();

    public void AddRoom(int roomNumber, string type, double price){
        if(_rooms.ContainsKey(roomNumber)){
            Console.WriteLine("Room already exists.");
            return;
        }

        Room room = new Room{
            RoomNumber = roomNumber,
            RoomType = type,
            PricePerNight = price,
            IsAvailable = true

        };

        _rooms.Add(roomNumber, room);
    }

    public Dictionary<string , List<Room>> GroupRoomsByType(){
        Dictionary<string, List<Room>> result = new Dictionary<string, List<Room>>();

        foreach(var room in _rooms.Values){
            if(!room.IsAvailable){
                continue;
            }
            if(!result.ContainsKey(room.RoomType)){
                result[room.RoomType] = new List<Room>();
            }

            result[room.RoomType].Add(room);
        }

        return result;
    }


public bool BookRoom(int roomNumber , int nights){
    if(!_rooms.ContainsKey(roomNumber)){
        Console.WriteLine("Room does not exist.");
        return false;
    }

    Room room = _rooms[roomNumber];

    if(!room.IsAvailable){
        Console.WriteLine("Room is not available.");
        return false;
    }

    double totalCost = room.PricePerNight * nights;
    room.IsAvailable = false;

    Console.WriteLine($"Room {roomNumber} booked for {nights} nights.");
    Console.WriteLine($"Total cost: {totalCost}");
    return true;
}

public List<Room> GetAvailableRoomsByPriceRange(double min , double max){
    List<Room> result = new List<Room>();

    foreach(var room in _rooms.Values){
        if(room.IsAvailable &&
           room.PricePerNight >= min &&
           room.PricePerNight <= max)
           {
            result.Add(room);
           }
    }

    return result;
}
}

public class Program{
    public static void Main(){
        HotelManager hotel = new HotelManager();
        hotel.AddRoom(101, "Single", 1500);
        hotel.AddRoom(102, "Single", 1800);
        hotel.AddRoom(201, "Double", 2500);
        hotel.AddRoom(301, "Suite", 5000);
        hotel.AddRoom(401, "Deluxe", 6500);

        Console.WriteLine("Available Rooms Grouped By Type:");
        var groupedRooms = hotel.GroupRoomsByType();

        foreach (var type in groupedRooms)
        {
            Console.WriteLine($"\n{type.Key} Rooms:");
            foreach (var room in type.Value)
            {
                Console.WriteLine($"Room {room.RoomNumber} - ₹{room.PricePerNight}");
            }
        }

         Console.WriteLine("\nBooking Room 101:");
        hotel.BookRoom(101, 3);

        // 4. Find rooms within budget
        Console.WriteLine("\nRooms within price range 1500 - 3000:");
        var budgetRooms = hotel.GetAvailableRoomsByPriceRange(1500, 3000);

        foreach (var room in budgetRooms)
        {
            Console.WriteLine(
                $"Room {room.RoomNumber} - {room.RoomType} - ₹{room.PricePerNight}"
            );
    }
    }
}