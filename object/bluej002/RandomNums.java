import java.lang.*;

public class RandomNums
{
    public static void main(String[] args)
    {
        Print(Math.random());
        Print(Math.random() + 3);
        Print(Math.random() * 5);
        Print((int)(Math.random() * 5));
        Print(Math.random() * 5 + 3);
        Print((int)(Math.random() * 5 + 3));
        Print((int)(Math.random() * 11 - 5));
    }
    static void Print(Object a)
    {
        System.out.println(a);
    }
}