using System;
namespace Namespace_Dll_Classwork.Helpers.Extensions
{
	public static class Math_extensions
	{
		public static int SumOfNums(this int num,int num2)
		{
			return num + num2;
		}

		public static double PowerOfNums(this int a,int pow)
		{
			return Math.Pow(a, pow);
		}
	}
}

