public class TennisPlayer extends Sportsman
{
    private String rank;
    private String club;
    
    public TennisPlayer(String r, String c, int w, int h, String name, int age)
    {
        super(w, h, name, age);
        rank = r;
        club = c;
    }
    public String toString()
    {
        return  super.toString() + ", rank: " + rank + ", club: " + club;
    }
    
    public void display()
    {
        System.out.println(this);
    }
}