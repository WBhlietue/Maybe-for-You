public class CoffeeMug extends CoffeeCup
{
    public String coffeeName;
    public String material;
    public String picture;
    
    public CoffeeMug(String cupType, double size, String color, 
                String cType, boolean milk, boolean black, boolean sugar,
                String cName, String mat, String map)
    {
        super(cupType, size, color, cType, milk, black, sugar);
        coffeeName = cName;
        material = mat;
        picture = map;
    }
    
    public String toString()
    {
        String s = super.toString() + "\n";
        String t = "coffeeName: " + coffeeName + ", material: " + material + "\npicture: " + picture;
        return s + t;
        
    }
}