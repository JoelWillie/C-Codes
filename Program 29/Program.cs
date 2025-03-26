using System;

class Automobile
{
    public string Manufac { get; set; }
    public string Model { get; set; }
    public int Mileage { get; set; }
    public double Price { get; set; }
}

class Car : Automobile
{
    private int doors;

    public int Doors
    {
        get { return doors; }
        set { doors = value; }
    }

    public void GetCarData()
    {
        Console.Write("Enter make: ");
        Manufac = Console.ReadLine();
        Console.Write("Enter model: ");
        Model = Console.ReadLine();
        Console.Write("Enter mileage: ");
        if (!int.TryParse(Console.ReadLine(), out int mileage))
        {
            Console.WriteLine("Invalid input for mileage. Please enter a valid number."); 
            return;
        }
        Mileage = mileage;
        Console.Write("Enter price: ");
        if (!double.TryParse(Console.ReadLine(), out double price))
        {
            Console.WriteLine("Invalid input for price. Please enter a valid number.");
            return;
        }
        Price = price;
        Console.Write("Enter number of doors: ");
        if (!int.TryParse(Console.ReadLine(), out int doors))
        {
            Console.WriteLine("Invalid input for number of doors. Please enter a valid number.");
            return;
        }
        Doors = doors;
    }


    public void Display()
    {
        Console.WriteLine("Make: " + Manufac);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Mileage: " + Mileage);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Doors: " + Doors);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.GetCarData();
        Console.WriteLine("\nCar Details:");
        myCar.Display();
    }
}
//====> Preveiw of code shown on the pdf file <====//
//   class Automobile
//   {
//   private string make, model;
//   private int mileage;
//   private double price;
//   }

//   public Automobile()
//   {
//    make = "-";
//    model = " ";
//    mileage = 0;
//    price = 0;
//   }

//   public string Make
//   {
//     get { return make; }
//     set { make = value; }
//   }

//    public string Model
//    {
//      get { return model; }
//      set { model = value; }
//    }

//    public int Mileage
//    {
//     get { return mileage; }
//     set { mileage = value; }
//    }

//    public double Price
//    {
//     get { return price; }
//     set { price = value; }
//    }
// }