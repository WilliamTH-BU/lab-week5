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
    public bool MonsterDeafeated;
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

    //Construter
    public override void Init(string monsterName, int monsterHealth, int attackPower)
    {
        base.Init(monsterName, monsterHealth, attackPower);
        LootReward = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Lootreward: {LootReward}");
    }
    public int DropReward()
    {
        return LootReward;
    }
}