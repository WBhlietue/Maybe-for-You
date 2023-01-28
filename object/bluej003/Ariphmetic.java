import java.util.*;
public class Ariphmetic
{
    public static void main()
    {
        int a = 50, b, c;
        try
        {
            Scanner sc = new Scanner(System.in);
            b = sc.nextInt();
            c = a / b;
            System.out.println(c);
        }catch (ArithmeticException e1)
        {
            System.out.println("aldaa");
        }
    }
}