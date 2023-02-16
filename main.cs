using system;

namespace Git
{
   class Git
   {
    static void Main(string[] args)
      {
      System.Console.WriteLine("Enter your first name: ");
	  string first_name = Console.ReadLine();
	  System.Console.WriteLine("Now enter your last name: ");
	  srting last_name = Console.ReadLine();
	  System.Console.WriteLine($"Hello {First_name} {Last_name}!");
      }
   }
}