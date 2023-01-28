import java.lang.*;
public class MathFunctions
{
    public static void main(String[] args)
    {
        Print(Math.abs(-2.3));
        Print(Math.round(Math.PI));
        Print(Math.round(9.5));
        Print(Math.round(9.5 - 0.0001));
        Print(Math.ceil(9.4));
        double c = Math.sqrt(3 * 3 + 4 * 4);
        Print(c);
        double d = Math.cos(Math.toRadians(60));
        Print(d);
        
    }
    static void Print(Object a)
    {
        System.out.println(a);
    }
}