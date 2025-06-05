using System;

public class PrintIntStringAlternative
{
    public static void Main(string[] args)
    {
        int[] num = {1,2,3,4};
        string[] letter = {"one","two","three"};
        
        int length = Math.Min(num.Length,letter.Length);
        Console.WriteLine(length);
        for(int i=0;i<length;i++){
            Console.Write(num[i] + "," + letter[i] + ",");
        }
    }
}
