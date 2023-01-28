public class Rectangle {
    private double width;
    private double height;

    public Rectangle() {
    }

    public Rectangle(double w, double h) {
        width = w;
        height = h;
    }

    public void SetWidth(double w) {
        width = w;
    }

    public void SetHeight(double h) {
        height = h;
    }

    public double GetWidth() {
        return width;
    }

    public double GetHeight() {
        return height;
    }

    public double GetArea() {
        return width * height;
    }

    public double GetPerimetr() {
        return 2 * (width + height);
    }
}
