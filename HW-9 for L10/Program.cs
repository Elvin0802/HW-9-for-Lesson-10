namespace Lesson10;

public class Program
{
	static void Main(string[] args)
	{
		string? key = "";

        Console.WriteLine("\n\t\t\tKEYS\n\t1. Basic\n\t2. Pro\n\t3. Expert");
        Console.Write("\n\tSelect Key : ");
		key = Console.ReadLine();

		//if()

		ExpertDocumentProgram p = new();

		p.OpenDocument();
		p.EditDocument();
		p.SaveDocument();

    }
}
