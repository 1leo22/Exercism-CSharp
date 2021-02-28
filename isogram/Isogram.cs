using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if(word.Length > 0)
        {
            word = word.Trim();
            word = word.Replace(" ", "");
            word = word.Replace("-", "");
            word = word.ToLower();

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                            count++;
                    }//if
                }//for
            }//for
            return count == 0;
        }//if
        
        return true;
    }//func
}//class
