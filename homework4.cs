using System;
#nullable enable 
public class homework4{

  public static void Main(string[] args) { 
    Console.WriteLine("Please input 2 integers:");
    Console.Write("a = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("b = ");
    int b = Convert.ToInt32(Console.ReadLine());
    Large(a, b);

    Console.WriteLine("\nPlease enter an integer:");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlease enter an orientation for your triangle (right, left):");
    string? orientation = Console.ReadLine();
    Triangle(N, orientation);
  }
// Question 1
  public static void Large(int a, int b) {
    if (a > b) {
      Console.WriteLine("\nLargest number is " + a);
    } else if (b > a) {
      Console.WriteLine("\nLargest number is " + b);
    }
  }
// Question 2
  public static void Triangle(int N, string? orientation) {
    if (orientation == "left") {
      int Nduck = N;
      for (int h = 0; h < Nduck; h++) {
        for (int g = 0; g < Nduck; g++) {
          Console.Write("*");
          if (g == h) {
            Console.Write("\n");
            break;
          } else {
            continue;
          }
        }
      }
    } else if (orientation == "right") {
      int Nduck_b = N;
      int space = 0;
      int count = 0;
      for (int t = 0; t < Nduck_b; t++) {
        count++;
        while (space <= Nduck_b) {
          Console.Write(" ");
          space++;
          if (space == Nduck_b) {
            space = count;
            break;
          }
        }
        for (int s = 0; s < Nduck_b; s++) {
          Console.Write("*");
          if (s == t) {
            Console.Write("\n");
            break;
          } else {
            continue;
          }
        }
      }
    }
  }

}