public class Journal{
    Random random = new Random();
    Prompts entryPrompts = new Prompts();
    public List<string> entries = new List<string>(); // holds each journal entry

    public void writeEntry(){
        string RandomPrompt = entryPrompts.prompts[random.Next(0,7)];
        Console.WriteLine(RandomPrompt);
        string userinput = Console.ReadLine();
        DateTime today = DateTime.Now;
        // Console.WriteLine(today);
        Entry newEntry = new Entry();
        entries.Add("Time: " + today + " Prompt: " + RandomPrompt + " Response: " + userinput);
    }

    public void displayEntries(){
        if (entries.Count == 0){
            Console.WriteLine("Error - No entries to display.");
        }
        else {
            foreach (string entry in entries) {
                Console.WriteLine(entry);
            }
        }
    }
}