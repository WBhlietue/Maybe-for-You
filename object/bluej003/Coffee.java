public class Coffee
{
    public static void main()
    {
        CoffeeMug mug = new CoffeeMug("coffee", 10, "red", "Mug", true, false, true, "mac coffee", "porcelain", "forest");
        EspressoCup cup = new EspressoCup("coffee", 6, "white", "Cup", false, true, false, "americano", "glass", "white", 8);
        System.out.println(mug);
        System.out.println("\n\n");
        System.out.println(cup);
    }
}