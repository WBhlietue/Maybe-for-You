import java.io.*;

public class Book implements Serializable
{
    private String name;
    private double price;
    public String type;
    
    public Book()
    {
        name = "book";
    }
    
    public Book(String name, double _price)
    {
        this.name = name;
        price = _price;
    }
    
    
    public Book(String _name, double _price, String _type)
    {
        name = _name;
        price = _price;
        type = _type;
    }
    
    public String getName()
    {
        return name;
    }
    public void setName(String _name)
    {
        name = _name;
    }
    public double getPrice()
    {
        return price;
    }
    public void setPrice(double _price)
    {
        price = _price;
    }
    
    public double calcPrice(int num)
    {
        double value = 1;
        double p = 0;
        if(num >= 3)
        {
            value = 0.98;
        }
        try
        {
            p = price * num * value;
        }catch(ArithmeticException e)
        {
            System.out.println("Arithmetic aldaa garlaa");
        }
        return p;
    }
    
    public void printInfo()
    {
        System.out.println("name: " + name + ", price: " + price + ", type: " + type);        
    }
}