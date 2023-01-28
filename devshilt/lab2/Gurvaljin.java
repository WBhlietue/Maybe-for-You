public class Gurvaljin extends Shape {

    private double base;
    private double height;

    public Gurvaljin(double b, double h) {
        base = b;
        height = h;
    }

    @Override
    public double GetArea() {
        return (double)base * height / 2;
    }

    @Override
    public String toString() {
        return "base: " + base + ", height: " + height + ", Area: " + String.format("%,.1f", GetArea());
    }

}
