namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        //Q1 
        Console.WriteLine("Please input 2 integers:");
        Console.Write("A = ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
        int B = Convert.ToInt32(Console.ReadLine());
        Largest(A,B);

        //Q2
        Console.WriteLine("\n\nPlease input 4 integers: ");
        Console.Write("A = ");
        int AA = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
        int BB = Convert.ToInt32(Console.ReadLine());
        Console.Write("C = ");
        int C = Convert.ToInt32(Console.ReadLine());
        Console.Write("D = ");
        int D = Convert.ToInt32(Console.ReadLine());
        object value = Largest(AA,BB,C,D);
        static void Largest( int A= 0, int B = 0, int C= 0, int D = 0){
            if(A > B && A > C && A > D){
                Console.Write("\nThe largest integer is: "+ A);
            }
            else if (B > A && B > C && B > D){
                Console.Write("\nThe largest integer is: "+ B);
            }
            else if (C > A && C > B && C > D){
                Console.Write("\nThe largest integer is: "+ C);
            }
            else if (D > A && D > C && D> B){
                Console.Write("\nThe largest integer is: "+ D);
            }
        }
        //Q3
        static void createAccount(){
            Console.WriteLine("\n/nEnter Username:");
            string user = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter Birth Year:");
            int birth_year = Convert.ToInt32(Console.ReadLine());
            bool v = checkAge(birth_year);
            if (checkAge(birth_year) == true){
                if (pass == pass2){
                    Console.WriteLine("Account is created successfully.");
                }
                else if (pass != pass2){
                    Console.WriteLine("Wrong password.");
                }
                else if (checkAge(birth_year) == false){
                    Console.WriteLine("Could not create an accounnt."); 
                    }
                }
                 static bool checkAge(int birth_year){
                    int age = 2022-birth_year;
                    if (age >= 18){
                        return true;
                    }
                    else{
                        return false; 
                    }
                    //My Visual studio isn't allowing me to run code but when I check it on replit it works fine 
                }
              }
            }
        }

        


