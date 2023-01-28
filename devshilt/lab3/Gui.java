import java.awt.*;
import java.awt.event.*;

public class Gui extends Frame {

    public static Label label;

    public Gui() {
        super("Lab3");
        setSize(1280, 900);
        addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent we) {
                setVisible(false);
                System.exit(0);
            }
        });
        setLayout(null);
        Label l1 = new Label("Online Shopping Program");
        Font f = new Font("Arial", Font.PLAIN, 30);
        l1.setFont(f);
        l1.setLocation(500, 50);
        l1.setSize(500, 100);
        Button btn1 = new Button("Male Constume");
        Button btn2 = new Button("Female Constume");
        Button btn3 = new Button("Sport Constume");
        Button btn4 = new Button("Accessory");
        Button btn5 = new Button("Bag");
        Button btn6 = new Button("Exit");

        btn1.setFont(f);
        btn2.setFont(f);
        btn3.setFont(f);
        btn4.setFont(f);
        btn5.setFont(f);
        btn6.setFont(f);

        btn1.setSize(500, 100);
        btn2.setSize(500, 100);
        btn3.setSize(500, 100);
        btn4.setSize(500, 100);
        btn5.setSize(500, 100);
        btn6.setSize(500, 100);

        btn1.setLocation(50, 150);
        btn2.setLocation(50, 260);
        btn3.setLocation(50, 370);
        btn4.setLocation(50, 480);
        btn5.setLocation(50, 590);
        btn6.setLocation(50, 700);

        btn1.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                label.setText(btn1.getLabel());
            }
        });
        btn2.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                label.setText(btn2.getLabel());
            }
        });
        btn3.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                label.setText(btn3.getLabel());
            }
        });
        btn4.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                label.setText(btn4.getLabel());
            }
        });
        btn5.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                label.setText(btn5.getLabel());
            }
        });
        btn6.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                setVisible(false);
                System.exit(0);
            }
        });

        add(l1);
        add(btn1);
        add(btn2);
        add(btn3);
        add(btn4);
        add(btn5);
        add(btn6);

        label = new Label("Empty");
        label.setFont(f);

        label.setSize(500, 100);
        label.setLocation(750, 400);

        add(label);
        setVisible(true);
    }
}