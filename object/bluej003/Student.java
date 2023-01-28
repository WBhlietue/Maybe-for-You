public class Student extends Person
{
    public String code;
    public Student(String name, int age, String c)
    {
        super(name, age);
        code = c;
    }
    
    public String toString()
    {
        return "name: " + name + ", age: " + age + ", code:" + code;
    }
}