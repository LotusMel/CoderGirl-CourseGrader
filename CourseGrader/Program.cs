using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] testScoresArray = new int[] { 70, 49, 60, 75, 92, 88, 100 };
            Console.WriteLine(GradeTestScores(testScoresArray));
            Console.ReadLine();
            
            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
        }

        public static int[] GradeTestScores(int[] testScoresArray)
        {
            string result = null;

            foreach (int score in testScoresArray)
            {

                int sum = 0;
                sum += score;
                int avg = sum / testScoresArray.Length;

                if (score < 50)
                {
                    return result = "fail";

                }
            }

            return result;
  

        }


            
       

    }
}
