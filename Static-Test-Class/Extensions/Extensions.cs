using System;
namespace Static_Test_Class.Extensions
{
	public static class Extensions
	{
	    public static bool CheckEmail(this string email)
		{
			var result = email.ToArray().FirstOrDefault(m => m == '@');
			if (result.ToString() == email)
			{
				return true;
			}
			return false;
		}

		public static bool CheckLengthOfPass(this string password)
		{
			var result = password.Length;

			if (result > 8)
			{
				return true;
			}
			return false;
		}


		public static int MultipleOfElements(this int[] nums)
		{
			int result = 1;
			foreach (var item in nums)
			{
				result *= item;
			}
			return result;
		}

	}
}

