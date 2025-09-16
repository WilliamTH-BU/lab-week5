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
            if (string.IsNullOrEmpty(value)) { name = "Error"; }
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
    public int AttackPower { get; set; }
    //Construter
    public virtual void Init(string newname, int newHealth, int newAttackDmg)
    {
        name = newname;
        health = newHealth;
        attackPower = newAttackDmg;
    }

    //Method
    public virtual void ShowStat()
    {
        Debug.Log($"Charecter Name: {Name} | Character Health: {Health} | Charecter Attack Power{AttackPower}");
    }
    public void TakeDamage(int damageValue)
    {
        health = -damageValue;
    }

    public bool IsAlive() { return health > 0; }

   
    /*public void Attack(target)
    {
        Debug.Log($"{Name} attack {target} for {AttackPower} damage");
        target.TakeDamage(AttackPower);
    }*/
}
