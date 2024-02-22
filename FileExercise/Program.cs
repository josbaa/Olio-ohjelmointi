// See https://aka.ms/new-console-template for more information
using FileExercise;
using Newtonsoft.Json;
using System.Text;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Files Exercise!");

        FileManager fm = new FileManager (@"C:\Users\johan\source\repos\testitxt\TESTI.TXT");


        try
        {
            string fileContent = fm.ReadWords();
            Console.WriteLine(fileContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Tiedoston luku epäonnistui" + ex.Message);
        }


        List<Book> books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(@"C:\Users\johan\source\repos\Olio ohjelmointi\FileExercise\myBook.json", Encoding.UTF8));


        foreach (Book b in books)
        {
            Console.WriteLine(b);
        }



    }
        
}


