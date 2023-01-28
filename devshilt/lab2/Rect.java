public class Rect extends Shape {
    private double height;
    private double width;

    public Rect(double h, double w) {
        height = h;
        width = w;
    }

    @Override
    public double GetArea() {
        return height * width;
    }

    @Override
    public String toString() {
        return "height: " + height + ", width: " + width + ", Area: " + String.format("%,.2f", GetArea());
    }
}
