package Register;



public class Room {
    private String code;

    public Room(String c){
        code = c;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String ConvertToString(){
        return code;
    }
    public static Room FromString(String str){
        return new Room(str);
    }

    @Override
    public String toString() {
        return code;
    }
}
