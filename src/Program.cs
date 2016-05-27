using System;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }
        
        public async static Task MainAsync(string[] args)
        {
            await Console.Out.WriteLineAsync("Hello World!");
        }
    }
}
