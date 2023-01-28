import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Traingle[] traingle = new Traingle[3];
        traingle[0] = new Traingle(10);
        traingle[1] = new Traingle(10, 15);
        traingle[2] = new Traingle(10, 15, 20);
        System.out.println("input height: ");
        double height = sc.nextDouble();
        System.out.println("input degree: ");
        double degree = sc.nextDouble();
        for (int i = 0; i < 3; i++) {

            // Өгөгдсөн талуудтай гурвалжин суурьтай 3D биетүүдийн эзэлхүүнг хэвлэнэ
            System.out.print("a = " + traingle[i].getA() + ", b = " + traingle[i].getB());
            System.out.print(", c = " + traingle[i].getC() + ", h = " + height + " ");
            System.out.println("урттай гурвалжин суурьтай: ");
            System.out.println("Призмийн эзэлхүүн нь " + traingle[i].getVolume(height));
            System.out.println("Пирамидын эзэлхүүн нь " + traingle[i].getVolume(height, true));
            System.out.println("Харин суурьтай " + degree + " өнцгөөр налуу призмийн эзэлхүүн нь "
                    + traingle[i].getVolume(height, degree));
            System.out.println("Пирамидын эзэлхүүн нь " + traingle[i].getVolume(height, degree, true));
            System.out.println();
        }
    }
}