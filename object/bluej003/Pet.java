public class Pet
{
    public String name;
    public String type;
    public int age;
    public String getName()
    {
        return name;
    }
    public void setName(String n)
    {
        name = n;
    }
    public String getType()
    {
        return type;
    }
    public void setType(String t)
    {
        type = t;
    }
    public int getAge()
    {
        return age;
    }
    public void setAge(int a)
    {
        age = a;
    }
    public String Speak()
    {
        return "name: " + name + ", type: " + type + ", age: " + age;
    }
}