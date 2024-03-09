namespace Lesson10;

public class DocumentProgram : IOperations
{

	public void OpenDocument()
	{
        Console.WriteLine("\n\t\t\tDocument Opened.");
    }
	public virtual void EditDocument()
	{
        Console.WriteLine("\n\t\t\tCan Edit in Pro and Expert Versions.");
	}
	public virtual void SaveDocument()
	{
        Console.WriteLine("\n\t\t\tCan Save in Pro and Expert Versions.");
	}

}