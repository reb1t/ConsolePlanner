class MainMenu
{
    private int choice;
    private int editChoice;
    private int ClassSelection;
    private int Trait;
    private int Origin;
    Hero h = new Hero();
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

                Console.WriteLine(h.Info());

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
            Console.WriteLine("1.Изменить имя персонажа\n2.Изменить возраст персонажа\n3.Изменить происхождение\n4.Изменить черту характера\n5.Класс персонажа\n6.Изменить всё\n7.Назад");
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
                        Console.Clear();
                        string name = GetNotEmptyString("Введите новое имя персонажа: ");
                        Console.Clear();
                        h.SetName(name);
                        Console.WriteLine("Имя изменено");
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    {
                        Console.Clear();
                        int age = GetAge();
                        Console.Clear();
                        h.SetAge(age);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        break;
                    }

                case 3:
                    {
                        Console.Clear();
                        string origin = OriginSelection();
                        h.SetOrigin(origin);
                        Console.WriteLine("Происхождение выбрана");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        string trait = TraitSelection();
                        h.SetTrait(trait);
                        Console.WriteLine("Черта характера выбрана");
                        Console.ReadKey();
                        break;
                    }

                case 5:
                    {
                        Console.Clear();
                        string heroClass = HeroClass();
                        h.SetHeroClass(heroClass);
                        h.SetStartStats(heroClass);
                        Console.WriteLine("Класс выбран");
                        Console.ReadKey();
                        break;
                    }

                case 6:

                    {
                        Console.Clear();
                        string name = GetNotEmptyString("Введите новое имя: ");
                        int age = GetAge();
                        Console.Clear();
                        string origin = OriginSelection();
                        Console.Clear();
                        string trait = TraitSelection();
                        Console.Clear();
                        string heroClass = HeroClass();
                        h.SetStartStats(heroClass);
                        h.SetData(name, age, origin, trait, heroClass);
                        Console.WriteLine("Данные изменены");
                        Console.ReadKey();
                        return;
                    }

                case 7:
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
        Console.Write("Введите возраст персонажа: ");
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
    public string HeroClass()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Воин\n2.Маг\n3.Вор\n4.Наемник\n5.Назад");
            string input = Console.ReadLine();

            bool proverka = int.TryParse(input, out ClassSelection);
            if (proverka == false)
            {
                Console.Write("Введите пункт меню: ");
                continue;
            }
            
            switch(ClassSelection)
            {
                case 1:
                {
                    return "Воин";
                }
                case 2:
                {
                    return "Маг";    
                }
                case 3:
                {
                    return "Вор";   
                }
                case 4:
                {
                    return "Наемник";
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
    public string TraitSelection()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Черта характера\n1.Клептоман(бонус к воровству)\n2.Трусливость(бонус к побегу)\n3.Жадный(бонус к добыче золота)\n4.Здоровый(бонус к здоровью)\n5.Назад");
            string input = Console.ReadLine();

            bool proverka = int.TryParse(input, out Trait);
            if (proverka == false)
            {
                Console.Write("Введите пункт меню: ");
                continue;
            }

            switch (Trait)
            {
                case 1:
                    {
                        return "Клептоман";
                    }
                case 2:
                    {
                        return "Трусливость";
                    }
                case 3:
                    {
                        return "Жадный";
                    }
                case 4:
                    {
                        return "Здоровый";
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
    public string OriginSelection()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Происхождение\n1.Деревня\n2.Город\n3.Столица\n4.Пустыня\n5.Джунгли\n6.Назад");
            string input = Console.ReadLine();

            bool proverka = int.TryParse(input, out Origin);
            if (proverka == false)
            {
                Console.Write("Введите пункт меню: ");
                continue;
            }

            switch (Origin)
            {
                case 1:
                    {
                        return "Деревня";
                    }
                case 2:
                    {
                        return "Город";
                    }
                case 3:
                    {
                        return "Столица";
                    }
                case 4:
                    {
                        return "Пустыня";
                    }
                case 5:
                    {
                        return "Джунгли";
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
}