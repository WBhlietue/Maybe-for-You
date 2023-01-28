public class TTT12312312333 {
    public static void main(String[] args) {
        // Circle as = new Circle(21);
        System.out.println(new Circle(21));
    }
}

class Circle{
    int radius;
    static final float p = 3.14f;
    public Circle(int radius){
        this.radius = radius;
    }
    public float Squrae(){
        return radius * radius * p;
    }
    @Override
    public String toString() {
        return "radius = " + radius + ", Square = " + Squrae();
    }
}
