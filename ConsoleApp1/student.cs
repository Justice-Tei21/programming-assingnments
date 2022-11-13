using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class student:User

    {
        protected int studentid;
        int Studentid { get { return studentid; } }
        Dictionary<string, char> studentsgrades;

        Dictionary<string, char> Studentsgrades { get { return studentsgrades; } }

       //use the data from the profile to get the proper grades
       public virtual  Dictionary<string, char>  GetGrades() {
            connecttogradebase();
            //should change this->studentgrades
            return null; 
        }

        public virtual void PrintGrades() { }
    }
}
