using System;


interface PassCheck
{
    bool Pass(int mark);
}

interface DivisionCheck
{
    string Division(int average);
}


class Result : PassCheck, DivisionCheck
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}


class Program
{
    static void Main()
    {
        Result r = new Result();

        int mark = 55;
        int average = 58;

        Console.WriteLine("Pass Status: " + r.Pass(mark));
        Console.WriteLine("Division: " + r.Division(average));
    }
}