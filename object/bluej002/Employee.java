public class Employee
{
    private String firstName, lastName;
    private Date1 birthDay, hiredDay;
    public Employee(String _firstName, String _lastName, Date1 birth)
    {
        lastName = _lastName;
        firstName = _firstName;
        birthDay = birth;
    }
    public void setHiredDay(Date1 date)
    {
        hiredDay = date;
    }
    public Date1 getHiredDay()
    {
        return hiredDay;
    }
    public String toString()
    {
        return firstName + " " + lastName + ": hired day = " + hiredDay + ", birth day = " + birthDay;
    }
}