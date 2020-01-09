using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Program
    {
        delegate void Command(string args);
        static User _user;
        private static Dictionary<string, Command> commands = new Dictionary<string, Command>
        {
            { "login", Login }
        };
        private static string _usersDataFile;
        private static bool ShouldClose;

        public static string UsersDataFile { get => _usersDataFile; set => _usersDataFile = value; }
        public static User User { get => _user; set => _user = value; }

        static void Main(string[] args)
        {
            Initialization();

            do
            {
                Command command = ReadCommand();
                ExecuteCommand(command);
            } while (!ShouldClose);
        }

        static void Initialization()
        { }

        static Command ReadCommand()
        {
            string command = Console.ReadLine();

            return commands[command];
        }

        static void ExecuteCommand(Command command)
        {
            string args = Console.ReadLine();
            command(args);
        }

        static private void Login(string args)
        {
            string username = "";
            string password = "";
            Authentificator auth = new Authentificator(username, password);
            User = auth.Login();
        }

        static private void Close()
        {
            ShouldClose = true;
        }
    }
}
