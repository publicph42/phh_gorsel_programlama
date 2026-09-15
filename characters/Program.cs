using System.Runtime.CompilerServices;

class Character
{
    string name = "default name";
    int health = 100;

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Console.WriteLine(health.ToString());
    }
}