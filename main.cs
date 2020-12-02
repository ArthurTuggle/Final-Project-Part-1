using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;


public class Program{
   public static void Main(string[] args){
       Book b1=new Book("1","Title 1",null);
       Book b2=new Book("2","Title 2",null);
       Book b3=new Book("3","Title 3",null);
       DateTime d1,d2,d3;
       d1=new DateTime(2010,11,18);
       Book b4=new Book("4","Title 4",null,d1,"person1");
       d2=new DateTime(2010,11,19);
       Book b5=new Book("5","Title 5",null,d2,"person2");
       d3=new DateTime(2010,11,20);
       Book b6=new Book("6","Title 6",null,d3,"person3");
       Author a1=new Author("fname1","lname1","id 1");
       Author a2=new Author("fname2","lname2","id 2");
       a1.DisplayInfo();
       a2.DisplayInfo();
       a1.AddBook(b1);
       a1.AddBook(b3);
       a1.AddBook(b5);
       a1.DisplayBooks();
       a2.AddBook(b2);
       a2.AddBook(b6);
       a2.AddBook(b6);
       a2.DisplayBooks();
       a1.RemoveBook(b1.isbn);
       Console.WriteLine("After removing book....");
       a1.DisplayBooks();
   }
}