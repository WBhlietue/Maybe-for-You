import java.util.List;

import Register.*;

public class Test {

    public static void main(String[] args) {
        RegisterToRoom.Register("302",
                new People("Bat", "Bold", new Date(2002, 9, 2), "AB000001", "99887766", "Test@gmail.com"));
        RegisterToRoom.Register("305",
                new People("Dorj", "Tsetseg", new Date(2000, 11, 6), "AB000002", "99776655", "Test1@gmail.com"));
        RegisterToRoom.Register("106",
                new People("Gan", "Tumur", new Date(2003, 5, 21), "AB000003", "99775533", "Test2@gmail.com"));

        List<RoomData> data = RoomRegister.GetroomsCopy();
        for (int i = 0; i < data.size(); i++) {
            System.out.println(data.get(i));
        }
    }

}
