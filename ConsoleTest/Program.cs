using DAL.Entities;
using DAL.Services;

namespace ConsoleTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			EmpruntService service = new EmpruntService();
			foreach (Emprunt u in service.Get())
			{
				Console.WriteLine($"{u.EmpruntId}");
			}
		}
	}
}
