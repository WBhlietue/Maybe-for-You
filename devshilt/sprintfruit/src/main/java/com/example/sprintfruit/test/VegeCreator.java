package com.example.sprintfruit.test;

import java.util.ArrayList;
import java.util.List;

public class VegeCreator {
    List<Vege> list;

    public VegeCreator() {

    }

    public VegeCreator(List<String> name, List<Integer> price, List<Integer> num) {
        list = new ArrayList<>();
        for (int i = 0; i < name.size(); i++) {
            list.add(new Vege(name.get(i), price.get(i), num.get(i)));
        }
    }

    public List<Vege> GetList() {
        return list;
    }
}
