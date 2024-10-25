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
