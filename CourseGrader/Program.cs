using System;
namespace CourseGrader
{
    public static class Program
    {
        

        public static void Main(string[] args)
        {
            int[] testScoresArray = new int[] { 0, 0, 0 };

            Console.WriteLine(GradeTestScores(testScoresArray));
            Console.ReadLine();


            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
        }

        public static string GradeTestScores(int[] testScoresArray)
        {
            string result = null;
            int sum = 0;
            int minScore = 0;

            while (testScoresArray.Length != 0 && sum != 0)
            {
                foreach (int testScore in testScoresArray)
                {
                    sum += testScore;
                    minScore = testScoresArray[0];
                }

                int avg = sum / testScoresArray.Length;
            
                if (avg >= 70 && minScore >= 50)
                {
                    result = "pass";
                }

                if (avg < 70 || minScore < 50)
                {
                    result = "fail";
                }

                
                else if (testScoresArray.Length == 0 || sum == 0)
                {
                    break;
                }
                continue;
            }
            
            if (testScoresArray.Length == 0 || sum == 0)
            {
                result = "fail";
            }
             return result;
        }

    }  

}
