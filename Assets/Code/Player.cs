using NUnit.Framework.Internal;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Player : Charecter
{
    //Attributes
    private int gold;

    //Property
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }
    //Construter
    public override void Init(string newName, int newHealth, int newAttackDmg)
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

    public void EarnGold(int goldReceive)
    {
        if (Gold > 0)
        {
            Gold =+ goldReceive;
        }
    }
}