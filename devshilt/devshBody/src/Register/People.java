package Register;




public class People {
    private String surName;
    private String name;
    private Date birth;
    private String registrNum;
    private String phone;
    private String email;

    public People(String sN, String n, Date b, String reg, String ph, String em) {
        surName = sN;
        name = n;
        birth = b;
        registrNum = reg;
        phone = ph;
        email = em;
    }

    public String ConvertToString(){
        return surName + "`" + name + "`" + birth.ConvertToString() + "`" + registrNum + "`" + phone + "`" + email;
    }
    public static People FromString(String str){
        String[] s = str.split("`");
        return new People(s[0], s[1], Date.FromString(s[2]), s[3], s[4], s[5]);
    }

    public String getSurName() {
        return surName;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getRegistrNum() {
        return registrNum;
    }

    public void setRegistrNum(String registrNum) {
        this.registrNum = registrNum;
    }

    public Date getBirth() {
        return birth;
    }

    public void setBirth(Date birth) {
        this.birth = birth;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setSurName(String surName) {
        this.surName = surName;
    }
}
