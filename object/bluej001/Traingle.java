import java.lang.Math;

public class Traingle {

    private double a, b, c;

    // Адил талт гурвалжин
    public Traingle(double a) {
        this.a = a;
        b = a;
        c = a;
    }

    // Адил хажуут гурвалжин
    public Traingle(double a, double b) {
        this.a = a;
        this.b = b;
        c = a;
    }

    // Элдэв талт гурвалжин
    public Traingle(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // Query
    public void setA(double a) { this.a = a; }
    public void setB(double b) { this.b = b; }
    public void setC(double c) { this.c = c; }

    // Mutator
    public double getA() { return a; }
    public double getB() { return b; }
    public double getC() { return c; }

    // Өгсөн өндөртэй призмийн эзэлхүүнг олж буцаана
    public double getVolume(double height) {
        double p = (a + b + c) / 2;
        double square = Math.sqrt(p * (p - a) * (p - b) * (p - c));
        return Math.round(square * height * 100) / 100.0;
    }

   // Өгсөн өндөр, налуун өнцөгтэй налуу призмийн эзэлхүүнг олж буцаана
    public double getVolume(double baiguulagch, double degree) {
        double p = (a + b + c) / 2;
        double square = Math.sqrt(p * (p - a) * (p - b) * (p - c));
        double height = baiguulagch * Math.sin(Math.toRadians(degree));
        return Math.round(height * square * 100) / 100.0;
    }

   // Өгсөн өндөртэй пирамидийн эзэлхүүнг олж буцаана
    public double getVolume(double height, boolean isPyramid) {
        double p = (a + b + c) / 2;
        double square = Math.sqrt(p * (p - a) * (p - b) * (p - c));
        return Math.round(square * height / 3 * 100) / 100.0;
    }

    // Өгсөн өндөр, налуун өнцөгтэй налуу пирамидийн эзэлхүүнг олж буцаана
    public double getVolume(double baiguulagch, double degree, boolean isPyramid) {
        double p = (a + b + c) / 2;
        double square = Math.sqrt(p * (p - a) * (p - b) * (p - c));
        double height = baiguulagch * Math.sin(Math.toRadians(degree));
        return Math.round(height * square / 3 * 100) /100.0;
    }
}