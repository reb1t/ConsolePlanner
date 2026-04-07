UserData u = new UserData();
Console.WriteLine("Добро пожаловать в первый мой проект!");

Console.Write("Введите как вас зовут: ");
u.name = Console.ReadLine();

Console.Write("Введите сколько вам лет: ");
u.age = int.Parse(Console.ReadLine());

Console.Write("С какого вы города?: ");
u.city = Console.ReadLine();

Console.WriteLine(u.Info());