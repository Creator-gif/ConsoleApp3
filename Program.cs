// ЗАДАНИЕ №1
class Budget
{
    static void Main()
    {
        // Расходы
        Console.WriteLine("Введите ваши расходы:");

        Console.Write("Аренда квартиры: ");
        decimal rent = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Пропитание: ");
        decimal food = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Транспорт: ");
        decimal transport = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Коммунальные услуги: ");
        decimal service = Convert.ToDecimal(Console.ReadLine());

        Console.Write("ЖЭК: ");
        decimal JEK = Convert.ToDecimal(Console.ReadLine());

        // Сумма
        decimal total = rent + food + transport + service + JEK;

        // Доход
        Console.Write("Введите ваш ежемесячный доход: ");
        decimal income = Convert.ToDecimal(Console.ReadLine());

        // Баланс
        decimal balance = income - total;

        Console.WriteLine($"Общие расходы: {total}");
        Console.WriteLine($"Ваш доход: {income}");
        Console.WriteLine($"Оставшиеся средства: {balance}");
    }
}

// ЗАДАНИЕ №2
using System;
class Health
{
    static void Main()
    {
        Console.WriteLine("Введите ваши данные: ");

        Console.Write("Вес (кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Рост (м): ");
        double height = Convert.ToDouble(Console.ReadLine());
       
        double bmi = weight / (height * height);
        
        Console.WriteLine($"\nВаш ИМТ: {bmi:F2}");
       
        if (bmi < 18.5)
        {
            Console.WriteLine("Малый вес");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Норма");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Избыток веса");
        }
       
    }
}
