using System;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Please input a letter grade:");
        string grade = Console.ReadLine();
        switch(grade){
            case "A":
                Console.WriteLine ("GPA point 4");
                break;
            case "B":
                Console.WriteLine ("GPA point 3");
                break;
            case "C":
                Console.WriteLine ("GPA point 2");
                break;
            case "D":
                Console.WriteLine ("GPA point 1");
                break;
            case "F":
                Console.WriteLine ("GPA point 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade");
                break;
            }
            
            //Q2
            Console.WriteLine("Please input the first num:");
            string first = Console.ReadLine();
            Console.WriteLine("Please input the second num:");
            string sec = Console.ReadLine();
            Console.WriteLine("Please input the third num:");
            string third = Console.ReadLine();
            int firstNum = Convert.ToInt16(first);
            int secNum = Convert.ToInt16(sec);
            int thirdNum = Convert.ToInt16(third);
            if (firstNum > secNum || firstNum > thirdNum)
                {
                    if (secNum > thirdNum)
                    {
                        Console.WriteLine("The smallest value is: "+thirdNum);
                    }
                    else
                    {
                        Console.WriteLine("The smallest value is: "+secNum);
                    }
                }
            else
            {
                Console.WriteLine("The smallest value is: "+firstNum);
            }
    }
}