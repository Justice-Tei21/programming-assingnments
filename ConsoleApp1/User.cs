using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class User
    {
        // every user has a name and an email address
        protected string Name { get; set; }
        protected string Email { get; set; }


        //profile should be defined outside of the class
        protected struct profile { };

        protected User()
        {
            login();
            fetchprofile();
        }

        //bools can be used to determine if the thask was successful or not
        bool login() { return true; }


        profile fetchprofile() {
            profile t;
            return t; }


        // will be used in inherited classes
        protected bool connecttogradebase() { return true; }
        

        


    }
}
