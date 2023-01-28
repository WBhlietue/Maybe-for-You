package com.example.sprintfruit.test;

public class Item {
    private int price;
    private String name;
    private int num;
    private String type;

    public int getPrice() {
        return price;
    }
    public String getType() {
        return type;
    }
    public void setType(String type) {
        this.type = type;
    }
    public int getNum() {
        return num;
    }
    public void setNum(int num) {
        this.num = num;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public void setPrice(int price) {
        this.price = price;
    }

    @Override
    public String toString() {
        String str = "name: " + name + ", price: " + price + ", num: " + num + ", type: " + type;
        return str;
    }
}
