using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment testAssign = new Assignment("Johnny", "Science");
        Console.WriteLine(testAssign.GetSummary());
        MathAssignment testMath = new MathAssignment("Jill", "Math", "Section 17", "23-45");
        Console.WriteLine(testMath.GetHomeworkList());
        WritingAssignment testWrite = new WritingAssignment("Amy", "English", "History of WW1");
        Console.WriteLine(testWrite.GetWritingInformation());
    }
}