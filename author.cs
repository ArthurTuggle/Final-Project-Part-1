using System;
using System.Collections.Generic;

public class Author:Person

{
  private List<Book> book=new List<Book>(); 
   public Author(string fname,string lname,string email):base(fname,lname){}
   public void DisplayInfo()
   {
       Console.WriteLine(fname+" "+lname+" ");
   }
   public void DisplayBooks()
   {
       foreach(var item in book){
           item.Display();
       }
   }
   public void AddBook(Book b)
   {
       b.setAuthorInfo(fname,lname);
       book.Add(b);
   }
   public void RemoveBook(string isbn)
   {
       int i=0;
       foreach(var item in book){
           if(string.Compare(item.isbn,isbn)==1){
               break;
           }
           i++;
       }
       
   }
}