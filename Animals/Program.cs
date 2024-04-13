using System;
using System.ComponentModel.Design;
using System.Drawing;
abstract class Animal
{
    public abstract void DisplayAnimal();
   
}

interface Carnivore
{
    void displayEatC() => Console.WriteLine();
    void TypeC() => Console.WriteLine();
    void FoodC() => Console.WriteLine();

}
interface Herbivore
{ 
 void displayEatH()=>Console.WriteLine();
 void TypeH() => Console.WriteLine();
 void FoodH() => Console.WriteLine();
}

class Elefant : Animal,Herbivore
{
    
    static Random rnd = new Random();
    int Size = rnd.Next(5,10);
    public void ElefantSize()
    {
        Console.WriteLine(Size);
    }
    public override void DisplayAnimal()
    {
        DisplayEatH();
        TypeH();
        FoodH();
    }

    public void DisplayEatH()
    {
        Console.WriteLine( "\nСлон ест растмтельную еду");        
    }
    public void TypeH()
    {
        Console.WriteLine("тип :травоядное");
    }
    public void FoodH() 
    {
        Console.WriteLine("ест листья");
    }
}
class Cat : Animal, Carnivore
{
    public override void DisplayAnimal()
    {
        DisplayEatC();
        TypeC();
        FoodC();

    }

    public void DisplayEatC()
    {
        Console.WriteLine("\nКот ест мясную еду.");
    }
    public void TypeC()
    {
        Console.WriteLine("тип:хищник");
    }
    public void FoodC() 
    {
        Console.WriteLine("ест рыбу");
    }
    
    
}
class Bear : Animal, Herbivore, Carnivore
{
    public override void DisplayAnimal()
    {
        DisplayEatH();
        TypeH();
        FoodH();
        DisplayEatC();
        TypeC();
        FoodC();
    }

    public void DisplayEatH()
    {
        Console.WriteLine("\nМедведь ест растительную еду.");

    }
    public void TypeH()
    {
        Console.WriteLine("тип :травоядное");
    }
    public void FoodH()
    {
        Console.WriteLine("ест ягоды");
    }
    public void DisplayEatC()
    {
        Console.WriteLine("Медведь ест мясную еду.");
    }
    public void TypeC()
    {
        Console.WriteLine("тип :хищник");
    }
    public void FoodC()
    {
        Console.WriteLine("ест рыбу");
    }
}
class Zoo()
{
   

    public void Zoo1()
    {
        Console.WriteLine("\nДобро пожаловать в зоопарк." +
              "Все животные должны находится в вольерах\n");
    }
    public void Add(Animal any)
    {
        
        string anim;
        if (any is Herbivore)
        {
            if (any is Carnivore)
            {
                
                anim = "hc";
            }
            else
            {
                 anim = $"Животное {any} помещено в вольер к травоядным";
            }
        }
        else
        {
            anim = $"Животное {any} помещено в вольер к травоядным";
        }
        
        switch (anim) 
        {
            case "hc":
                Console.WriteLine($"Животное {any} можно поместить как к травоядным," +
                    $"так и к хищникам");
                Console.WriteLine($"выберите,в какой вольер поместить животное {any}:" +
                    "1-травоядные,2-хищники");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine($"Животное {any} помещено в вольер к травоядным");
                        break;
                    case 2:
                        Console.WriteLine($"Животное {any} помещено в вольер к хищникам");
                        break;
                } 
                break;
            default:
                Console.WriteLine(anim);
                break;
        }
        
        

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.DisplayAnimal();

        Elefant elefant = new Elefant();
        elefant.DisplayAnimal();
        

        Bear bear = new Bear();
        bear.DisplayAnimal();

        Zoo zoo = new Zoo();
        zoo.Zoo1();
        zoo.Add(elefant);
        zoo.Add(cat);
        zoo.Add(bear);
        
        elefant.ElefantSize();
    }
}