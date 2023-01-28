public class TestPerson
{
    public static void main()
    {
        Person person = new Person();
        long salary = person.getSalary();
        String role = person.getRole();
        int id = person.getID();
        System.out.println("salary = " + salary);
        System.out.println("role = " + role);
        System.out.println("id = " + id);
    }
}