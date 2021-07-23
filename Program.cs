using System;
using System.Collections.Generic;

namespace Algorithym
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth auth = new("test@mail.com", "12345", "Yito");
            auth.Verify();
        }
    }
}
