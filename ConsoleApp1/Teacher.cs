using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Teacher:student
    {



        //can actually get the grades of multiple students
        public override Dictionary<string, char> GetGrades() { return null; }


        //could print out the grades of several students rather
        //than one
        public override void PrintGrades() {  }


        //used in getgrades to switch which student to select the
        //grades of.
        int Switchstudent() { return 0; }
    }
}
