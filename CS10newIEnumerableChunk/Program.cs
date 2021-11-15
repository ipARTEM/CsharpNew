
List<int> numbers = new List<int> {1,2,3,4,5,6,7,8 };

foreach (var i in numbers.Chunk(3))
{
    Parallel.ForEach(numbers, i =>
    {
        global::System.Console.WriteLine(i);
        global::System.Console.WriteLine("*");
    });

}