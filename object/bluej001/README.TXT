------------------------------------------------------------------------
This is the project README file. Here, you should describe your project.
Tell the reader (someone who does not know anything about this project)
all they need to know. The comments should usually include at least:
------------------------------------------------------------------------

PROJECT TITLE:
PURPOSE OF PROJECT:
VERSION or DATE:
HOW TO START THIS PROJECT:
AUTHORS:
USER INSTRUCTIONS:


public class Main
{
    // main  үйлдлээ зарлана.
    public static void main(String[] arg)
    {
        // Circle class-аас шинээр circle гэдэг object үүсгэнэ.
        Circle circle = new Circle();
        
        // circle object-оор дамжаад Circle class-ын Print() үйлдлийг дуудна.
        circle.Print();
        
    }
}