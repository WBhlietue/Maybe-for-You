package com.example.sprintfruit.test;

public class Vege extends Item {

    public Vege() {
        setType("Vegetable");
    }

    public Vege(String name, int price, int num) {
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
