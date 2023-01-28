import java.lang.Thread;
import java.util.*;
import java.util.List;
import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class Key extends KeyAdapter {
    public Key() {
        Game.gameWindow.addKeyListener(this);
    }

}