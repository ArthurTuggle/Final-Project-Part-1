using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;


public class Program{
   public static void Main(string[] args){
       Book b1=new Book("1","Harry Potter",null);
       Book b2=new Book("2","The Great Gatsby",null);
       Book b3=new Book("3","Invisible Man ",null);
       DateTime d1,d2,d3;
       d1=new DateTime(2010,1,18);
       Book b4=new Book("4","Don Quixote",null,d1,"person2");
       d2=new DateTime(2010,11,19);
       Book b5=new Book("5","Beloved",null,d2,"person6");
       d3=new DateTime(2010,11,20);
       Book b6=new Book("6","To Kill a Mockingbird",null,d3,"person4");
       Author a1=new Author("J","Rowling","id 1");
       Author a2=new Author("F","Fitzgerald","id 2");
       Author a3=new Author("Ralph","Ellison",null);
       a1.DisplayInfo();
       a2.DisplayInfo();
       a1.AddBook(b1);
       a1.AddBook(b3);
       a1.AddBook(b5);
       a1.DisplayBooks();
       a2.AddBook(b2);
       a2.AddBook(b6);
       a2.DisplayBooks();
       a1.RemoveBook(b1.isbn);
       Console.WriteLine("After removing the book....");
       a1.DisplayBooks();
   }
}