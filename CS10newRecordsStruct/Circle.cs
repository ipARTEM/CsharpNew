
namespace CS10newRecordsStruct;

record Circle
{
    public override string ToString()
    {
        return typeof(Circle).Name; 
    }
}

record BigCircle : Circle
{
    public override string ToString()
    {
        return typeof(BigCircle).Name;
    }
}

record Circle2
{
    public sealed override string ToString()
    {
        return typeof(Circle).Name;
    }
}

record BigCircle2 : Circle2
{
    //public override string ToString()
    //{
    //    return typeof(BigCircle2).Name;
    //}
}

