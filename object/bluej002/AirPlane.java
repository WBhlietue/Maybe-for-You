public class AirPlane
{
    private String model;
    private int capacity;
    private Engine engine;
    private Pilot pilot;
    public AirPlane(String model, int capacity)
    {
        Engine engine = new Engine(2400.0, "IO-360");
        this.model = model;
        this.engine = engine;
        this.capacity = capacity;
    }
    
    public void assignPilot(Pilot pilot)
    {
        this.pilot = pilot;
    }
    public Pilot getPilot()
    {
        return pilot;
    }
    public String toString()
    {
        return "AirPlane { model = " + model + ", capacity = " + capacity + ", Engine = " + engine + ", Pilot = " + pilot + "}";
    }
}