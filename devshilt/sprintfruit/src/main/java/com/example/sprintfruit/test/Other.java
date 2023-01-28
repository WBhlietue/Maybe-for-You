package com.example.sprintfruit.test;

public class Other extends Item {
    public Other(){
        setType("Other");
    }
    public Other(String name, int price, int num) {
        this();
        setName(name);
        setPrice(price);
        setNum(num);
    }

    @Override
    public String toString() {
        return super.toString();
    }
}
