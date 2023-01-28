public class ArrayIndex
{
    public static void main()
    {
        int[] d = {1, 2, 3, 4};
        try
        {
            for(int i = 0; i <= d.length; i++)
            {
                System.out.print(d[i] + " ");
            }
        }catch(ArrayIndexOutOfBoundsException e)
        {
            System.out.println("\nIndex Error");
        }
    }
}