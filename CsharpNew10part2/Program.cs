#nullable enable // включаем nullable-контекст на уровне файла

string? name = null;

PrintUpper(name);

void PrintUpper(string? text)
{
   // Console.WriteLine(text.ToUpper());
}

string? name2 = null;

PrintUpper(name2!);

void PrintUpper2(string text)
{
    if (text == null) Console.WriteLine("null");
    else Console.WriteLine(text.ToUpper());
}


