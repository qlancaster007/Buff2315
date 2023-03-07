using System;
namespace hw6;

public class Program {

    public static void Main(string[] args) {
        Professor newprof1 = new Professor();
        newprof1.prof_name = "Alice";
        newprof1.class_teach = "Java";
        newprof1.SetSalary(9000);

        Professor newprof2 = new Professor();
        newprof2.prof_name = "Bob";
        newprof2.class_teach = "Math";
        newprof2.SetSalary(8000);

        Student newstu1 = new Student();
        newstu1.stu_name = "Lisa";
        newstu1.class_enroll = "Java";
        newstu1.SetGrade(90);

        Student newstu2 = new Student();
        newstu2.stu_name = "Tom";
        newstu2.class_enroll = "Math";
        newstu2.SetGrade(80);

        Console.WriteLine($"Professor Alice teaches Java, and the salary is: {newprof1.sal}");
        Console.WriteLine($"professor Bob teaches math, and the slary is: {newprof2.sal}");
        Console.WriteLine($"Student Lisa enrolled in java, and the grade is: {newstu1.grade}");
        Console.WriteLine($"Student Tom enrolled in math, and the grade is: {newstu2.grade}");

        double diff = newprof1.sal - newprof2.sal;
        Console.WriteLine($"The salary difference between Alice and Bob is: {diff}");

        double gradeT= newstu1.grade + newstu2.grade;
        Console.WriteLine($"The total grade of Lisa and Tom is: {gradeT}");
    
    }

    }

