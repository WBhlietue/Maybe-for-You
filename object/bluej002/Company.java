public class Company
{
    public String name;
    public Employee[] workers;
    
    int count = 0;
    
    public Company(String name, int nums)
    {
        this.name = name;
        workers = new Employee[nums];
    }
    public void addWorkers(Employee work, Date1 date){
        workers[count] = work;
        workers[count].setHiredDay(date);
        count ++;
    }
    public Employee getOlder()
    {
        int num = 0;
        int dateNum = workers[0].getHiredDay().calcNum();
        for(int i = 1; i < count; i++){
            if(dateNum > workers[i].getHiredDay().calcNum())
            {
                dateNum = workers[i].getHiredDay().calcNum();
                num = i;
            }
        }
        return workers[num];
    }
    public String toString()
    {
        String info = "==== " + name + " ====\najilchnii too: " + count + "\n" + "workers: \n";
        for(int i = 0; i < count; i++)
        {
            info += ("\t" +  workers[i] + "\n");
        }
        return info;
    }
}