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

        static string CountRepeatSymbols(string str)
        {
            string seached = "";
            string witholdSymbols = str;
            string newString;
            int countSymbols;
            char currentSearch;

            while (true)
            {
                
                countSymbols = 0;
                newString = "";
                currentSearch = witholdSymbols[0];
                foreach (char c in witholdSymbols)
                {
                    if (c == currentSearch)
                    {
                        countSymbols++;
                    }
                    else
                    {
                        newString += c;
                    }
                }
                if (countSymbols > 1)
                {
                    seached += currentSearch + " - " + countSymbols + ", ";
                }
                witholdSymbols = newString;
                if (newString == "")
                {
                    return seached;
                }
            }
        }
        static string GetResults(string inputMeaning)
        {
            string result;
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
                result = resultsFirst + resultSecond;
            }
            else
            {
                char[] resultElse = inputMeaning.ToCharArray();
                Array.Reverse(resultElse);
                string reversed = new string(resultElse);
                result = reversed + inputMeaning;
            }
            string doubleSymbols = CountRepeatSymbols(result);
            if (doubleSymbols != "")
            {
                Console.WriteLine("Count symbols " + doubleSymbols);
            }
            return result;
        }

    }
}
