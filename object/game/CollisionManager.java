import java.lang.Thread;
import java.util.*;
import java.util.List;
import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class CollisionManager extends Thread {
    List<Game> targetObjects = new ArrayList<Game>();
    List<Game> checkObject = new ArrayList<Game>();
    long delay;
    public static CollisionManager instance;

    public void run() {
        while (true) {
            try {
                Thread.sleep(delay);
                Check();

            } catch (Exception e) {

            }
        }
    }

    public CollisionManager() {
        instance = this;
        delay = 1000 / 60;
        start();
    }

    public static void addCheckObj(Game game) {
        CollisionManager.instance.addCheck(game);
    }

    void addCheck(Game game) {
        checkObject.add(game);
    }

    public static void addtargetObj(Game game) {
        CollisionManager.instance.addTarget(game);
    }

    void addTarget(Game game) {
        targetObjects.add(game);
    }

    public static void removeCheckObj(Game game) {
        CollisionManager.instance.remvoeCheck(game);
    }

    void remvoeCheck(Game game) {
        checkObject.remove(game);
    }

    public static void removeTargetObj(Game game) {
        CollisionManager.instance.removeTarget(game);
    }

    void removeTarget(Game game) {
        targetObjects.remove(game);
    }

    public void Check() {
        for (Game i : targetObjects) {
            for (Game j : checkObject) {
                if (i != j) {
                    if (i.thisObj.getBounds().intersects(j.thisObj.getBounds())) {
                        if (!i.isCollided) {
                            i.isCollided = true;
                            i.collideStart(j);
                            i.coll = j;
                        } else {
                            i.Collide(j);
                        }
                    } else if (i.isCollided && j == i.coll) {
                        i.isCollided = false;
                        i.coll = null;
                        i.collideEnd(j);
                    }
                }
            }
        }
    }

}