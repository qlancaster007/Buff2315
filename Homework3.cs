using System;
class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Input an integer");
        int number = Convert.ToInt16(Console.ReadLine());
        for(int i=2; i < number; ++i){
            if(number % i == 0){
                Console.WriteLine("This is not a prime.");
                break;
            }
            else{
                Console.WriteLine("This is Prime.");
            }
        }
        
        // Q2

        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());
        for(int line = 0; line<n; ++line){

            for(int column = 0; column<n; ++column){

                Console.Write("#");
            }  
            Console.WriteLine("\n");
        }
        /*Q3 I couldn't get any further. I had tutoring from Chris again
        Console.WriteLine("Assign an int value to N:");
        int cas = Convert.ToInt16(Console.ReadLine());
        for(int line =0;  line<cas; ++line){
            for(int col =0; line<col; --col)
            {
                if(col == cas){
                    Console.Write("*");
                }
            }
        }*/
    }
}
