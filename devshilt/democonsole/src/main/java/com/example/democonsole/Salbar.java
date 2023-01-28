package com.example.democonsole;

public class Salbar {
    private String code;
    private String name;

    public Salbar() {
    }

    public Salbar(String c, String n) {
        code = c;
        name = n;
    }

    public String getName() {
        return name;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString() {
        return "---- salbar code = " +  code + "\n---- salbar name = " + name;
    }
}
