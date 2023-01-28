package com.example.sprintfruit.test;

import java.util.ArrayList;
import java.util.List;

public class FruitCreater {
    List<Fruit> list = new ArrayList<>();

    public FruitCreater() {
    }

    public FruitCreater(List<String> name, List<Integer> price, List<Integer> num) {
        for (int i = 0; i < name.size(); i++) {
            list.add(new Fruit(name.get(i), price.get(i), num.get(i)));
        }
    }

    public List<Fruit> GetList() {
        return list;
    }
}
