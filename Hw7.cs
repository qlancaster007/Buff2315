using System;
class Customer{
    private int cust_id;
    public string cust_name;
    public int cust_age;

    public Customer(int id, string name, int age){
        cust_id = id;
        cust_name = name; 
        cust_age = age; 
    }

    public void ChangeID(int new_id){
        cust_id = new_id;
    }

    public void PrintCustInfo(){
        Console.WriteLine("Customer: "+cust_id+", name: "+cust_name+", age: "+cust_age);

    
        
    }
   
}