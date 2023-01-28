package com.example.sprintfruit.test;

public class Fruit extends Item{
    public Fruit(){
        setType("Fruit");
    }
    public Fruit(String name, int price, int num) {
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
