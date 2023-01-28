import java.lang.Thread;
import java.util.*;
import java.util.List;
import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Text {

    JLabel area;

    public Text(int width, int height, int fontSize, int x, int y) {
        area = new JLabel("123123123");
        area.setSize(width, height);
        area.setLocation(x, y);
        area.setFont(new Font("Arial", Font.ITALIC, fontSize));
        Game.gameWindow.add(area);
    }

    public void SetText(String txt) {
        area.setText(txt);
    }
}