import java.util.*;

public class Lab5Main
{
    public static void main()
    {
        Calendar cal = Calendar.getInstance();
        System.out.println("Өнөөдөр: " + (cal.get(Calendar.MONTH) + 1) + "/" + 
                            cal.get(Calendar.DATE) + "/" + cal.get(Calendar.YEAR));
    }
    
    
}