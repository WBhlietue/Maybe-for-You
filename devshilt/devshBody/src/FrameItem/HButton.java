package FrameItem;

import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class HButton extends FrameItem {
    public JButton button;
    IClickButton iClick;

    public HButton(JFrame frame, int x, int y, int height, int width, String text) {
        button = new JButton();
        button.setFont(font);
        button.setSize(width, height);
        button.setLocation(x, y);
        button.setText(text);
        frame.add(button);
    }

    public HButton(JPanel frame, String text) {
        button = new JButton();
        button.setFont(font);
        button.setText(text);
        frame.add(button);
    }

    public void AddListener(IClickButton click) {
        iClick = click;
        button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (iClick != null) {
                    iClick.OnClick();
                }
            }
        });
    }

    public void SetText(String text) {
        button.setText(text);
    }

    public String GetText() {
        return button.getText();
    }

    @Override
    public void SetFont(Font f) {
        // TODO Auto-generated method stub
        super.SetFont(f);
        button.setFont(font);
    }
}
