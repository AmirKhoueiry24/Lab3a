using System;

class Program {
  public static void Main (string[] args) {
    //if temperture is below 32 degrees fahrenheit,display a message "It is freezing"

    //if temperture is below 0 degrees celsius,display a message "It is freezing

    //if temperture us above 212 fahrenheit, display a message "this is a boiling point"
    //if temperture us above 100 celsius, display a message "this is a boiling point"
  Console.WriteLine("Enter temperture");

     double Far =(Convert.ReadLine());
    double Far = (Cel * 9/5) + 32;
    

    //Find the temperture
    

    string Cel = "Celsius"; 


    double Cel = 5/9 * (Far - 32);

    Console.WriteLine("The temperture is " + Far);

     if (Far >= 212 == 100)
    

    { 
        Console.WriteLine("This is above boiling temperture of 212 degrees fahrenheit");
    }
     if (Far <= 32 == 0)

     {
        Console.WriteLine("This is below freezing tempertures of 32 degrees fahenheit");
     }
   }

    
  
