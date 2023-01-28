package com.example.wensql;

import java.util.*;
import java.io.*;
import java.net.*;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class Web {

    @Autowired
    private Progress1 prog;

    @GetMapping("/html")
    public String HTML() throws FileNotFoundException {
        String str = "";
        File file = new File("index.txt");
        FileReader reader = new FileReader(file);
        System.out.println(reader + " 12312312333");
        try {
            BufferedReader read = new BufferedReader(reader);
            try {
                while (true) {
                    str += read.readLine();
                }
            } catch (Exception e) {

            }
            read.close();
        } catch (Exception e) {
        }
        return "str";
        // return "<html> <head> <style> .main{width: 100px;height:
        // 100px;background-color: aqua;}</style></head><body><div class='main'></div>
        // </body></html>";
    }

    @GetMapping("/sql")
    public String SQL() {
        prog.CreateStudent("Bat", "it101", 30);
        prog.CreateStudent("Dorj", "it102", 20);
        prog.CreateStudent("Bold", "it102", 20);
        prog.CreateStudent("Dio", "it101", 10);
        prog.CreateStudent("Jojo", "it101", 15);
        prog.CreateStudent("Diablo", "it102", 30);
        prog.CreateStudent("Kira", "it101", 25);
        prog.CreateStudent("Karz", "it101", 35);
        String str = "<html><head></head> <body>CreateStudent<br> ";
        long i = 1;
        for (i = 1; i <= prog.Count(); i++) {
            try {
                str += prog.FindStudent(i).toString() + "<br>";
            } catch (Exception e) {

            }
        }
        str += "<br><br>Delete id=2 Student<br>";
        try {
            prog.DeleteStudent(2);
        } catch (Exception e) {
        }
        for (i = 1; i <= prog.Count(); i++) {
            try {
                str += prog.FindStudent(i).toString() + "<br>";
            } catch (Exception e) {

            }
        }
        str += "<br><br>Update id=1 Student to it103<br>";
        prog.UpdateStudent(1, "it103");
        for (i = 1; i <= prog.Count(); i++) {
            try {
                str += prog.FindStudent(i).toString() + "<br>";
            } catch (Exception e) {

            }
        }
        return str + "</body> </html>";
    }

}
