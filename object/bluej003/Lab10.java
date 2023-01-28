public class Lab10
{
    public static void main()
    {
        Pet p = new Pet();
        Dog d = new Dog();
        p.setName("ABC");
        d.setName("DEFG");
        p.setType("dog");
        d.setType("banhar");
        p.setAge(4);
        d.setAge(6);
        System.out.println(p.Speak());
        System.out.println(d.Speak());
    }
}