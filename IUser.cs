using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    public interface IUser
    {
        //List<string> Users { get; set; }
        bool Verify();
        void Signup();
    }
}
