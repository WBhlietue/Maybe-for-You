public class Test12312312333 {
    public static void main(String[] args) {
        // Gurwaljin a = new Gurwaljin(new Koordinat(5 , 3), new Koordinat(3, 2), new
        // Koordinat(4, 4));
        System.out.println(Koordinat.Distance(new Koordinat(0, 0), new Koordinat(4, 3)));
        Koordinat x = new Koordinat(0, 0);
        Koordinat y = new Koordinat(4, 3);
        System.out.println(Koordinat.Distance(x, y));
        // String a = "112312312333";
        // String[] s = "112312312333".split("2");
        System.out.println("112312312333".split("2")[1].charAt(0));
    }
}

class Koordinat {

    public int x, y;

    public Koordinat(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public static int Distance(Koordinat x, Koordinat y) {
        return (int) (Math.sqrt(Math.pow(x.x - y.x, 2) + Math.pow(x.y - y.y, 2)));
    }

    @Override
    public String toString() {
        return "(" + x + ", " + y + ")";
    }
}

class Gurwaljin {
    Koordinat first, second, third;

    public Gurwaljin(Koordinat first, Koordinat second, Koordinat third) {
        this.first = first;
        this.second = second;
        this.third = third;
    }

    @Override
    public String toString() {
        return first + " " + second + " " + third;
    }
}