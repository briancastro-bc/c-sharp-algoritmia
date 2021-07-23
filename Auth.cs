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
            this.Users = new List<string>();
        }

        public string Signup()
        {
            //TODO: Continue...
            return "works";
        }

        public bool Verify()
        {
            if (username.Contains("@") && username.Contains(".com"))
            {
                try
                {
                    if (Users.Contains(username))
                    {
                        return true;
                    }
                    else
                    {
                        //Console.WriteLine("No se encontró el nombre de usuario \n");
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

        private string username;
        private string password;
        private string name;
        public List<string> Users { get; set; }
    }
}
