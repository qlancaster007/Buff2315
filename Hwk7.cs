using System;

public class Program {

    public static void Main(string[] args) {
        Customer c1 = new Customer (110, "Alice", 28);

        Customer c2 = new Customer (111, "Bob", 30);

        c1.PrintCustInfo();
        c2.PrintCustInfo();

        c1.ChangeID(220);
        c2.ChangeID(221);

        c1.PrintCustInfo();
        c2.PrintCustInfo();



        if(c1.cust_age > c2.cust_age){
            Console.WriteLine("Alice is older");
        }
        else{
            Console.WriteLine("Bob is older");
        }
    }
}