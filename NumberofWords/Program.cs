using System;

public class CountWords
{
    public static void Main()
    {
        String a = "CodeAcademy is a good place to study";
        int wordCount = 0;

        for (int i = 0; i < a.Length - 1; i++)
        {
            
            if (a[i] == ' ' && Char.IsLetter(a[i + 1]) && (i > 0))
            {
                wordCount++;
            }
        }
         
        wordCount++;

        
        Console.WriteLine("Total number of words in the string is: " + wordCount);
    }  
}