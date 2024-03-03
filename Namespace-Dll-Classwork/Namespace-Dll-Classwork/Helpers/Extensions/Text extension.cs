using System;
namespace Namespace_Dll_Classwork.Helpers.Extensions
{
	public static class Text_extension
	{
		public static int GetLength(this string str)
		{
			return str.Length;
		}

		public static bool CheckCharInText(this string txt,char letter)
		{
			return txt.Contains(letter);
		}

		public static int CountOfCharInText(this string text,char letter)
		{
			return text.ToArray().Where(m => m == letter).Count();
		}
	}
}

