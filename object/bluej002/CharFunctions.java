public class CharFunctions
{
    
    public static void main(String[] args)
    {
        char c1 = '3';
        int d = Character.digit(c1, 10);
        Print("Square of " + c1 + " is " + d * d);
        char c2 = 'a';
        Character ch = new Character(c2);
        
    }
    
    static void Print(Object a)
    {
        System.out.println(a);
    }
}