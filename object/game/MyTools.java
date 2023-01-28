import java.lang.Thread;
import java.util.*;
import java.util.List;
import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class MyTools {
    public static int frame = 60;
    static Random r;

    public static void Print(Object obj) {
        System.out.println(obj);
    }

    public static int getRandomNum(int min, int max) {
        if (r == null) {
            r = new Random();
        }
        return r.nextInt(max - min) + min;
    }

}
