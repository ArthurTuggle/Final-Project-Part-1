using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
public class Book{
   
   public string isbn;
   string title;
   string author_info;
   DateTime published_on;
   string published_by="Unknown";
   public Book(string isbn,string title,string author_info){
           this.isbn=isbn;
           this.title=title;
           this.author_info=author_info;
           DateTime dt=DateTime.Now;
           this.published_on=dt;
   }
   public void setAuthorInfo(String fname,String lname){
       this.author_info=fname+" "+lname;
   }
   public Book(string isbn,string title,string author_info,DateTime published_on,string published_by):this(isbn,title,author_info){
       this.published_on=published_on;
       this.published_by=published_by;
   }
   public void Display(){
       string d=published_on.ToString("MM/dd/yyyy",CultureInfo.InvariantCulture);
       Console.WriteLine("Book "+title+" was written by "+author_info+" and published on "+d);
   }
}