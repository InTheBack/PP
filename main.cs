using system;

namespace Git
{
   class Git
   {
    static void Main(string[] args)
      {
      System.Console.WriteLine("Hello Git");
      System.Console.WriteLine("Enter your name: Nikita");
	  string name = Console.ReadLine();
	  System.Console.WriteLine(name.Length);
	  System.Console.WriteLine($"Hello (Nikita)!");
      }
   }
}