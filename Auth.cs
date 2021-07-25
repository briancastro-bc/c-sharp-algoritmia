using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    class Auth : IUser
    {
        public Auth(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public Auth(string username, string password)
        {
            this.username = username;
            this.password = password;
            name = "User";
        }

        public void Signup()
        {
            //TODO: Continue...
            string response;
            while(true)
            {
                Console.WriteLine("Do you wanna sign up? (si / no) ");
                try
                {
                    response = Console.ReadLine();
                    if (responses.Contains(response.ToLower()))
                    {
                        Console.WriteLine("Sign up user...\n");
                        Users.Add(username);
                        Console.WriteLine("User was signed\n");
                        Private();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The program was closed. Wrong response.");
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong response, please put a valid response. {0}", e.Message);
                }
            }
        }

        public bool Verify()
        {
            if (username.Contains("@") && username.Contains(".com"))
            {
                try
                {
                    if (Users.Contains(username))
                    {
                        Private();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This user wasn't found \n");
                        Signup();
                        return false;
                    }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                } 
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
                return false;
            }
            return false;
        }

        private void Private() => Console.WriteLine($"Hey {name} welcome! You're here");

        private string username;
        private string password;
        private string name;
        private List<string> Users = new List<string>();
        private List<string> responses = new List<string>() {"si", "claro", "por supuesto", "sii", "yes", "yeah", "siza"};
    }
}
