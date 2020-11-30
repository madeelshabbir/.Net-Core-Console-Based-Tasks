using System;

namespace Assignment1
{
    class Program
    {
        static decimal caculateGrade(decimal marks)
        {
            if (marks > 84) return 4;
            else if (marks <= 84 && marks > 79) return 3.7M;
            else if (marks <= 79 && marks > 74) return 3.3M;
            else if (marks <= 74 && marks > 69) return 3;
            else if (marks <= 69 && marks > 64) return 2.7M;
            else if (marks <= 64 && marks > 59) return 2.3M;
            else if (marks <= 59 && marks > 57) return 2.0M;
            else if (marks <= 57 && marks > 54) return 1.7M;
            else if (marks <= 54 && marks > 49) return 1;
            else return 0;
        }
        static decimal calculateGPA(params decimal[] subjectMarks)
        {
            decimal sum = 0;
            for (int i = 0; i < subjectMarks.Length; i++) 
                sum += caculateGrade(subjectMarks[i]);
            return sum / subjectMarks.Length;
        }
        static void Main(string[] args)
        {
            decimal EAD = 85;
            decimal MC = 73;
            decimal CV = 62;
            decimal CA = 78;
            Console.WriteLine($"Your GPA: {calculateGPA(EAD, MC, CV, CA)}");
        }
    }
}