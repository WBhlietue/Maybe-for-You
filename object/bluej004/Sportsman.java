public class Sportsman extends Person
{
    private int weight;
    private int height;
    
    public Sportsman(int w, int h, String name, int age)
    {
        super(name, age);
        weight = w;
        height = h;
    }
    
    public String toString()
    {
        return  super.toString() + ", jin: " + weight + ", undur: " + height;
    }
    
    public void display()
    {
        System.out.println(this);
    }
}