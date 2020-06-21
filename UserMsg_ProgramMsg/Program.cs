using System;

namespace UserMsg_ProgramMsg
{
    class Program
    {
        static void Main(string[] args)
        {
            Forbidden forbidden = new Forbidden();
            User user = new User() { Username = "rochoMonsta" };
            GameSystem gameSystem = new GameSystem();

            Message message = new Message()
            {
                Text = "Fuck you noob sucker",
                SendBy = user
            };
            Message message1 = new Message()
            {
                Text = "Sucker album is playing right now.",
                SendBy = gameSystem
            };
            Console.WriteLine($"({message.SendBy.GetDateTime()}): {forbidden.CheckForForbiddenWord(message)}");
            Console.WriteLine($"({message.SendBy.GetDateTime()}): {forbidden.CheckForForbiddenWord(message1)}");
            Console.ReadLine();
        }
    }
}
