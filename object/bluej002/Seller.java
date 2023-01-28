import java.util.Scanner;
import java.io.*;

public class Seller
{
    public static void main(String[] args)
    {
        int number, too;
        Scanner scanner = new Scanner(System.in);
        Book[] bk = new Book[3];
        
        bk[0] = new Book();
        bk[1] = new Book("book 2", 10000);
        bk[2] = new Book("book 3", 5000, "science");
        
        bk[0].printInfo();
        bk[1].printInfo();
        bk[2].printInfo();
        
        System.out.println("Ali nomiig avah ve?");
        number = scanner.nextInt();
        System.out.println("hediig avah ve?");
        too = scanner.nextInt();
        Book avsanNom;
        try
        {
            avsanNom = bk[number - 1];
        }
        catch(ArrayIndexOutOfBoundsException e)
        {
            System.out.println("tiim nom alga");
            return;
        }
        try
        {
            System.out.println("Negj une: " + avsanNom.getPrice() + ", too: " + too);
            System.out.println("Niit une: " + avsanNom.calcPrice(too));
        }catch(NullPointerException e)
        {
            System.out.println("null");
        }
        
        
        try
        {
            FileOutputStream fOut = new FileOutputStream(new File("test1.txt"));
            ObjectOutputStream oOut = new ObjectOutputStream(fOut);
            oOut.writeObject(avsanNom);
            oOut.close();
            FileInputStream fIn = new FileInputStream(new File("test1.txt"));
            ObjectInputStream oIn = new ObjectInputStream(fIn);
            avsanNom = (Book)oIn.readObject();
            oIn.close();
            System.out.println("\n\n");
            avsanNom.printInfo();
        }catch(FileNotFoundException e)
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