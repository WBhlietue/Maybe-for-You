import java.lang.Thread;
import java.util.*;
import java.util.List;
import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


public class GameWindow extends JFrame {

    public GameWindow() {
        new CollisionManager();
        setLayout(null);
        setSize(1280, 720);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        add(new JPanel(null));
        setVisible(true);
    }

}