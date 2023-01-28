import java.awt.*;
import javax.swing.*;
import javax.swing.border.*;
import javax.swing.plaf.PanelUI;
import javax.swing.text.LabelView;

public class GUI2 extends JFrame {
    public GUI2() {
        super("lab4-2");
        Font f = new Font("Arial", Font.PLAIN, 20);
        Border bor = BorderFactory.createLineBorder(Color.black);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(800, 400);
        JPanel r = new JPanel();
        JPanel l = new JPanel();
        Container con = getContentPane();
        con.setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();
        c.fill = 1;
        c.gridx = 0;
        c.gridy = 0;
        c.weightx = 5;
        c.weighty = 1;
        r.setBorder(bor);
        l.setBorder(bor);
        con.add(r, c);
        c.gridx = 1;
        c.weightx = 4;
        c.weighty = 1;
        con.add(l, c);
        r.setLayout(new GridBagLayout());
        c.weightx = 1;
        c.gridy = 0;
        c.weighty = 1;
        JPanel topTxt = new JPanel();
        topTxt.setLayout(new BorderLayout());
        topTxt.add(new JPanel(), BorderLayout.WEST);
        topTxt.add(new JPanel(), BorderLayout.EAST);
        topTxt.add(new JPanel(), BorderLayout.NORTH);
        topTxt.add(new JPanel(), BorderLayout.SOUTH);
        JLabel titTxt = new JLabel("Edit the HTML, then click the button");
        titTxtd.setFont(f);
        topTxt.add(titTxt, BorderLayout.CENTER);
        r.add(topTxt, c);
        c.gridy = 1;
        c.weighty = 5;
        JPanel tx = new JPanel();
        tx.setLayout(new BorderLayout());
        JTextArea area = new JTextArea();

        area.setFont(f);
        area.append("<ul>\n");
        area.append("<li><font color=red>red</font>\n");
        area.append("<li><font color=blue>blue</font>\n");
        area.append("<li><font color=green>green</font>\n");
        area.append("<li><font size=-2>small</font>\n");
        area.append("<li><font size=+2>large</font>\n");
        area.append("<li><i>italic</i>\n");
        area.append("<li><b>bold</b>\n");

        tx.add(new JScrollPane(area), BorderLayout.CENTER);
        tx.add(new JPanel(), BorderLayout.WEST);
        tx.add(new JPanel(), BorderLayout.EAST);
        tx.add(new JPanel(), BorderLayout.NORTH);
        tx.add(new JPanel(), BorderLayout.SOUTH);
        r.add(tx, c);
        JPanel btn = new JPanel();
        btn.setLayout(new BoxLayout(btn, BoxLayout.Y_AXIS));
        btn.add(new JLabel(" "));
        btn.add(new JLabel(" "));
        btn.add(new JLabel(" "));
        JButton b = new JButton("Change the Label");
        b.setAlignmentX(Component.CENTER_ALIGNMENT);
        btn.add(b);
        btn.setSize(100, 100);
        c.gridy = 2;
        c.weighty = 2;
        r.add(btn, c);

        JPanel topp = new JPanel();
        topp.setLayout(new BorderLayout());
        topp.add(new JPanel(), BorderLayout.WEST);
        topp.add(new JPanel(), BorderLayout.EAST);
        topp.add(new JPanel(), BorderLayout.NORTH);
        topp.add(new JPanel(), BorderLayout.SOUTH);
        JLabel titTxt2 = new JLabel("A label eith HTML");
        topp.add(titTxt2, BorderLayout.CENTER);
        titTxt2.setFont(f);
        l.add(topp);
        JPanel list = new JPanel();
        JPanel[] lJ = new JPanel[7];
        Font f1 = new Font("Arial", Font.PLAIN, 20);
        String[] str = new String[7];
        str[0] = "<html><li><font color=red>red</font></html>";
        str[1] = "<html><li><font color=blue>blue</font></html>";
        str[2] = "<html><li><font color=green>green</font></html>";
        str[3] = "<html><li><font size=-2>small</font></html>";
        str[4] = "<html><li><font size=+2>large</font></html>";
        str[5] = "<html><li><i>italic</i></html>";
        str[6] = "<html><li><b>bold</b></html>";
        for (int i = 0; i < lJ.length; i++) {
            lJ[i] = new JPanel();
            JLabel j = new JLabel();
            j.setText(str[i]);
            lJ[i].add(j);
        }

        lJ[0].setForeground(Color.red);
        l.setLayout(new BoxLayout(l, BoxLayout.Y_AXIS));
        list.setLayout(new BoxLayout(list, BoxLayout.Y_AXIS));
        JLabel asd = new JLabel("Color and font test");
        asd.setFont(f1);
        list.add(asd);
        for (JPanel i : lJ) {
            list.add(i);
        }
        for (int i = 0; i < 1; i++) {
            l.add(new JLabel(" "));
        }
        l.add(list);
        setVisible(true);
    }

    public static void main(String[] args) {
        new GUI2();
    }
}
