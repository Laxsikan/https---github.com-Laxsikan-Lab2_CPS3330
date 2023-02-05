//task4
using System;
using System.IO;
public class Lab2
{
  public static void Main()
  {
     double number1,number2,number3;
      
     Console.Write("Enter the First number: ");
     number1 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Enter the Second number: ");
     number2 = Convert.ToDouble(Console.ReadLine());
 
     double result = (number1 + number2 ) / 2;
     Console.WriteLine("The average of {0}, {1}, is: {2}",
  number1, number2, result);
  
  
  Console.Write("Enter an Additional Number: ");
     number3 = Convert.ToDouble(Console.ReadLine());
     
  double result2 = (number1 + number2 + number3 ) / 3;
     Console.WriteLine("The average of {0}, {1}, {2} is: {3}",
    number1, number2, number3, result2);



//Task 5

var arr = new double[] { number1, number2};
      double avg = Queryable.Average(arr.AsQueryable());
      Console.WriteLine("Average = "+avg);

var arr2 = new double[] { number1, number2, number3};
      double avg2 = Queryable.Average(arr.AsQueryable());
      Console.WriteLine("Average = "+avg);

//Task 6

using System;
using System.Linq;
class lab2 {
   static void Main()
   {
       double number1,number2,number3;
      
     Console.Write("Enter the First number: ");
     number1 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Enter the Second number: ");
     number2 = Convert.ToDouble(Console.ReadLine());
     
      var arr = new double[] { number1, number2};
      double avg = Queryable.Average(arr.AsQueryable());
      Console.WriteLine("Average = "+avg);
      
      Console.Write("Enter an Additional Number: ");
     number3 = Convert.ToDouble(Console.ReadLine());
     
      var arr2 = new double[] { number1, number2, number3};
      double avg2 = Queryable.Average(arr.AsQueryable());
      Console.WriteLine("Average = "+avg);
   }
}


















