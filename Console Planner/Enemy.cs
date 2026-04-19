class Enemy
{
    private string name;
    private int health;
    private int maxHealth;
    private int goldReward;
    private int expReward;
    private int minDamage;
    private int maxDamage;
    private static Random rand = new Random();
    public Enemy(string name, int maxHealth, int goldReward, int expReward, int minDamage, int maxDamage)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.goldReward = goldReward;
        this.expReward = expReward;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
    }
    public string Info()
    {
        return $"Имя: {name}\nЗдоровья: {health}/{maxHealth}\nУрон: {minDamage}-{maxDamage}";
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
        health = 0;
    }
    public bool IsAlive()
    {
        return health > 0;

    }
    public int GetAttack()
    {
       return rand.Next(minDamage, maxDamage + 1);
    }
    public int GetGoldReward()
    {
        return goldReward;
    }
    public int GetExpReward()
    {
        return expReward;
    }
}