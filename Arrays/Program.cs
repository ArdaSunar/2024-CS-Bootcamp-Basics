// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> students = new List<string>
{
    "Engin", "Derin", "Arda"
};
Console.WriteLine(students[0]);
Console.WriteLine(students[1]);
Console.WriteLine(students[2]);

string[,] regions = new string[7, 3]
{
     {"","","" },
     {"","","" },
     {"","","" },
     {"","","" },
     {"","","" },
     {"","","" },
     {"","","" },
};

int[,] notes = new int[3, 2]
{
    {1,1},
    {2,3},
    {3,5}
};

for (int i = 0; i <= notes.GetUpperBound(0); i++)
{
    for (int j = 0; j <= notes.GetUpperBound(1); j++)
    {
        Console.WriteLine(notes[i,j]);
    }
    Console.WriteLine("********");
}