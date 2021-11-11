
string name = null;
Console.WriteLine(name);

string? name2 = Console.ReadLine();

string name3 = null;
PrintUpper(name3);  // ! NullReferenceException

void PrintUpper(string text)
{
    Console.WriteLine(text.ToUpper());
}

string? name4 = null;
PrintUpper4(name4);  // 

void PrintUpper4(string? text)
{
    Console.WriteLine(text.ToUpper());
}