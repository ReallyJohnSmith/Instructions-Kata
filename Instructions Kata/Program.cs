// See https://aka.ms/new-console-template for more information
public class MyProgram
{
    public static int Main( string[] someThing)
    {
        Console.WriteLine("I will store your recipe");

        var InstructionsList = new System.Collections.Generic.List<string>();

        while (true)
        {
            Console.WriteLine("Please enter your instructions or press enter when finished");
        string Instructions = Console.ReadLine();
            if (!String.IsNullOrEmpty(Instructions))
                InstructionsList.Add(Instructions);
            else
                break;

        }

        for (int currInstructionsListNo = 0; currInstructionsListNo < InstructionsList.Count; currInstructionsListNo++)
            Console.WriteLine($"{currInstructionsListNo + 1}. {InstructionsList[currInstructionsListNo]}");
        return 0;
    }
}

