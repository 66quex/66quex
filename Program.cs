using System;

namespace GetResult
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input: ");
                string inputMeaning = Console.ReadLine();
                string ouputMeaning = GetResults(inputMeaning);
                Console.WriteLine("Output: " + ouputMeaning);
            }
        }

        static string GetResults(string inputMeaning)
        {
            string correctSymbols = "abcdefghijklmnopqrstuvwxyz";
            string notCorrectSymbols = "";
            for(int i = 0; i < inputMeaning.Length; i++)
            {
                if (correctSymbols.IndexOf(inputMeaning[i]) == -1)
                {
                    notCorrectSymbols += inputMeaning[i];
                    
                }      
                
            }
            if (notCorrectSymbols.Length > 0)
            {
                return "Не верные символы: " + notCorrectSymbols;
            }
            if (inputMeaning.Length % 2 == 0)
            {
                int halfMeating = inputMeaning.Length / 2;
                string firstMeating = inputMeaning.Substring(0, halfMeating);
                string secondMeating = inputMeaning.Substring(halfMeating);
                char[] resultsFirstMeating = firstMeating.ToCharArray();
                Array.Reverse(resultsFirstMeating);
                string resultsFirst = new string(resultsFirstMeating);
                char[] resultsSecondMeating = secondMeating.ToCharArray();
                Array.Reverse(resultsSecondMeating);
                string resultSecond = new string(resultsSecondMeating);
                string getresult = resultsFirst + resultSecond;
                return getresult;
            }
            else
            {
                char[] resultElse = inputMeaning.ToCharArray();
                Array.Reverse(resultElse);
                string reversed = new string(resultElse);
                string resultReverse = reversed + inputMeaning;
                return resultReverse;
            }
        }
    }
}