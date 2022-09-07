using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonUniqueWords
{
    public class NonUniqueWord
    {
        public static string NonUniqueWordCount(string str)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string strRes = "";

            if (!string.IsNullOrWhiteSpace(str))
            {
                var strSplit = str.Split(' ');

                foreach (var word in strSplit)
                {
                    if (!dic.ContainsKey(word))
                        dic.Add(word, 1);
                    else
                        dic[word] += 1;
                }

                foreach (var word in dic)
                {
                    if (word.Value > 1)
                        strRes += $"{word.Key}: {word.Value}\n";
                }
            }
            return strRes;
        }
    }
}
