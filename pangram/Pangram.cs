using System;
using System.Linq;

public static class Pangram
{
    const string ALFABETO = "abcdefghijklmnopqrstuvwxyz";

    private static string RemoveValorDuplicado(string input)
    {
       return new string(input.Distinct().ToArray());
    }//func
    private static string RemoveEspacoEmBranco(string input)
    {
        return input.Replace(" ", ""); 
    }//func
    private static string OrdenaString(string input)
    {
        return new string(input.OrderBy(l => l).ToArray());
    }//func

    public static bool IsPangram(string input)
    {
		input = input.ToLower();
        input = RemoveEspacoEmBranco(input);
        input = OrdenaString(input);
        input = RemoveValorDuplicado(input);
        
		return input.Contains(ALFABETO);
    }//func
}//class
