using System;

class MobileNetwork
{
    public string Name { get; set; }
    public string Country { get; set; }
}


class Life : MobileNetwork { }
class MTC : MobileNetwork { }
class Velcom : MobileNetwork { }


class MobilePhone<T> where T : MobileNetwork
{
    public string Model { get; set; }
    public T Network { get; set; }
}

class Program
{
    static void Main()
    {
       
        MobileNetwork life = new Life() { Name = "Life", Country = "Belarus" };
        MobileNetwork mtc = new MTC() { Name = "MTC", Country = "Belarus" };
        MobileNetwork velcom = new Velcom() { Name = "Velcom", Country = "Belarus" };

      
        MobilePhone<MobileNetwork> siemens = new MobilePhone<MobileNetwork>() { Model = "Siemens C75", Network = life };
        MobilePhone<MobileNetwork> samsung = new MobilePhone<MobileNetwork>() { Model = "S20 ultra", Network = mtc };

        Console.WriteLine($"Модель телефона: {siemens.Model}");
        Console.WriteLine($"Сеть: {siemens.Network.Name} ({siemens.Network.Country})");

        Console.WriteLine($"Модель телефона: {samsung.Model}");
        Console.WriteLine($"Сеть: {samsung.Network.Name} ({samsung.Network.Country})");
    }
}
