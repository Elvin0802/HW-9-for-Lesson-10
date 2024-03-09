namespace Lesson10;

public class ProDocumentProgram : DocumentProgram
{

	public override sealed void EditDocument()
	{
        Console.WriteLine("\n\tDocument Edited.");
    }

	public override void SaveDocument()
	{
        Console.WriteLine("\n\tDocument Saved in doc format, for pdf format Buy Expert packet.");
    }

}

