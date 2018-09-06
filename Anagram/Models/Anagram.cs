using System;
namespace Anagram
{
  public class Words
  {
     public static void Main(string[] args)
    {
      Console.WriteLine("Enter First Word:");
      string wordOne = Console.ReadLine();
      Console.WriteLine("Enter Second Word:");
      string wordTwo = Console.ReadLine();

      char[] arrayOne = wordOne.ToLower().ToCharArray();
      char[] arrayTwo = wordTwo.ToLower().ToCharArray();

      Array.Sort(arrayOne);
      Array.Sort(arrayTwo);

      string newWordOne = new string(arrayOne);
      string newWordTwo = new string(arrayTwo);

      if (newWordOne == newWordTwo)
      {
        Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", wordOne, wordTwo);
      }
      else
      {
        Console.WriteLine("Not an anagram");;
      }
    }

   }
}
