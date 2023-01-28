package Register;



import java.io.*;
import java.util.*;

public class RoomRegister {
    public static boolean isInit = false;
    static List<RoomData> rooms;

    static void CheckInit() {
        if (!isInit) {
            Init();
        }
    }

    public static void Init() {
        isInit = true;
        rooms = new ArrayList<>();
        Load();
    }

    public static void Save() {
        try {
            File file = new File("Data/RoomRegister.txt");
            FileOutputStream output = new FileOutputStream(file);
            PrintWriter write = new PrintWriter(output);
            for (int i = 0; i < rooms.size(); i++) {
                if (rooms.get(i).getPeople() != null) {
                    write.println(rooms.get(i).ConvertToString());
                }
            }
            write.close();
        } catch (FileNotFoundException e) {
            System.out.println("RoomData save Fail");
        }
    }

    public static void Load() {
        try {
            File file = new File("Data/Rooms.txt");
            FileReader output = new FileReader(file);
            BufferedReader write = new BufferedReader(output);
            try {
                while (true) {
                    String data = write.readLine();
                    if (data == null) {
                        break;
                    }
                    rooms.add(new RoomData(null, Room.FromString(data), null));
                }
            } catch (Exception e) {
                System.out.println("!23");
            }
            write.close();
        } catch (Exception e) {
            System.out.println("RoomData load Fail 1");
        }

        try {
            File file = new File("Data/RoomRegister.txt");
            FileReader output = new FileReader(file);
            BufferedReader write = new BufferedReader(output);
            try {
                while (true) {
                    String data = write.readLine();
                    if (data == null) {
                        break;
                    }
                    RoomData d = RoomData.FromString(data);
                    RoomData r = GetWithCode(d.getRoom().getCode());
                    r.setDate(d.getDate());
                    r.setPeople(d.getPeople());
                }
            } catch (Exception e) {
                System.out.println("!23");
            }
            write.close();
        } catch (Exception e) {
            System.out.println("RoomData load Fail 2");
        }
    }

    public static boolean IsEmpty(RoomData p) {
        int i = IndexOf(p);
        if (rooms.get(i).getPeople() == null) {
            return true;
        }
        return false;
    }

    public static int IndexOf(RoomData p) {
        for (int i = 0; i < rooms.size(); i++) {
            if (p.getRoom().getCode().equals(rooms.get(i).getRoom().getCode())) {
                return i;
            }
        }
        return -1;
    }

    public static RoomData GetWithCode(String regNum) {
        CheckInit();
        for (RoomData i : rooms) {
            if (i.getRoom().getCode().equals(regNum)) {
                return i;
            }
        }

        return null;
    }

    public static void Remove(RoomData p) {
        CheckInit();
        if (IsEmpty(p)) {
            System.out.println("RoomData is empty");
        } else {
            try {
                rooms.remove(IndexOf(p));
                Save();
            } catch (Exception e) {
                System.out.println("RoomData remove error");
            }
        }
    }

    public static void Add(RoomData p) {
        CheckInit();
        if (!IsEmpty(p)) {
            System.out.println("this RoomData is already have");
        } else {
            rooms.add(p);
            Save();
        }
    }

    public static List<RoomData> GetroomsCopy() {
        CheckInit();
        return new ArrayList<RoomData>(rooms);
    }
}
