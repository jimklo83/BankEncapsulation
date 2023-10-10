using System.Net;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@" $$$$$$\  $$\                            $$\   $$\                 $$\      $$\                                         ");
            Console.WriteLine(@"$$  __$$\ \__|                           $$ |  $$ |                $$$\    $$$ |                                        ");
            Console.WriteLine(@"$$ /  \__|$$\ $$\    $$\  $$$$$$\        $$ |  $$ | $$$$$$$\       $$$$\  $$$$ | $$$$$$\  $$$$$$$\   $$$$$$\  $$\   $$\ ");
            Console.WriteLine(@"$$ |$$$$\ $$ |\$$\  $$  |$$  __$$\       $$ |  $$ |$$  _____|      $$\$$\$$ $$ |$$  __$$\ $$  __$$\ $$  __$$\ $$ |  $$ |");
            Console.WriteLine(@"$$ |$$$$\ $$ |\$$\  $$  |$$  __$$\       $$ |  $$ |$$  _____|      $$\$$\$$ $$ |$$  __$$\ $$  __$$\ $$  __$$\ $$ |  $$ |");
            Console.WriteLine(@"$$ |\_$$ |$$ | \$$\$$  / $$$$$$$$ |      $$ |  $$ |\$$$$$$\        $$ \$$$  $$ |$$ /  $$ |$$ |  $$ |$$$$$$$$ |$$ |  $$ |");
            Console.WriteLine(@"$$ |  $$ |$$ |  \$$$  /  $$   ____|      $$ |  $$ | \____$$\       $$ |\$  /$$ |$$ |  $$ |$$ |  $$ |$$   ____|$$ |  $$ |");
            Console.WriteLine(@"\$$$$$$  |$$ |   \$  /   \$$$$$$$\       \$$$$$$  |$$$$$$$  |      $$ | \_/ $$ |\$$$$$$  |$$ |  $$ |\$$$$$$$\ \$$$$$$$ |");
            Console.WriteLine(@" \______/ \__|    \_/     \_______|       \______/ \_______/       \__|     \__| \______/ \__|  \__| \_______| \____$$ |");
            Console.WriteLine(@"                                                                                                              $$\   $$ |");
            Console.WriteLine(@"                                                                                                              \$$$$$$  |");
            Console.WriteLine(@"                                                                                                               \______/ ");
            Console.WriteLine();

            Console.ResetColor();

            var me = new BankAccount();

            Console.Write("Please create a user name: ");
            me.UserName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"username \'{me.UserName}\' accepted.");
            Console.WriteLine();
            
            me.MakePassword();

            me.Credentials();

            
            
        }
    }
}
