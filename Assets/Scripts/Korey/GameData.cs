public static class GameData
{
    //Health Player
    public const int MinHealth = 0;
    public const int MaxHealth = 230;
    public const float DefaultTime = 2;
    public const float HitTime = 10f;

    public const float sprintSpeed = 4f;

    public static float batteryPower = 100f;

    //Damage
    public const sbyte DamageByKick = -30;
    public const sbyte DamageByLaser = -10;
    public const sbyte DamageByBullet = -15;
    public const sbyte DamageByExplosion = -40;

    private static int health = 230;

    public static int Health
    {
        get
        {
            return health;
        }
        set
        {
            if (MinHealth <= value && value <= MaxHealth)
            {
                health = value;
            }
        }
    }

}