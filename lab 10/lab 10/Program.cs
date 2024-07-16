using System;

// Абстрактний клас Flower, який встановлює загальний інтерфейс для квіток
abstract class Flower
{
    public string Name { get; set; } // Назва квітки
    public string Color { get; set; } // Колір квітки
    public double Price { get; set; } // Ціна квітки

    // Конструктор класу Flower
    public Flower(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    // Перевизначення методу Equals для порівняння квіток
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Flower other = (Flower)obj;
        return Name == other.Name && Color == other.Color && Price == other.Price;
    }

    // Абстрактний метод, який потрібно перевизначити у похідних класах
    public abstract void Blossom();

    // Віртуальний метод для виведення інформації про квітку
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Це {Color} {Name}. Ціна: {Price}$");
    }
}

// Клас для представлення троянди
class Rose : Flower
{
    // Конструктор класу Rose
    public Rose(string color, double price) : base("Rose", color, price) { }

    // Перевизначення методу Blossom для Rose
    public override void Blossom()
    {
        Console.WriteLine($"{Color} {Name} розцвітає.");
    }

    // Перевизначення методу DisplayInfo для Rose
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Ця троянда дуже ароматна.");
    }
}

// Клас для представлення тюльпана
class Tulip : Flower
{
    // Конструктор класу Tulip
    public Tulip(string color, double price) : base("Tulip", color, price) { }

    // Перевизначення методу Blossom для Tulip
    public override void Blossom()
    {
        Console.WriteLine($"{Color} {Name} розцвітає.");
    }

    // Перевизначення методу DisplayInfo для Tulip
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Цей тюльпан гарно виглядає у букеті.");
    }
}

// Клас для представлення ромашки
class Chamomile : Flower
{
    // Конструктор класу Chamomile
    public Chamomile(string color, double price) : base("Chamomile", color, price) { }

    // Перевизначення методу Blossom для Chamomile
    public override void Blossom()
    {
        Console.WriteLine($"{Color} {Name} розцвітає.");
    }

    // Перевизначення методу DisplayInfo для Chamomile
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Ця ромашка найкраща для чаю.");
    }
}

// Головний клас програми
class Program
{
    // Головний метод програми
    static void Main(string[] args)
    {
        // Створення масиву квітів
        Flower[] bouquet = new Flower[]
        {
            new Rose("Червона", 2.5),
            new Tulip("Жовта", 1.8),
            new Chamomile("Біла", 1.0)
        };

        double totalCost = 0; // Змінна для зберігання загальної вартості букету

        Console.WriteLine("Букет:");

        // Проходження по масиву квітів і виведення інформації про кожен елемент
        foreach (Flower flower in bouquet)
        {
            flower.DisplayInfo(); // Виведення інформації про квітку
            totalCost += flower.Price; // Додавання вартості квітки до загальної вартості букету
        }

        Console.WriteLine($"Загальна вартість букету: {totalCost}$"); // Виведення загальної вартості букету
    }
}
