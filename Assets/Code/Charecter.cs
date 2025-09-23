using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class Charecter : MonoBehaviour
{
    //Attributes
    private string name;
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
    public int Health { get; protected set; }
    protected int maxHealth = 100;
    /*private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100) { health = 100; }
            else if (value <= 0) { health = 0; }
            else { health = value; }
        }
    }*/
    public int AttackPower
    {
        get { return attackPower; }
        set { attackPower = value; }
    }

    //Construter
    public void Init(string newName, int newHealth, int newAttackDmg)
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
        /*Health -= damageValue;*/
        Health = Mathf.Clamp(Health - damageValue, 0, maxHealth);
        Debug.Log($"{Name} takes {damageValue} damage");
        /*if (Health > maxHelth) { Health = 100; }
        else if (Health <= 0) { Health = 0; }*/
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public abstract void Attack(Charecter target);
    public abstract void Attack(Charecter target, int bonusDamage);
    /*public virtual void Attack(Charecter target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attack {target.Name} for {AttackPower} damage");
    }*/
}
