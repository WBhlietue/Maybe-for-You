package com.example.wensql.Register;

public class User {
    private String username;
    private String password;
    private String regsiter;

    public User(String n, String p, String reg) {
        username = n;
        password = p;
        regsiter = reg;
    }

    public String ConvertString() {
        return username + "/" + password + "/" + regsiter;
    }

    public static User FromString(String str) {
        String[] s = str.split("/");
        return new User(s[0], s[1], s[2]);
    }

    public boolean CheckUserName(String name) {
        return username.equals(name);
    }

    public boolean CheckPassWord(String pass) {
        return password.equals(pass);
    }

    public String getPeopleName() {
        return PeopleRegister.GetWithRegistrNum(regsiter).getName();
    }

    public boolean checkIsThisPeople(People p) {
        return PeopleRegister.GetWithRegistrNum(regsiter).getRegistrNum().equals(p.getRegistrNum());
    }

    public People getPeople() {
        return PeopleRegister.GetWithRegistrNum(regsiter);
    }

}
