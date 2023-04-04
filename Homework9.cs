using System.Linq;
using System.Collections.Generic;
namespace Homework9;

class Student 
{
    
    public int studentID {get;set;}
    public string studentName {get;set;}
    public static List<Student> studentList = new List<Student>();
   
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }
    public void PrintInfo()
    {
        Console.WriteLine("Student ID:" + studentID + "Name:" + studentName);
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Student alice = new Student (111, "Alice");
        Student bob = new Student (222, "Bob");
        Student cathy = new Student (333, "Cathy");
        Student david = new Student (444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }
    
        double totalGPA = 0;
        foreach(double gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }

        double avgGPA = totalGPA/gradebook.Count;
        Console.WriteLine("The average GPA is: "+avgGPA);

       
        foreach(var stuObj in Student.studentList){
            if(gradebook[stuObj.studentName]>avgGPA){
                stuObj.PrintInfo();
            }
        }
    }
}
        
    

