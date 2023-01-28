package Register;

public class Date {
    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d) {
        year = y;
        month = m;
        day = d;
    }

    public String ConvertToString() {
        return year + "-" + month + "-" + day;
    }

    @Override
    public String toString() {
        return year + "-" + month + "-" + day;
    }

    public static Date FromString(String str) {
        if (str.equals("null")) {
            return null;
        }
        String[] s = str.split("-");
        return new Date(Integer.parseInt(s[0]), Integer.parseInt(s[1]), Integer.parseInt(s[2]));
    }

    public int getYear() {
        return year;
    }

    public int getDay() {
        return day;
    }

    public void setDay(int day) {
        this.day = day;
    }

    public int getMonth() {
        return month;
    }

    public void setMonth(int month) {
        this.month = month;
    }

    public void setYear(int year) {
        this.year = year;
    }

}
