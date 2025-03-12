using DAL.Entities;
using DAL.Services;

namespace ConsoleTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			UtilisateurService service = new UtilisateurService();
			foreach (Utilisateur u in service.Get())
			{
				Console.WriteLine($"{u.UtilisateurId} : {u.Email} - {u.MotDePasse} - {u.DateCreation}");
			}
		}
	}
}
