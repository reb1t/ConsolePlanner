class UserData
{ 
    public string name;
    public int age;
    public string city;
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
    public string Info()
    {
        return $"Имя: {name}\nВозраст: {age}\nГород: {city}\nЧерез 5 лет вам будет: {age + 5}\nСтатус: {GetAgeStatus()}";
    }
}