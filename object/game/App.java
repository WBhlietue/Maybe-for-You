public class App {
    public static void main() {
        new GameManager();
        Player player = new Player();
        player.Init(100, 100, "image/bowl.png", 600, 500);
        Wall wall1 = new Wall();
        wall1.Init(100, 2000, "image/wall.png", -0, 0);
        wall1.name = "leftWall";
        Wall wall2 = new Wall();
        wall2.Init(100, 2000, "image/wall.png", 1165, 0);
        wall2.name = "rightWall";
        CollisionManager.addCheckObj(wall1);
        CollisionManager.addCheckObj(wall2);
        CollisionManager.addtargetObj(player);
    }
}
