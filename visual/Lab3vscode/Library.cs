using System.Collections.Generic;

namespace Lab3vscode
{
    public class Library
    {
        List<Book> book = new List<Book>();
        public void AddBook(Book b){
            book.Add(b);
        }
        public void RemoveWithISBN(string isbn){
            Book b = FindWithISBN(isbn);
            if(b != null){
                book.Remove(b);
            }else{
                Console.WriteLine("no this book");
            }
        }

        public void Remove(Book b){
            for(int i = 0; i < book.Count; i++){
                if(book[i].CheckSame(b)){
                    book.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("no this book");
        }


        public List<Book> FindWithName(string name){
            List<Book> b = new List<Book>();
            for(int i = 0; i < book.Count; i++){
                if(book[i].CheckName(name)){
                    b.Add( book[i]);
                }
            }
            return b;
        }
        public Book FindWithISBN(string isbn){
            for(int i = 0; i < book.Count; i++){
                if(book[i].CheckName(isbn)){
                    return book[i];
                }
            }
            return null;
        }
        public List<Book> FindWithAuthor(string author){
            List<Book> b = new List<Book>();
            for(int i = 0; i < book.Count; i++){
                if(book[i].CheckAuthor(author)){
                    b.Add( book[i]);
                }
            }
            return b;
        }
        public List<Book> GetAll(){
            return book;
        }
    }
    public class Book{
        string name;
        string author;
        string isbn;
        public Book(string n, string a, string isb){
            name = n;
            author = a;
            isbn = isb;
        }
        public bool CheckName(string n){
            return n == name;
        }
        public bool CheckISBN(string isb){
            return isbn == isb;
        }
        public bool CheckAuthor(string a){
            string[] aut = author.Split(", ");
            for(int i = 0; i < aut.Length; i++){
                if(aut[i] == a){
                    return true;
                }
            }
            return false;
        }
        public bool CheckSame(Book book){
            return book.name == name && book.author == name && book.isbn == isbn;
        }
        public override string ToString(){
            return "name = " + name + "| author = " + author + "| ISBN = " + isbn;
        }
    }
}