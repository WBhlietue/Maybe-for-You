public class B extends A
{
    public int b;
    
    public B(int a1, int b1)
    {
        super(a1);
        b = b1;
    }
    public void procB()
    {
        System.out.println("A = " + super.getA());
        System.out.println("B = " + b);
    }
}