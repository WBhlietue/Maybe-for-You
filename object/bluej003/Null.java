public class Null
{
    public static void main()
    {
        try
        {
            Teacher[] t = new Teacher[1];
            System.out.println(t[0]);
        }catch(NullPointerException e)
        {
            System.out.println("null");
        }
    }
}