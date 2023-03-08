using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class App
    {
        public static string Inverting(string word)
        {
            string result = string.Empty;

            List<string> characterWord = new List<string>();

            for(int i = 1; i <= word.Length; i++)
            {
                characterWord.Add(word.Substring(i - 1, 1));

                if(i == word.Length)
                {
                    int y = i;

                    for (int j = 0; j < word.Length; j++)
                    {
                        result += characterWord[y - 1];
                        y--;
                    }
                }
            }

            return result;
        }
    }
}
