import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Rectangle rec1 = new Rectangle();
        Rectangle rec2 = new Rectangle(10.5, 30.2);
        Scanner sc = new Scanner(System.in);
        System.out.print("rec1 width = ");
        rec1.SetWidth(sc.nextDouble());
        System.out.print("rec1 height = ");
        rec1.SetHeight(sc.nextDouble());

        System.out.println("rec1: width = " + rec1.GetWidth() + ", height = " + rec1.GetHeight());
        System.out.println("rec2: width = " + rec2.GetWidth() + ", height = " + rec2.GetHeight());

        System.out.println(
                "rec1: Area = " + String.format("%,.2f", rec1.GetArea()) + ", Perimetr = " + rec1.GetPerimetr());
        System.out.println(
                "rec2: Area = " + String.format("%,.2f", rec2.GetArea()) + ", Perimetr = " + rec2.GetPerimetr());

        System.out.println("");

        ChekingAccount check = new ChekingAccount(100, "123", 100000);
        ChekingAccount checkFail = new ChekingAccount(10000, "456", 100);
        SavingAccount save = new SavingAccount(20, "789", 100000);

        check.DeductFee();
        checkFail.DeductFee();
        save.AddInterest();

        System.out.println("");

        double b, h;
        System.out.print("tr base = ");
        b = sc.nextDouble();
        System.out.print("tr height = ");
        h = sc.nextDouble();
        Gurvaljin tr = new Gurvaljin(b, h);
        System.out.println("gurvaljin = " + tr);

        System.out.print("rec wigth = ");
        b = sc.nextDouble();
        System.out.print("rec height = ");
        h = sc.nextDouble();
        Rect rec = new Rect(h, b);
        System.out.println("tegsh untsugt = " + rec);

        sc.close();
    }
}
