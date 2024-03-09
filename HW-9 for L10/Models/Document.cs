namespace Lesson10;

public class DocumentProgram : IOperations
{

	public void OpenDocument()
	{
        Console.WriteLine("\n\tDocument Opened.");
    }
	public virtual void EditDocument()
	{
        Console.WriteLine("\n\tCan Edit in Pro and Expert Versions.");
	}
	public virtual void SaveDocument()
	{
        Console.WriteLine("\n\tCan Save in Pro and Expert Versions.");
	}

}