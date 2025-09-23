using NUnit.Framework.Internal;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Player : Charecter
{
    //Attributes
    //private int gold;

    //Property
    /*public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }*/
    public  int Gold {  get; private set; }
    private int maxGold;
    //Construter
    public void Init(string newName, int newHealth, int newAttackDmg)
    {
        base.Init(newName, newHealth, newAttackDmg);
        Gold = 0;
    }

    //Method
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Player Gold: {Gold}");
    }
    public override void Attack(Charecter target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} Attack {target.Name} for {AttackPower} damage");
    }
    public override void Attack(Charecter target, int bonusDamage)
    {
        target.TakeDamage(AttackPower + bonusDamage);
        Debug.Log($"{Name} Attack {target.Name} for {AttackPower} with {bonusDamage} bonus damage");
    }
    public void Heal(int healAmount)
    {
        Health  = Mathf.Clamp( Health + healAmount, 0, maxHealth );
        Debug.Log($"{Name} heal {healAmount} ; Current Health {Health}");
    }

    public void EarnGold(int goldReceive)
    {
        if (goldReceive > 0)
        {
            //Gold =+ goldReceive;
            Gold = Mathf.Clamp(Gold + goldReceive, 0, maxGold);
            Debug.Log($"{Name} receive {goldReceive} gold ; Current gold is {Gold}");
        }
    }
}