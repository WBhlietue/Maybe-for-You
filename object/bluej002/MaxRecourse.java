public class MaxRecourse
{
    public static void main(String[] args)
    {
        int[] a = {35, 74, 32, 92, 53, 28, 50, 62};
        Print("Max: " + max(0, 7, a));
    }
    public static int max(int i, int j, int[] arr)
    {
        if(j - i <= 1)
        {
            return arr[(arr[j] >= arr[i] ? j : i)];
        }else
        {
            int m1 = max(i, (i + j) / 2, arr);
            int m2 = max((i + j) / 2 + 1, j, arr);
            return (m1 > m2 ? m1 : m2);
        }
    }
    static void Print(Object a)
    {
        System.out.println(a);
    }
}