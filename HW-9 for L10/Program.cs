namespace Lesson10;

public class Program
{
	static void Main(string[] args)
	{
		string? key = "";

		while (true)
		{
			Console.Clear();

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\n\n\n\t\t\t--- KEYS ---");

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n\t\t\t1. Basic\n\t\t\t2. Pro\n\t\t\t3. Expert\n\t\t\t0. Exit");

			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.Write("\n\n\tSelect Key : ");
			Console.ForegroundColor = ConsoleColor.White;

			key = Console.ReadLine();

			if (key == "0") break;

			DocumentProgram? Program = null;

			if (key == "1")
				Program = new DocumentProgram();
			else if (key == "2")
				Program = new ProDocumentProgram();
			else if (key == "3")
				Program = new ExpertDocumentProgram();
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\n\n\t\t\tPlease Enter Correct Key !!!\n\n");
				Thread.Sleep(1800);
				continue;
			}

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			Program.OpenDocument();
			Program.EditDocument();
			Program.SaveDocument();

			Thread.Sleep(2200);

		}
	}
}
