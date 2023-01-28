import java.awt.event.KeyEvent;

public class Player extends Game {

    Vector chiglel = new Vector(0, 0);

    int speed = 5;

    boolean moveLeft = true;
    boolean moveRigth = true;

    
    public void Awake() {
        new Input();
        name = "Player";
    }

    
    public void Update() {
        if ((!moveLeft && chiglel.x < 0) || (!moveRigth && chiglel.x > 0)) {
            chiglel = Vector.zero;
        }
        setPosition(getPostion().Add(chiglel.Mult(speed)));
    }

    
    public void collideStart(Game other) {
        switch (other.name) {
            case "leftWall":
                moveLeft = false;
                break;
            case "rightWall":
                moveRigth = false;
                break;
            case "food":
                GameManager.instance.addScore(1);
                other.enabled = false;
                other.setAcive(false);
                break;
        }
    }

    
    public void Collide(Game other) {
        switch (other.name) {
            case "leftWall":
                moveLeft = false;
                break;
            case "rightWall":
                moveRigth = false;
                break;
        }
    }

    
    public void collideEnd(Game other) {
        switch (other.name) {
            case "leftWall":
                moveLeft = true;
                break;
            case "rightWall":
                moveRigth = true;
                break;
        }
    }

    class Input extends Key {
        
        public void keyPressed(KeyEvent e) {
            switch (e.getKeyCode()) {
                case KeyEvent.VK_A:
                    if (moveLeft) {
                        chiglel.x = -1;
                    } else {
                        chiglel.x = 0;
                    }
                    break;
                case KeyEvent.VK_D:
                    if (moveRigth) {
                        chiglel.x = 1;
                    } else {
                        chiglel.x = 0;
                    }
                    break;
            }
        }

        
        public void keyReleased(KeyEvent e) {
            switch (e.getKeyCode()) {
                case KeyEvent.VK_A:
                    chiglel.x = 0;
                    break;
                case KeyEvent.VK_D:
                    chiglel.x = 0;
                    break;
            }
        }
    }
}
