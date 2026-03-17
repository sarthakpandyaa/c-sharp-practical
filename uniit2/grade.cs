using System;

class Student
{
    int rollNo;
    string name;
    int marks;

    public Student()
    {
        rollNo = 0;
        name = "Sarthak";
        marks = 0;
    }

    
    public Student(int r, string n, int m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    public string grade()
    {
        if (marks >= 90)
            return "A";
        else if (marks >= 80)
            return "B+";
        else if (marks >= 70)
            return "B";
        else if (marks >= 60)
            return "C+";
        else if (marks >= 50)
            return "C";
        else
            return "F";
    }

   
    public void display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
    }

    public static void Main()
    {
        Student s1 = new Student(1, "Sarthak", 85);
        s1.display();
        Console.WriteLine("Grade: " + s1.grade());
    }
}