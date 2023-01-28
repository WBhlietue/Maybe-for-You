public class Engine
{
    private double speed;
    private String type;
    public Engine(double speed, String type)
    {
        this.speed = speed;
        this.type = type;
    }
    public String toString()
    {
        return "Engine { speed = " + speed + ", type = " + type + "}"; 
    }
}