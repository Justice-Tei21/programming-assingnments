
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


        public override string Animalsound()
        {
            for(int i = 0; i < 10; i++)
            Console.WriteLine("bork");

            return "bark";
        }

    }
}
