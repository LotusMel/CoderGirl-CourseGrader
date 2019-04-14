using System;
namespace CourseGrader
{
    public static class Program
    {
        

        public static void Main(string[] args)
        {
            int[] testScoresArray = new int[] { 100, 77, 92, 51, 99 };

                GradeTestScores(testScoresArray);


            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
        }

        public static string GradeTestScores(int[] testScoresArray)
        {
            string result;
            

            foreach (int testScore in testScoresArray)
            {

                int sum = 0;
                sum += testScore;
                int avg = sum / testScoresArray.Length;


                if (avg >= 70 && testScore >= 50)
                {
                    result = "pass";
                    Console.WriteLine(result);
                    
                }
                
                else if (avg < 70 && testScore < 50)
                {
                    result = "fail";
                    Console.WriteLine(result);
                    
                }

            }
            
            return Console.ReadLine();
        }

    }  

}
