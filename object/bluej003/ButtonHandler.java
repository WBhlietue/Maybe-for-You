import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class ButtonHandler implements ActionListener 
{
    public void actionPerformed(ActionEvent event)
    {
        JButton clickedButton = (JButton) event.getSource();
        JRootPane rootPane = clickedButton.getRootPane( );
        Frame frame = (JFrame) rootPane.getParent();
        MessegeDialog.instance.SetSize();
        MessegeDialog.instance.area.append("\n" + MessegeDialog.instance.input.getText());
    }
}