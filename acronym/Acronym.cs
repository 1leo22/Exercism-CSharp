using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] splitPhrase = phrase.Split(' ', '-') ;       
        string wordAbbreviate = "";
        
        foreach (string word in splitPhrase)
        {
            if (!word.Equals(""))
            {
                wordAbbreviate += word.First(l => char.IsLetter(l));
            }//if      
        }//for
        return wordAbbreviate.ToUpper();
    }//func
}//class