using System;


class Program {
    static void Main(string[] args) {
        ///////////////////////////////////////////////////////////////////////////////
        /// PUT YOUR CODE HERE
        
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine('\n');
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine('\n');
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetWritingInformation());

        ////////////////////////////////////////////////////////////////////////////////
    }
}