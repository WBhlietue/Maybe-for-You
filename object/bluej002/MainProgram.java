public class MainProgram
{
    public static void main()
    {
        Pilot man1 = new Pilot("Bold");
        Pilot man2 = new Pilot("Bayar");
        AirPlane plane = new AirPlane("Boeing 747", 350);
        plane.assignPilot(man1);
        System.out.println(man1);
        man2 = plane.getPilot();
        System.out.println(plane);
        System.out.println(man2);
    }
}