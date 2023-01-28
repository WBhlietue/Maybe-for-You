package com.example.sprintfruit.test;

import java.util.ArrayList;
import java.util.List;

public class OtherCreator {
    List<Other> list;

    public OtherCreator() {
    }

    public OtherCreator(List<String> name, List<Integer> price, List<Integer> num) {
        list = new ArrayList<>();
        for (int i = 0; i < name.size(); i++) {
            list.add(new Other(name.get(i), price.get(i), num.get(i)));
        }
    }

    public List<Other> GetList() {
        return list;
    }
}
