import java.io.*;
public class Picture implements Serializable
{
    public String name;
    public int id;
    public Picture(String name, int id)
    {
        this.name = name;
        this.id = id;
    }
    public String toString()
    {
        return "name: " + name + "\nid: " + id;
    }
}