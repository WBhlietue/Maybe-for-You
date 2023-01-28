public class Num
{
    private int num;
    public Num(int i, int j)
    {
        num = i * j;
    }
    public String toString()
    {
        if(num < 10)
        {
            return " " + num;
        }
        return ""  + num;
    }
}