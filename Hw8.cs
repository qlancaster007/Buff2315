using System;
using System.Linq;

public class Program {

  public static void Main(string[] args) {
    
    int[] int_array = {11,23,31,42,53};

    int[, ] array_2d = {
      {1,2,3},
      {4,5,6},
      {7,8,9}
    };
    ArraySum(int_array);
    PrintAllOddNumber(array_2d);
    ElementSum(array_2d);
    DoubleArray(array_2d);
  }
  
  public static void ArraySum(int[] int_array) {
    Console.WriteLine("The Sum of int_array is: " + int_array.Sum());
  }
  
  public static void PrintAllOddNumber(int[, ] array_2d) {
    Console.Write("Q1: Print all odd numbers: ");
    foreach(int odd in array_2d) {
      if (odd % 2 != 0) {
        Console.Write(odd + " ");
      } else {
        continue;
      }
    }
    Console.WriteLine(" ");
  }
  
  public static int ElementSum(int[, ] array_2d) {
    int sum = array_2d.Cast < int > ().Sum();
    Console.WriteLine("Q2: The sum of array elements: " + sum);
    return sum;
  }
  
  public static int DoubleArray(int[, ] array_2d) {
    Console.Write("Q3: The new 2d array:");
    int mult = 0;
    for (int i = 0; i < 3; i++) {
      for (int j = 0; j < 3; j++) {
        mult = array_2d[i, j] * 2;
        Console.Write(" " + mult);
      }
    }
    return mult;
  }
}


