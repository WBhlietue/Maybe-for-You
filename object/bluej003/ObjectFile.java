import java.io.*;

public class ObjectFile
{
    public static void main()
    {
        Picture pic1 = new Picture("abc", 12);
        Picture pic2 = new Picture("defg", 7);
        try
        {
            FileOutputStream fOut = new FileOutputStream(new File("test1.txt"));
            ObjectOutputStream oOut = new ObjectOutputStream(fOut);
            oOut.writeObject(pic1);
            oOut.writeObject(pic2);
            oOut.close();
            FileInputStream fIn = new FileInputStream(new File("test1.txt"));
            ObjectInputStream oIn = new ObjectInputStream(fIn);
            pic2 = (Picture)oIn.readObject();
            pic1 = (Picture)oIn.readObject();
            oIn.close();
            System.out.println("p2 = " + pic2);
            System.out.println("p1 = " + pic1);
        }
        catch(FileNotFoundException e)
        {
            System.out.println("File oldohgui baina");
        }
        catch(IOException e)
        {
            System.out.println("oroltiin aldaa");
        }
        catch(ClassNotFoundException e)
        {
            System.out.println("class iin aldaa");
        }
    }
}