public class CoffeeCup extends Cup
{
    public String coffeeType;
    public boolean haveMilk;
    public boolean isBlack;
    public boolean haveSugar;
    
    public CoffeeCup(String cupType, double size, String color, 
                String cType, boolean milk, boolean black, boolean sugar)
    {
        super(cupType, size, color);
        coffeeType = cType;
        haveMilk = milk;
        isBlack = black;
        haveSugar = sugar;
    }
    
    public String toString()
    {
        String cup = "cupType: " + cupType + ", size: " + size + ", color: " + color + "\n";
        String bools = ", haveMilk:" + haveMilk + ", isBlack: " + isBlack + ", haveSugar: " + haveSugar;
        return cup + "coffeeCupType: " + coffeeType + bools;
    }
}