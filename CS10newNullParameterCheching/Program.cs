

using CS10newNullParameterCheching;

class Program
{
    static void Main()
    {

    }

    public void Exc(Book book)
    {
        if (book==null)
        {
            throw new ArgumentNullException("book");

        }
    }

    public void ExcNew(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);
    }
} 


