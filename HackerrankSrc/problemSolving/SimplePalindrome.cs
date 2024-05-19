using System;

namespace Pal
{


	public class Palindrome
	{

		public static bool IsPalindrome(string s)
		{

			for (int i = 0, j = s.Length - 1; i < j; i++, j--)
			{
				if (s[i] != s[j])
				{
					return false;
				}
			}
			return true;
		}

		public static void Main(string[] args)
		{
			string s = "aabbaa";

			var result = IsPalindrome(s);
			if (result)
			{
				Console.WriteLine($"{s} is a plaindrome");
			}
			else
			{
				Console.WriteLine($"{s} is NOT a plaindrome");
			}

			Console.ReadLine();
		}
	}
}