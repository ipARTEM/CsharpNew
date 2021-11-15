using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 15, 45, 78 };
        list.Max();

        List<Device> devices = new List<Device>();
        devices.Add(new Device { Name = "TV", Price = 100 });
        devices.Add(new Device {  Name= "Phone", Price = 88 });


        List<Device> devices2= new List<Device>();

        devices.Max(d => d.Price);  //100

        //devices2.OrderByDescending(d = d.Price).First();

        devices.MaxBy(d => d.Price);
    }

}

class Device
{
    public string Name { get; set; }
    public int Price { get; set; }
}