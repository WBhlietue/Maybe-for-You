using System;
namespace Lab3vscode
{
    public class Program{
        public static void Main(){
            Print(MyCalc.Add(1.4, 5));
            Print(MyCalc.Substruct(1.4, 5.4));
            Print(MyCalc.Multiply(1.4, 5.4));
            Print(MyCalc.Divide(1.4, 2));

            Library lib = new Library();
            lib.AddBook(new Book("ABC", "Bat", "001"));
            lib.AddBook(new Book("ABC", "Dorj", "002"));
            lib.AddBook(new Book("123", "Bat", "003"));
            lib.AddBook(new Book("ASD", "Bold, Bat", "004"));

            Print("List all books");
            PrintList<Book> (lib.GetAll());

            Print("Find with author");
            PrintList<Book> (lib.FindWithAuthor("Bat"));

            Print("Find with name");
            PrintList<Book> (lib.FindWithName("ABC"));
        }

        public static void Print(object obj){
            Console.WriteLine(obj);
        }

        public static void PrintList<T>(List<T> list){
            for(int i = 0; i < list.Count; i++){
                Print(list[i]);
            }
        }
    }
}