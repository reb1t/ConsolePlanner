class MainMenu
{
    private int choice;
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
                Console.WriteLine("Введите новые значения");

                Console.Clear();

                Console.Write("Введите новое имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                int age;
                Console.Write("Введите новый возраст: ");
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

                u.SetData(name, age, city, hobby);

                Console.Clear();

                Console.WriteLine("Данные сохранены");
                Console.ReadKey();
            }
        }
    }

}