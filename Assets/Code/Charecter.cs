using UnityEngine;
using UnityEngine.TextCore.Text;

public class Charecter : MonoBehaviour
{
    //Attributes
    private string name;
    private int health;
    private int attackPower;

    //Property
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown"; }
            else { name = value; }
        }
    }
    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100) { health = 100; }
            else if (value <= 0) { health = 0; }
            else { health = value; }
        }
    }
    public int AttackPower
    {
        get { return attackPower; }
        set { attackPower = value; }
    }

    //Construter
    public virtual void Init(string newName, int newHealth, int newAttackDmg)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = newAttackDmg;
    }

    //Method
    public virtual void ShowStat()
    {
        Debug.Log($"Charecter Name: {Name} | Character Health: {Health} | Charecter Attack Power: {AttackPower}");
    }
    public void TakeDamage(int damageValue)
    {
        health = -damageValue;
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public void Attack(Monster target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attack {target.Name} for {AttackPower} damage");
    }
}
