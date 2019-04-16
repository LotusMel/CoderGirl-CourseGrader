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
        }   

        public static string GradeTestScores(int[] testScoresArray)
        {
            string result = null;
            int sum = 0;
            int minScore = 0;

            while (testScoresArray.Length != 0)
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
                    return result;
                }
                
                if (avg < 70 || minScore < 50)
                {
                    result = "fail";
                    return result;
                }

                else if (testScoresArray.Length == 0)
                {
                    break;   
                }
                    continue;    
            }

            if (testScoresArray.Length == 0)
            {
                result = "fail";
            }
                return result;
        }

    }  

}
