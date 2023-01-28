public class EspressoCup extends CoffeeCup
{
    public String coffeeName;
    public String material;
    public String tavagColor;
    public int tavagSize;
    
    public EspressoCup(String cupType, double size, String color, 
                String cType, boolean milk, boolean black, boolean sugar,
                String cName, String mat, String tColor,  int tSize)
    {
        super(cupType, size, color, cType, milk, black, sugar);
        coffeeName = cName;
        material = mat;
        tavagColor = tColor;
        tavagSize = tSize;
    }
    
     public String toString()
    {
        String s = super.toString() + "\n";
        String t = "coffeeName: " + coffeeName + ", material: " + material;
        String tv = "\ntavagColor: " + tavagColor + ", tavagSize: " + tavagSize;
        return s + t + tv;
        
    }
}