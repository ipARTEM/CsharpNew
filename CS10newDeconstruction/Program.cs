
using CS10newDeconstruction;

var author = new Author("Artem", "Khimin");
Console.WriteLine(author);

(string name, string lastName) = author;
Console.WriteLine(name);
Console.WriteLine(lastName);

var name2=string.Empty;
var lastName2=string.Empty;  
(name2,lastName2) = author;
Console.WriteLine(name2);
Console.WriteLine(lastName2);

var name3=string.Empty;
(name3,var lastName3) = author;
Console.WriteLine(name3);
Console.WriteLine(lastName3);
