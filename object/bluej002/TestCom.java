public class TestCom
{
    public static void main()
    {
        Employee emp1 = new Employee("Bat", "Bold", new Date1(2000, 2, 29));
        Employee emp2 = new Employee("Zolboo", "Bayar", new Date1(1999, 10, 22));
        System.out.println(emp1);
        System.out.println(emp2);
        System.out.println("\n");
        Company com = new Company("SICT GROUP", 10);
        com.addWorkers(emp1, new Date1(2020, 12, 1));
        com.addWorkers(emp2, new Date1(2019, 5, 25));
        System.out.println(com);
        System.out.println("hangiin udaan ajilsan ni: \n\t" + com.getOlder());
    }
}