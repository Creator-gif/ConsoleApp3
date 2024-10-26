// ЗАДАНИЕ №1
class Budget
{
    static void Main()
    {
        Console.WriteLine("Расходы:");
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

        decimal total = rent + food + transport + service + JEK;

        Console.Write("Доход: ");
        decimal income = Convert.ToDecimal(Console.ReadLine());

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

        Console.Write("Вес: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Рост: ");
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

// ЗАДАНИЕ №3
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");
        Console.Write("Введите сумму: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите срок: ");
        int months = Convert.ToInt32(Console.ReadLine());

        if (months <= 0)
        {
            Console.WriteLine("Больше нуля.");
            return;
        }
        
        decimal Savings = amount / months;
        
        Console.WriteLine("Чтобы накопить вашу сумму, копить по " + savings + " в месяц");
    }
}

// ЗАДАНИЕ №4
using System;
class Credit
{
    static void Main()
    {
        Console.Write("Сумма кредитов: ");
        decimal totalCredits = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Сумма задолженностей: ");
        decimal totalDebts = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Открытые кредиты: ");
        int openCredits = Convert.ToInt32(Console.ReadLine());

        decimal debtToCredit = totalDebts / totalCredits;

        if (debtToCredit > 0.5m)
        {
            Console.WriteLine("Соотношение высокое");
        }
        else if (debtToCredit >= 0.3m)
        {
            Console.WriteLine("Соотношенеи нормальное");
        }
        else
        {
            Console.WriteLine("Соотношение низкое");
        }
    }
}

// Задание №5
class Budget
{
    static void Main()
    {
        Console.Write("Аренда сноуборда: ");
        decimal rentSnow = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Аренда лыжи: ");
        decimal rentSkies = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Сколько дней: ");
        decimal days = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Страховка: ");
        decimal service = Convert.ToDecimal(Console.ReadLine());

        decimal total = (rentSnow + rentSkies + service) * days;

        Console.Write("Бюджет: ");
        decimal budjet = Convert.ToDecimal(Console.ReadLine());

        decimal balance = budjet - total;

        Console.WriteLine($"Общие расходы: {total}");
        Console.WriteLine($"Ваш бюджет: {budjet}");
        Console.WriteLine($"Остаток: {balance}");
    }
}
