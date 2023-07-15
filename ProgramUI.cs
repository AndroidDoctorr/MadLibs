public class ProgramUI {
    public void DoMadLib(MadLib madLib) {
        Console.Clear();
        Console.WriteLine(madLib.Title);

        List<string> words = new List<string>();

        foreach (WordType wordType in madLib.Words) {
            // Get a string for the word type
            string wordTypeString = MadLibData.WordTypeStrings[wordType];
            Console.Write($"Give me {wordTypeString}: ");
            string word = Console.ReadLine();

            words.Add(word);
        }

        Console.Clear();
        Console.WriteLine("\n\nProcessing...");
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine(string.Format(madLib.Text, words.ToArray()));

        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}