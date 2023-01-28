public abstract class People implements Print
{
    protected String name;
    protected int age;
    
    public abstract void setName(String n);
    public abstract String getName();
    public abstract void setAge(int a);
    public abstract int getAge();
}