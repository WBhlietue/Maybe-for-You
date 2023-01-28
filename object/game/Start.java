public class Start
{
    public static void main()
    {
        Test t = new Test();
        t.Init(100, 100, "image/bowl.png", 600, -100);
        CollisionManager.addtargetObj(t);
        
        
        Wall wall1 = new Wall();
        wall1.Init(2000, 100, "image/wall.png", -0, 600);
        wall1.name = "leftWall";
        CollisionManager.addCheckObj(wall1);
    }
}