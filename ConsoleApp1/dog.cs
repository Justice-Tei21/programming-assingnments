
using animalia;

namespace animalia
{
    class Dog : Animal
    {
        int taillength;


        public int TailLength { get {Console.WriteLine(taillength); return taillength; }set { taillength = value; } }


        public Dog()
        {
            Console.WriteLine("hello chum");
        }


        public string Bark()
        {
            Console.WriteLine("bork");
            return "bark";
        }

    }
}
