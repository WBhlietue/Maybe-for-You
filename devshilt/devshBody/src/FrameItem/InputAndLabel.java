package FrameItem;

import java.awt.Font;

import javax.swing.*;

public class InputAndLabel extends FrameItem {

    public JLabel label;
    public JTextField field;

    public String GetInputText() {
        return field.getText();
    }

    public void SetInputText(String value) {
        field.setText(value);
    }

    public void SetText(String value) {
        label.setText(value);
    }

    public InputAndLabel(JFrame frame, int x, int y, int height, int width, String text) {
        field = new JTextField();
        field.setFont(font);
        field.setSize(width, height);
        field.setLocation(x, y);
        label = new JLabel(text);
        label.setFont(font);
        label.setSize(width, height);
        label.setLocation(x, y - height);
        frame.add(field);
        frame.add(label);
    }

    public InputAndLabel(JFrame frame, int x, int y, int height, int width, String text, int paddingX, int paddingY) {
        JTextField field = new JTextField();
        field.setFont(font);
        field.setSize(width, height);
        field.setLocation(x, y);
        JLabel label = new JLabel(text);
        label.setFont(font);
        label.setSize(width, height);
        label.setLocation(x + paddingX, y - height + paddingY);
        frame.add(field);
        frame.add(label);
    }

    @Override
    public void SetFont(Font f) {
        // TODO Auto-generated method stub
        super.SetFont(f);
        label.setFont(font);
        field.setFont(f);
    }
}
