// See https://aka.ms/new-console-template for more information




using spacey;
using school;
using coordinates;
using floating;

Console.WriteLine("Hello, World!");




Class1 popups = new Class1(25);

Cords cordies = new Cords(20);

cordies.print();

Inputchecker checkthis= new Inputchecker();

Birdy[] birdies = new Birdy[3];



birdies[0] = new Birdy(12, "Luther ", 8.42);
birdies[1] = new Birdy(3, "Ca ", 4.21);
birdies[2] = new Birdy(100, "Giganticus ", 400.00);

for (int i = 0; i < birdies.Length; i++)
{
    birdies[i].Sing();
}
