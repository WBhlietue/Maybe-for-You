package com.example.wensql.Register;

import java.io.*;
import java.util.*;

public class PeopleRegister {
    public static boolean isInit = false;
    static List<People> peoples;

    static void CheckInit() {
        if (!isInit) {
            Init();
        }
    }

    public static void Init() {
        peoples = new ArrayList<>();
        Load();
    }

    public static void Save() {
        try {
            File file = new File("Data/Peoples.txt");
            FileOutputStream output = new FileOutputStream(file);
            PrintWriter write = new PrintWriter(output);
            for (int i = 0; i < peoples.size(); i++) {
                write.println(peoples.get(i).ConvertToString());
            }
            write.close();
        } catch (Exception e) {
            System.out.println("People save Fail");
        }
    }

    public static void Load() {
        try {
            File file = new File("Data/Peoples.txt");
            FileReader output = new FileReader(file);
            BufferedReader write = new BufferedReader(output);
            try {
                while (true) {
                    String s = write.readLine();
                    if (s == null) {
                        break;
                    }
                    peoples.add(People.FromString(s));
                }
            } catch (Exception e) {
            }
            write.close();
        } catch (Exception e) {
            System.out.println("People load Fail");
        }
    }

    public static int IndexOf(People p) {
        for (int i = 0; i < peoples.size(); i++) {
            if (p.getRegistrNum().equals(peoples.get(i).getRegistrNum())) {
                return i;
            }
        }
        return -1;
    }

    public static People GetWithRegistrNum(String regNum) {
        if (regNum.equals("null")) {
            return null;
        }
        CheckInit();
        for (People i : peoples) {
            if (i.getRegistrNum().equals(regNum)) {
                return i;
            }
        }
        return null;
    }

    public static void Remove(People p) {
        CheckInit();
        if (IndexOf(p) == -1) {
            System.out.println("no this people");
        } else {
            try {
                peoples.remove(IndexOf(p));
                Save();
            } catch (Exception e) {
                System.out.println("people remove error");
            }
        }
    }

    public static void Add(People p) {
        CheckInit();
        if (IndexOf(p) != -1) {
            System.out.println("this people is already have");
        } else {
            peoples.add(p);
        }
        Save();
    }

    public static List<People> GetPeoplesCopy() {
        CheckInit();
        return new ArrayList<People>(peoples);
    }
}
