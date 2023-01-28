package com.example.democonsole;

public class Student {
    private String code;
    private String name;
    private int age;
    private int course;
    private Salbar salbar;

    public Student() {
    }

    public Student(String c, String n, int a, int cou) {
        code = c;
        name = n;
        age = a;
        course = cou;
    }

    public int getCourse() {
        return course;
    }

    public Salbar getSalbar() {
        return salbar;
    }

    public void setSalbar(Salbar salbar) {
        this.salbar = salbar;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setCourse(int course) {
        this.course = course;
    }



    private String msg = " ";
    public void setMsg(String m) {
        msg = m;
    }

    public String getMsg() {
        return msg;
    }

    public void Init(){
        System.out.println("\nINIT");
    }

    @Override
    public String toString() {
        String str = "";
        str = "code = " + code + "\nname = " + name + "\nage = " + age + "\ncourse = " + course + "\nsalbar: \n" + salbar;
        return str;
    }

}
