// See https://aka.ms/new-console-template for more information
namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the wishes!!", true, "Donald Carter");
            Console.WriteLine(post1.ToString());
            Console.ReadLine(); 
        
        }
    }
}
