public class Test extends Game
{
    public void Update() {
        setPosition(getPostion().Add(Vector.down.Mult(2)));
    }
    
    public void collideStart(Game other)
    {
        System.out.println(other.name);
    }
}