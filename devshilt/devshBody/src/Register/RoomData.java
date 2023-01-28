package Register;




public class RoomData {
    private People people;
    private Room room;
    private Date date;

    public RoomData(People p, Room r, Date d) {
        people = p;
        room = r;
        date = d;
    }

    public String ConvertToString() {
        if (people == null) {
            return "null/" + room.ConvertToString() + "/null";
        }
        return people.getRegistrNum() + "/" + room.ConvertToString() + "/" + date.ConvertToString();
    }

    public static RoomData FromString(String str) {
        String[] s = str.split("/");
        return new RoomData(PeopleRegister.GetWithRegistrNum(s[0]), Room.FromString(s[1]), Date.FromString(s[2]));
    }

    @Override
    public String toString() {
        if (people == null) {
            return room.getCode() + " - empty";
        }
        return room.getCode() + " - " +people.getName() + " - " + people.getRegistrNum() + " - " + date + " - " + people.getEmail() + " - " + people.getPhone();
    }

    public People getPeople() {
        return people;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public Room getRoom() {
        return room;
    }

    public void setRoom(Room room) {
        this.room = room;
    }

    public void setPeople(People people) {
        this.people = people;
    }

    public void Reset() {
        date = null;
        people = null;
    }
}
