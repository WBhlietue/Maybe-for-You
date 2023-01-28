package Register;

import java.util.ArrayList;
import java.util.List;
import java.io.*;

public class UserManager {
    private static List<User> users;

    public static void Load() {
        users = new ArrayList<>();
        try {
            File file = new File("Data/User.txt");
            FileReader output = new FileReader(file);
            BufferedReader write = new BufferedReader(output);
            try {
                while (true) {
                    String s = write.readLine();
                    if (s == null) {
                        break;
                    }
                    users.add(User.FromString(s));
                }
            } catch (Exception e) {
            }
            write.close();
        } catch (Exception e) {
            System.out.println("User Load Fail");
        }
    }

    public static void Save() {
        try {
            File file = new File("Data/User.txt");
            FileOutputStream output = new FileOutputStream(file);
            PrintWriter write = new PrintWriter(output);
            for (int i = 0; i < users.size(); i++) {
                write.println(users.get(i).ConvertString());
            }
            write.close();
        } catch (Exception e) {
            System.out.println("User save Fail");
        }
    }

    public static String Login(String name, String pass) {
        Load();
        for (int i = 0; i < users.size(); i++) {
            if (users.get(i).CheckUserName(name)) {
                if (users.get(i).CheckPassWord(pass)) {
                    return "login";
                } else {
                    return "wrong password";
                }
            }
        }
        return "wrong userName";
    }

    public static String Register(String name, String pass, People p) {
        Load();
        for (int i = 0; i < users.size(); i++) {
            if (users.get(i).CheckUserName(name)) {
                return "userName already exist";
            }
        }
        users.add(new User(name, pass, p.getRegistrNum()));
        Save();
        PeopleRegister.Add(p);
        return "complete";
    }

    public static void AddUser(User user) {
        users.add(user);
        Save();
    }

    public static User FindWithName(String name) {
        for (int i = 0; i < users.size(); i++) {
            if (users.get(i).CheckUserName(name)) {
                return users.get(i);
            }
        }
        return null;
    }
}
