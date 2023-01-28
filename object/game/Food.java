public class Food extends Game {
    public int speed = 2;

    
    public void Update() {
        setPosition(getPostion().Add(Vector.down.Mult(speed)));
    }
}
