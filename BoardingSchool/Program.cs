// See https://aka.ms/new-console-template for more information
using BoardingSchool.Models;

Console.WriteLine("Hello, type the quantity(1 to 10) !");

int n = int.Parse(Console.ReadLine());

if (n < 0 || n > 9)
{
    Console.WriteLine("Invalid quantity");
    return;
}

Room[] roomVect = new Room[10];
Student[] studentVect = new Student[n];

for (int i = 0; i < studentVect.Count(); i++)
{
    Console.WriteLine("Type student's email");
    string email = Console.ReadLine();

    Console.WriteLine("--------------------------------");

    Console.WriteLine("Type student's name");
    string name = Console.ReadLine();

    Console.WriteLine("");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("");

    studentVect[i] = new Student
    {
        Email = email,
        Name = name
    };

    roomVect[i] = new Room
    {
        Student = studentVect[i],
        Number = i + 1,
        IsAvailable = false
    };
}

Console.WriteLine("Occupation Report");
for (int i = 0; i < studentVect.Length; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"ROOM {roomVect[i].Number}: {studentVect[i].Name}");
}