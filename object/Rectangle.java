public class Rectangle {
    float height;
    float width;
    float p;
    float s;

    public Rectangle(float h, float w){
        height = h;
        width = w;
    }

    public void Perimetr(){
        p = 2 * (height + width);
    }

    public void Square(){
        s = height * width;
    }

    public void ChangeHeight(float h){
        height= h;
    }
    public void ChangeWidth(float w){
        width = w;
    }

    public float GetP(){
        return p;
    }
    public float GetS(){
        return s;
    }
}
