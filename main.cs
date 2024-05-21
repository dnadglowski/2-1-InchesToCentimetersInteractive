using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Number in Inches:");
   var inches = Convert.ToInt16(Console.ReadLine());

    var INCHES_TOCM = inches * 2.54;

    Console.WriteLine("{0} cm ", INCHES_TOCM);


  }
}