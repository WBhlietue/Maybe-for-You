public class Demo
{
    public static void main()
    {
        Person[] p = new Person[4];
        p[0] = new Person("Bata", 18);
        p[1] = new Sportsman(60, 170, "Bold", 20);
        p[2] = new TennisPlayer("Gold", "ABC", 70, 190, "Dorj", 20);
        p[3] = new Teacher("bagsh", 10000000, "Enkh", 30);
        
        for(Person i : p)
        {
            i.display();
        }
    }
}