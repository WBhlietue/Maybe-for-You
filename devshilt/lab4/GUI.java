import java.awt.*;
import javax.swing.*;
import javax.swing.border.*;

public class GUI extends JFrame {
    public GUI() {
        super("lab4");
        Border bor = BorderFactory.createLineBorder(Color.black);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(700, 700);
        JPanel r = new JPanel();
        JPanel l = new JPanel();
        // r.setSize(350, 500);
        // l.setLocation(350, 0);
        // l.setSize(150, 500);
        Container con = getContentPane();
        con.setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();
        c.fill = 1;
        c.gridx = 0;
        c.gridy = 0;
        c.weightx = 2;
        c.weighty = 1;
        r.setBorder(bor);
        l.setBorder(bor);
        con.add(r, c);
        c.gridx = 1;
        c.weightx = 1;
        c.weighty = 1;
        con.add(l, c);
        r.setLayout(new GridBagLayout());
        c.gridy = 0;
        c.gridx = 0;
        c.weighty = 1;
        JPanel input = new JPanel();
        r.add(input, c);
        c.gridy = 1;
        c.gridx = 0;
        c.weighty = 8;
        JPanel choice = new JPanel();
        r.add(choice, c);
        c.gridy = 2;
        c.gridx = 0;
        c.weighty = 1;
        JPanel dropDown = new JPanel();
        r.add(dropDown, c);
        c.gridy = 3;
        c.gridx = 0;
        c.weighty = 2;
        JPanel empty = new JPanel();
        r.add(empty, c);
        c.gridy = 4;
        c.gridx = 0;
        c.weighty = 5;
        JPanel txt = new JPanel();
        r.add(txt, c);

        input.setLayout(new GridBagLayout());
        c.gridx = 0;
        c.gridy = 0;
        c.weightx = 1;
        JPanel inputName = new JPanel();
        inputName.setLayout(new BorderLayout());
        inputName.add(new JPanel(), BorderLayout.WEST);
        inputName.add(new JPanel(), BorderLayout.EAST);
        inputName.add(new JLabel("Name"), BorderLayout.CENTER);
        input.add(inputName, c);

        choice.setLayout(new GridLayout(3, 1));
        // choice.setLayout(new FlowLayout());
        ButtonGroup radio = new ButtonGroup();
        // radio.setLayout(new FlowLayout());
        JRadioButton j1 = new JRadioButton("Male");
        JRadioButton j2 = new JRadioButton("Female");
        radio.add(j1);
        radio.add(j2);
        JPanel rad = new JPanel();
        rad.add(j1);
        rad.add(j2);
        choice.add(new JPanel());
        choice.add(rad);
        choice.add(new JPanel());

        String[] coi = { "IT", "123", "231asd" };
        JComboBox<String> combo = new JComboBox<String>(coi);
        dropDown.setLayout(new GridLayout(1, 1));
        dropDown.add(combo);

        JLabel t = new JLabel("java");
        JLabel t1 = new JLabel("Math");
        JLabel t2 = new JLabel("OOP");
        JLabel t3 = new JLabel("C++");
        JLabel t4 = new JLabel("Database");

        txt.setLayout(new BorderLayout());
        JPanel tx = new JPanel();
        tx.setLayout(new GridLayout(5, 1));
        tx.add(t);
        tx.add(t1);
        tx.add(t2);
        tx.add(t3);
        tx.add(t4);
        txt.add(tx, BorderLayout.CENTER);
        txt.add(new JPanel(), BorderLayout.WEST);
        txt.add(new JPanel(), BorderLayout.EAST);

        input.setBorder(bor);
        choice.setBorder(bor);
        dropDown.setBorder(bor);
        empty.setBorder(bor);
        txt.setBorder(bor);

        setVisible(true);
    }

    public static void main(String[] args) {
        new GUI();
    }
}
