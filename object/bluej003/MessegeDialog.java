import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class MessegeDialog extends JFrame
{
    private static final int height = 200;
    private static final int width = 300;
    private static final int origin_x = 150;
    private static final int origin_y = 250;
    
    int screenWidth = 768;
    int screenHeight = 432;
    int windowWidth = 300;
    int windowHeight = 200;
    public JTextArea area;
    public JTextField input;
    
    public static MessegeDialog instance;
    
    public void SetSize(){
        setSize(500, 1000);
    }
    
    public MessegeDialog()
    {
        instance = this;
        setTitle("title");
        setSize(windowWidth, windowHeight);
        setLocation(screenWidth - (windowWidth / 2), screenHeight - (windowHeight / 2));
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        
        
        Container contentPane = getContentPane();
        contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.PAGE_AXIS));
        area = new JTextArea();
        
        area.setText("Hello");
        area.append("\nOne");
        area.append("\nTwo");
        area.append("\nThree");
        area.append("\nFour");
        area.append("\nFive");
        area.append("\nSix");
        area.append("\nSeven");
        area.append("\nEight");
        area.append("\nNine");
        contentPane.add(area);
        
        JScrollPane scroll = new JScrollPane(area);
        contentPane.add(scroll);
        
        input = new JTextField();
        contentPane.add(input);
        
        JButton btn = new JButton("btn");
        contentPane.add(btn);
        ButtonHandler handler = new ButtonHandler( );
        btn.addActionListener(handler);
        
        setVisible(true);
    }

}