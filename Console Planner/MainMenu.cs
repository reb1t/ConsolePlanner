class MainMenu
{
    private int choice;
    private int editChoice;
    public void Menu()
    {
        UserData u = new UserData();
        while (true)
        {
            Console.Clear();

            Console.WriteLine("1.Ввести/изменить данные\n2.Показать данные\n0.Выход");

            string input = Console.ReadLine();

            bool proverka = int.TryParse(input, out choice);

            if (proverka == false)
            {
                Console.Write("Введите пункт меню:: ");
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
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Изменить имя\n2.Изменить возраст\n3.Изменить город\n4.Изменить хобби\n5.Изменить всё\n6.Назад");
                    input = Console.ReadLine();
                    proverka = int.TryParse(input, out editChoice);
                    if(proverka == false)
                    {
                        Console.Write("Введите пункт меню: ");
                        continue;
                    }
                    if (editChoice == 1)
                    {
                        Console.Write("Введите новое имя: ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        u.SetName(name);
                        Console.WriteLine("Имя изменено");
                        Console.ReadKey();
                    }
                    else if (editChoice == 2)
                    {
                        Console.Write("Введите новый возраст: ");
                        int age;
                        string ageinput = Console.ReadLine();
                        bool ageCheck = int.TryParse(ageinput, out age);
                        while (!ageCheck)
                        {
                            Console.Write("Введите возраст в цифрах: ");
                            ageinput = Console.ReadLine();
                            ageCheck = int.TryParse(ageinput, out age);

                        }
                        Console.Clear();
                        u.SetAge(age);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                    }
                    else if (editChoice == 3)
                    {
                        Console.Clear();
                        Console.Write("Введите новый город: ");
                        string city = Console.ReadLine();
                        u.SetCity(city);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                    }
                    else if (editChoice == 4)
                    {
                        Console.Clear();
                        Console.Write("Введите свое хобби: ");
                        string hobby = Console.ReadLine();
                        u.SetHobby(hobby);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                    }
                    else if (editChoice == 5)
                    {
                        Console.Clear();
                        Console.Write("Введите новое значение имени: ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Введите новый возраст: ");
                        int age;
                        string ageinput = Console.ReadLine();
                        bool ageCheck = int.TryParse(ageinput, out age);
                        while (!ageCheck)
                        {
                            Console.Write("Введите возраст в цифрах: ");
                            ageinput = Console.ReadLine();
                            ageCheck = int.TryParse(ageinput, out age);

                        }
                        Console.Clear();
                        Console.Write("Введите новый город: ");
                        string city = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Введите свое хобби: ");
                        string hobby = Console.ReadLine();
                        Console.Clear();
                        u.SetData(name, age, city, hobby);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        break;
                    }
                    else if (editChoice == 6)
                    {
                        break;
                    }
                }
                
            }
        }
    }

}