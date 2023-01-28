public class Tailan3
{
    public static void main()
    {
        Num[][] nums = new Num[9][9];
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++){
                nums[i][j] = new Num(i + 1, j + 1);
            }
        }
        System.out.print(" ");
        for(int i = 0; i < 9; i++){
            System.out.print("  " + (i + 1));
        }
        for(int i = 0; i < 9; i++)
        {
            System.out.println("");
            System.out.print((i + 1) + " ");
            for(int j = 0; j < 9; j++){
                System.out.print(nums[i][j] + " ");
            }
        }
        
    }
}