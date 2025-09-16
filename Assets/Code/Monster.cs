using NUnit.Framework.Internal;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Debug = UnityEngine.Debug;

public class Monster : Charecter
{
    //Attributes
    private int lootReward;
    private bool deafeated = false;
    //Property
    public int LootReward
    {
        get { return lootReward; }
        set
        {
            if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        }
    }

    public bool Deafeated
    {
        get { return deafeated; }
        set { value = deafeated; }
    }

    //Construter
    public void Init(string name, int health, int power,int lootAmount)
    {
        base.Init(name, health, power);
        LootReward = lootAmount;
    }

    //Method
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Loot Reward: {LootReward}");
    }
    public int DropReward()
    {
        return LootReward;
    }
}