using System;
namespace Namespace_Dll_Classwork.Models
{
	public static class Doctor
	{
		public static string Name { get; set; }
		public static int Id { get; set; }

		static Doctor()
		{
			Console.WriteLine("Salam");
		}

	}
}

