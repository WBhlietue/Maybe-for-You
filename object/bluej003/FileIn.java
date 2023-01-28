import java.io.*;
import java.util.*;

public class FileIn
{
    public static void main()
    {
        try
        {
            File file = new File("te55st.txt");
            Scanner sc = new Scanner(file);
            while(sc.hasNextLine())
            {
                String data = sc.nextLine();
                System.out.println(data);
            }
            sc.close();
        }
        catch(FileNotFoundException e)
        {
            System.out.println("File oldohgui baina");
        }
    }
}