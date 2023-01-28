public class Student
{
    private static Score score;
    public static void main()
    {
        score = new Score(59.9);
        System.out.println("Оюутан " + score.getScore() + " оноотой байна");
    }
}