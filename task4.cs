
class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("1. Добавить запись");
            Console.WriteLine("2. Найти номер по имени");
            Console.WriteLine("3. Вывести все записи");
            Console.WriteLine("4. Выход");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите номер телефона: ");
                    string phoneNumber = Console.ReadLine();
                    phoneBook[name] = phoneNumber; 
                    break;

                case "2":
                    Console.Write("Введите имя: ");
                    name = Console.ReadLine();
                    if (phoneBook.TryGetValue(name, out phoneNumber))
                    {
                        Console.WriteLine($"Номер телефона: {phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Имя не найдено.");
                    }
                    break;

                case "3":
                    foreach (KeyValuePair<string, string> entry in phoneBook)
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value}");
                    }
                    break;

                case "4":
                    return; 

                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}
