package com.example.democonsole;

public class BeanTest {
    private String msg = " ";
    public BeanTest(){}

    public BeanTest(String m){
        msg = m;
    }

    public void setMsg(String m) {
        msg = m;
    }

    public String getMsg() {
        return msg;
    }

    public void Init(){
        System.out.println("\nINIT");
    }

}
