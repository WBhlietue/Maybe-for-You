public class Person
{
    private Job job;
    public Person()
    {
        job = new Job();
        job.setSalary(1000000);
        job.setRole("bagsh");
        job.setID(33);
    }
    public long getSalary()
    {
        return job.getSalary();
    }
    public String getRole()
    {
        return job.getRole();
    }
    public int getID()
    {
        return job.getID();
    }
}