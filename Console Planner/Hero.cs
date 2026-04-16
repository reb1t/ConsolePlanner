//Класс куда попадают все данные персонажа которые он вводит
class Hero
{
    private string name;
    private int age;
    private string origin;
    private string trait;
    private string heroClass;
    private int health;
    private int exp;
    private int gold;
    // Вывод всей информации о персонаже
    public string Info()
    {
        return $"Имя: {name}\nВозраст: {age}\nПроисхождение: {origin}\nВаш класс: {heroClass}\nЧерта характера: {trait}\nЗдоровье: {health}\nОпыт: {exp}\nЗолото: {gold}";
    }
    // Данные персонажа
    public void SetData(string name, int age, string origin, string trait, string heroClass)
    {
        this.name = name;
        this.age = age;
        this.origin = origin;
        this.trait = trait;
        this.heroClass = heroClass;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public void SetOrigin(string origin)
    {
        this.origin = origin;
    }
    public void SetTrait(string trait)
    {
        this.trait = trait;
    }
    public void SetHeroClass(string heroClass)
    {
        this.heroClass = heroClass;
    }
    public void SetHealth(int health)
    {
        this.health = health;
    }
    public void SetExp(int exp)
    {
        this.exp = exp;
    }
    public void SetGold(int gold)
    {
        this.gold = gold;
    }
    public void SetStartStats(string heroClass)
    {
        switch(heroClass)
        { 
            case "Воин":
            {
                    health = 120;
                    exp = 0;
                    gold = 5;
                    break;
            }
            case "Маг":
            {
                    health = 75;
                    exp = 0;
                    gold = 15;
                    break;
            }
            case "Вор":
            {
                    health = 80;
                    exp = 0;
                    gold = 10;
                    break;
            }
            case "Наемник":
            {
                    health = 100;
                    exp = 0;
                    gold = 20;
                    break;
            }
            default:
            {
                    health = 100;
                    exp = 0;
                    gold = 0;
                    break;
            }
        }

    }
}