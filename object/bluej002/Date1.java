public class Date1
{
    private int year, month, day;
    
    public Date1(int year, int month, int day){
        this.year = year;
        this.month = checkMonth(month);
        this.day = checkDay(day);
    }
    
    int checkMonth(int month)
    {
        if(month > 0 && month <= 12)
        {
            return month;
        }
        return -1;
    }
    
    int checkDay(int day)
    {
        int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        if(day > 0 && day <= days[month - 1]){
            return day;
        }
        if(month == 2 && day == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 100))){
            return day;
        }
        return -1;
    }
    public int calcNum()
    {
        return (year * 10 + month) * 10 + day;
    }
    public String toString()
    {
        return year +  "/" + month + "/" + day;
    }
    
}