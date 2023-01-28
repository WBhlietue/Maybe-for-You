package Register;



import java.time.LocalDateTime;

public class RegisterToRoom {
    public static void Register(String room, People p) {
        PeopleRegister.Add(p);
        RoomData r = RoomRegister.GetWithCode(room);
        String s = LocalDateTime.now().getYear() + "-" + LocalDateTime.now().getMonthValue() + "-"
                + LocalDateTime.now().getDayOfMonth();
        r.setDate(Date.FromString(s));
        r.setPeople(p);
        RoomRegister.Save();
    }

    public static void Remove(String room) {
        People p = RoomRegister.GetWithCode(room).getPeople();
        // PeopleRegister.Remove(p);
        RoomRegister.GetWithCode(room).Reset();
        RoomRegister.Save();
    }
}
