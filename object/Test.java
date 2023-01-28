public class Test{
    public static void main(String[] args) {
        Rectangle rect1 = new Rectangle(10, 20);
        Rectangle rect2 = new Rectangle(5.7f, 9.4f);
        rect1.Perimetr();
        rect1.Square();
        rect2.Perimetr();
        rect2.Square();

        System.out.println("1: P = " + rect1.GetP() + ", S = " + rect1.GetS());
        System.out.println("2: P = " + rect2.GetP() + ", S = " + rect2.GetS());

        Borluulalt b = new Borluulalt(1000, 5, 10);
        
        b.registerSale(10);
        b.DisplaySell();
        b.registerSale(1);
        b.DisplaySell();

    }
}