public class Circle
{
    // float төрлийн өгөгдөл үүсгэнэ.
    private float radius;

    // Байгуулагч функцээр radius өгөгдөлд утга өгнө.
    public Circle(float r)
    {
        radius = r;
    }

    // radius радиустай тойгийн талбайг олж буцаана.
    public float Get()
    {
        float s = radius * radius * 3.14f;
        return s;
    }
}