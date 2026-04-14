class MainMenu
{
    private int choice;
    private int editChoice;
    UserData u = new UserData();
    public void Menu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("1.Ввести/изменить данные\n2.Показать данные\n0.Выход");

            string input = Console.ReadLine();

            bool proverka = int.TryParse(input, out choice);

            if (proverka == false)
            {
                Console.Write("Введите пункт меню: ");
                continue;
            }

            if (choice == 0)
            {
                Console.WriteLine("Выход из программы...");
                break;
            }
            else if (choice == 2)
            {
                Console.Clear();

                Console.WriteLine(u.Info());

                Console.ReadKey();
            }
            else if (choice == 1)
            {
                pudMenu();
            }
            else
            {
                Console.WriteLine("Такого пункта нет");
                Console.ReadKey();
            }
        }
    }
    // подменю изменений данных
    public void pudMenu()
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Изменить имя\n2.Изменить возраст\n3.Изменить город\n4.Изменить хобби\n5.Изменить всё\n6.Назад");
            string input = Console.ReadLine();

            bool proverka = int.TryParse(input, out editChoice);
            if (proverka == false)
            {
                Console.Write("Введите пункт меню: ");
                continue;
            }
            switch (editChoice)
            {
                case 1:
                    {
                        string name = GetNotEmptyString("Введите новое имя: ");
                        Console.Clear();
                        u.SetName(name);
                        Console.WriteLine("Имя изменено");
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    {
                        int age = GetAge();
                        Console.Clear();
                        u.SetAge(age);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        break;
                    }

                case 3:
                    {
                        Console.Clear();
                        string city = GetNotEmptyString("Введите новый город: ");
                        u.SetCity(city);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        string hobby = GetNotEmptyString("Введите новое хобби: ");
                        u.SetHobby(hobby);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        break;
                    }

                case 5:
                    {
                        Console.Clear();
                        string name = GetNotEmptyString("Введите новое имя: ");
                        int age = GetAge();
                        Console.Clear();
                        string city = GetNotEmptyString("Введите новый город: ");
                        Console.Clear();
                        string hobby = GetNotEmptyString("Введите новое хобби: ");
                        Console.Clear();
                        u.SetData(name, age, city, hobby);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        return;
                    }
                case 6:
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Такого пункта нет");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    

    // изменения возраста
    public int GetAge()
    {
        Console.Write("Введите новый возраст: ");
        int age;
        string ageinput = Console.ReadLine();
        bool ageCheck = int.TryParse(ageinput, out age);
        while (!ageCheck || age <= 0 || age >= 120)
        {
            Console.Write("Введите возраст в цифрах(1-119): ");
            ageinput = Console.ReadLine();
            ageCheck = int.TryParse(ageinput, out age);

        }
        return age;
    }
    // проверка на пустую строку(универсален)
    public string GetNotEmptyString(string message)
    {
        Console.Write(message);
        string text = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine("Поле не может быть пустым: ");
            Console.Write("Введите новую строку: ");
            text = Console.ReadLine();
        }
        return text;
    }
}