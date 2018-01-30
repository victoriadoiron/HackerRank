using System;

namespace Solutions.Implementations
{
    // <see href="https://www.hackerrank.com/challenges/grading/problem" />
    class GradingStudents
    {
        static int[] Solve(int[] grades)
        {
            var results = new int[grades.Length];

            for (var i = 0; i < results.Length; i++)
            {
                int grade = grades[i];
                if (grade < 38)
                {
                    results[i] = grade;
                }
                else
                {
                    var mod = grade % 5;
                    results[i] = mod >= 3 ? grade + 5 - mod : grade;
                }
            }

            return results;
        }

        void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = Solve(grades);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
