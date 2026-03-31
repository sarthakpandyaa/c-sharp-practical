using System;


interface Exam
{
    bool Pass(int mark);
}


interface Classify
{
    string Division(int average);
}


class Result : Exam, Classify
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "No division";
    }
}


class Program
{
    static void Main()
    {
        Result r = new Result();

        Console.WriteLine(r.Pass(45));     // false
        Console.WriteLine(r.Division(65)); // First
    }
}