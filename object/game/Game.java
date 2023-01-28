import java.lang.Thread;
import java.util.*;
import java.util.List;
import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Game extends Thread {

    long delay = 0;
    long pauseSec = 0;
    int pauseFrame = 0;

    long secCount = pauseSec;
    int frameCount = pauseFrame;

    public boolean enabled = true;

    static GameWindow gameWindow = null;

    public boolean customFrame = false;
    public int targetFrame = 1;

    JLabel thisObj;

    Vector position = new Vector(0, 0);

    public String name = "null";
    public int collDistance = 0;

    public boolean isCollided = false;
    public Game coll = null;

    public void run() {
        try {
                Thread.sleep(delay);
        } catch (Exception e) {

        }
        Start();
        while (true) {
            try {
                Thread.sleep(delay);
                if (enabled) {
                    if (frameCount < pauseFrame) {
                        frameCount++;
                    }
                    if (secCount < pauseSec) {
                        secCount += delay;
                    }
                    if (frameCount >= pauseFrame && secCount >= pauseSec) {
                        Update();
                    }
                }
            } catch (Exception e) {

            }
        }
    }

    public Game() {

        if (gameWindow == null) {
            gameWindow = new GameWindow();
        }
        if (!customFrame) {
            if (delay == 0) {
                delay = 1000 / MyTools.frame;
            }
        } else {
            delay = 1000 / targetFrame;
        }
        Awake();
        start();
    }

    public Vector getPostion() {
        return position;
    }

    public void setPosition(Vector target) {
        position = target;
        thisObj.setLocation(position.x, position.y);
    }

    

    public GameWindow getWindow() {
        return gameWindow;
    }

    public void setCustomFrame(boolean custom, int frame) {
        targetFrame = (frame <= 0 ? 1 : frame);
        customFrame = custom;
    }

    public void updateCustomFrame() {
        delay = 1000 / targetFrame;
    }

    public void Init(int width, int height, String imagePath, int x, int y) {
        ImageIcon icon;
        try {
            icon = new ImageIcon(getClass().getResource(imagePath));
            Image i = icon.getImage();
            icon.setImage(i.getScaledInstance(width, height, 0));
        } catch (Exception e) {
            icon = new ImageIcon();
            MyTools.Print("file not found");
        }

        // thisObj = new JButton(icon);
        thisObj = new JLabel(icon);
        gameWindow.add(thisObj);
        thisObj.setSize(width, height);
        thisObj.setLocation(x, y);
        position.x = thisObj.getLocation().x;
        position.y = thisObj.getLocation().y;
    }

    boolean active = true;
    Vector pos;

    public void setAcive(boolean status) {
        if (!status) {
            if (active) {
                pos = getPostion();
            }
            setPosition(Vector.one.Mult(-100000));
        } else {
            if (!active) {
                setPosition(pos);
            }
        }
        active = status;
    }

    

    public void Awake() {

    }

    public void Start() {

    }

    public void Update() {

    }

    public void collideStart(Game other) {

    }

    public void Collide(Game other) {

    }

    public void collideEnd(Game other) {

    }

    // pause

    public void PauseWithFrame(int frameNum) {
        secCount = 0;
        pauseSec = 0;
        frameCount = 0;
        pauseFrame = frameNum;
    }

    public void PauseWithSec(float sec) {
        pauseFrame = 0;
        frameCount = 0;
        pauseSec = (long) (sec * 1000);
        secCount = 0;
    }

    // enabled

    public void SetEnable(boolean _enabled) {
        if (!enabled && _enabled) {
            OnEnabled();
        }

        if (enabled && !_enabled) {
            OnDisabled();
        }

        enabled = _enabled;
    }

    public void OnEnabled() {

    }

    public void OnDisabled() {

    }

}