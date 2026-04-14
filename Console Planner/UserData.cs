//Класс куда попадают все данные пользователя которые он вводит
class UserData
{ 
    private string name;
    private int age;
    private string city;
    private string hobby;
    // Проверка возроста на совершеннолетие
    public string GetAgeStatus()
    {
        if (age < 0)
        {
            return ("Ошибка");
        }
        else if (age >= 18)
        {
            return ("Совершеннолетний");
        }
        else
        {
            return ("Несовершеннолетний");
        }
    }
    // Вывод всей информации о пользователе
    public string Info()
    {
        return $"Имя: {name}\nВозраст: {age}\nГород: {city}\nЧерез 5 лет вам будет: {FutureAge()}\nСтатус: {GetAgeStatus()}\nХобби: {hobby}";
    }
    // Увеличение возраста на 5 лет
    public int FutureAge()
    {
        return age + 5;
    }
    // Данные пользователя
    public void SetData(string name, int age, string city, string hobby)
    {
        this.name = name;
        this.age = age;
        this.city = city;
        this.hobby = hobby;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public void SetCity(string city)
    {
        this.city = city;
    }
    public void SetHobby(string hobby)
    {
        this.hobby = hobby;
    }

}