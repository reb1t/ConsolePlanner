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
    private int damage;
    private int maxHealth;
    // Вывод всей информации о персонаже
    public string Info()
    {
        return $"Имя: {name}\nВозраст: {age}\nПроисхождение: {origin}\nВаш класс: {heroClass}\nЧерта характера: {trait}\nЗдоровье: {health}/{maxHealth}\nОпыт: {exp}\nЗолото: {gold}\nУрон: {damage}";
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
    public void SetDamage(int damage)
    {
        this.damage = damage;
    }
    public void SetMaxHealth(int maxHealth)
    {
        this.maxHealth = maxHealth;
    }
    public void SetStartStats(string heroClass)
    {
        switch (heroClass)
        {
            case "Воин":
                {
                    health = 120;
                    exp = 0;
                    gold = 5;
                    damage = 15;
                    maxHealth = 120;
                    break;
                }
            case "Маг":
                {
                    health = 75;
                    exp = 0;
                    gold = 15;
                    damage = 18;
                    maxHealth = 75;
                    break;
                }
            case "Вор":
                {
                    health = 80;
                    exp = 0;
                    gold = 10;
                    damage = 10;
                    maxHealth = 80;
                    break;
                }
            case "Наемник":
                {
                    health = 100;
                    exp = 0;
                    gold = 20;
                    damage = 10;
                    maxHealth = 100;
                    break;
                }
            default:
                {
                    health = 100;
                    exp = 0;
                    gold = 0;
                    damage = 10;
                    maxHealth = 100;
                    break;
                }
        }
        SetTraitBonus(this.trait);

    }
    public void SetTraitBonus(string trait)
    {
        if (string.IsNullOrEmpty(trait))
            return;
        switch (trait)
        {
            case "Клептоман":
                {
                    gold += 5;
                    break;
                }
            case "Трусливость":
                {
                    gold += 10;
                    break;
                }
            case "Жадный":
                {
                    gold += 20;
                    break;
                }
            case "Здоровый":
                {
                    health += 20; maxHealth += 20;
                    break;
                }
        
            
            
        }
        
    }
    public bool IsCreated()
    {
        return !string.IsNullOrEmpty(heroClass);
    }
}