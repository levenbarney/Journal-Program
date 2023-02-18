using System.IO;


Journal journal = new Journal();
bool run = true;

while(run == true){
    Console.WriteLine("1.Write 2.Display 3.Load 4.Save 5.Quit");
    string choice = Console.ReadLine();
    if(choice=="1"){
        journal.writeEntry();
    }
    else if(choice=="2"){
        journal.displayEntries();
    }
    else if(choice=="3"){
        Console.WriteLine("Please enter the name of the file to be read with the .txt extension: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename)) {
            Console.WriteLine("FILE " + filename + " LOADED SUCCESSFULLY.");
            string[] entryFile = File.ReadAllLines(filename);
            List<string> temp = new List<string>();
            foreach (string s in entryFile){
                temp.Add(s);
            }
            journal.entries = temp;
        }
        else {
            Console.WriteLine("FILE " + filename + " DOES NOT EXIST.");
        }
    }
    else if(choice=="4"){
        Console.WriteLine("Please enter the name of the file to be saved with a .txt extension: ");
        string filename = Console.ReadLine();
        // filename += ".txt";
        string allEntries = "";
        foreach (string entry in journal.entries) {
            allEntries += (filename, entry + "\n");
        }
        File.WriteAllText(filename, allEntries);
        Console.WriteLine("FILE " + filename + " SAVED.");
    }
    else if(choice=="5"){
        run = false;
    }
    else{
        Console.WriteLine("Try Again.");
    }
}