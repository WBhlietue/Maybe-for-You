public class Vector {

    public static final Vector up = new Vector(0, -1);
    public static final Vector down = new Vector(0, 1);
    public static final Vector right = new Vector(1, 0);
    public static final Vector left = new Vector(-1, 0);
    public static final Vector zero = new Vector(0, 0);
    public static final Vector one = new Vector(1, 1);

    public int x;
    public int y;

    public Vector(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public Vector Add(Vector another) {
        return new Vector(x + another.x, y + another.y);
    }

    public Vector Less(Vector another) {
        return new Vector(x - another.x, y - another.y);
    }

    public Vector Mult(int a) {
        return new Vector(x * a, y * a);
    }

    public Vector Div(int a) {
        return new Vector(x / a, y / a);
    }

    public static int Distance(Vector a, Vector b) {
        return (int) Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
    }

    public int Lenght() {
        return (int) Math.sqrt(x * x + y * y);
    }

    public String toString() {
        return "(" + x + ", " + y + ")";
    }
}
