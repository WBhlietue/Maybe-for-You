// Энэ санг оруулснаар гараас 
// утга авах боломжтой болно.
import java.util.Scanner; 

public class Main
{
    public static void main(String[] args)
    {
        // Гараас float төрлийн утга авна.
        float r = new Scanner(System.in).nextFloat(); 

        // Circle class-аас circle нэртэй object 
        // үүсгэж байгуулагч функцэд саяны утгийг өгнө.
        Circle circle = new Circle(r);

        // circle object-оор дамжин Get үйлдлийг дуудаж
        // тойргийн талбайг хэвлэж гаргана.
        System.out.print(circle.Get()); 
    }
}