public class Teacher extends Person
{
    private String albanTushaal;
    private int salary;
    public Teacher(String a, int s, String name, int age)
    {
        super(name, age);
        albanTushaal = a;
        salary = s;
    }
    public String toString()
    {
        return  super.toString() + ", albanTushaal: " + albanTushaal + ", tsalin: " + salary;
    }
    
    public void display()
    {
        System.out.println(this);
    }
}