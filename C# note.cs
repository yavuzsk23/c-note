namespace c# note
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string filePath = "notes.txt";
        Console.Write("write something ");
        string inputText = Console.ReadLine();
        File.WriteAllText(filePath, inputText);
        Console.WriteLine("text saved to file.");
        string readText = File.ReadAllText(filePath);
        Console.WriteLine("Read from file " + readText);

        }  


            
    }
}
