package com.example.sprintfruit.test;

import java.util.*;

import org.springframework.boot.CommandLineRunner;
import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class App implements CommandLineRunner {

    List<Item> vege;

    @Override
    public void run(String... args) throws Exception {
        System.out.println("\n");

        vege = new ArrayList<Item>();

        ConfigurableApplicationContext cont = new ClassPathXmlApplicationContext("Beans.xml");

        vege.addAll(((FruitCreater) cont.getBean("fruits")).GetList());
        vege.addAll(((VegeCreator) cont.getBean("veges")).GetList());
        vege.addAll(((OtherCreator) cont.getBean("others")).GetList());

        PrintVege();
        PrintFruit();
        PrintOther();

        cont.close();
    }

    void PrintVege() {
        for (Item item : vege) {
            if (item.getType().equals("Vegetable")) {
                System.out.println(item);
            }
        }
        System.out.println("");
    }

    void PrintFruit() {
        for (Item item : vege) {
            if (item.getType().equals("Fruit")) {
                System.out.println(item);
            }
        }
        System.out.println("");
    }

    void PrintOther() {
        for (Item item : vege) {
            if (item.getType().equals("Other")) {
                System.out.println(item);
            }
        }
        System.out.println("");
    }

}
