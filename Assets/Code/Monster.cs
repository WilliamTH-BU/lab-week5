using NUnit.Framework.Internal;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Debug = UnityEngine.Debug;
public enum MonsterType
{
    Slime,
    HollowShulker,
    UndeadKnight,
}
public class Monster : Charecter
{
    //Attributes
    private int lootReward;
    private bool defeated = false;
   
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

    public bool Defeated
    {
        get { return defeated; }
        set { value = defeated; }
    }
    public MonsterType monsterType { get; private set; }
    //Construter
    public void Init(MonsterType monType)
    {
        /*base.Init(name, health, power);
        LootReward = lootAmount;*/
        switch (monType)
        {
            case MonsterType.Slime:
                base.Init("Slime", 10, 2);
                lootReward = 5; break;
            case MonsterType.HollowShulker:
                base.Init("Hollow Shulker", 30, 15);
                lootReward = 10; break;
            case MonsterType.UndeadKnight:
                base.Init("Undead Knight", 45, 20);
                lootReward = 15; break;
        }
    }

    //Method
    public override void Attack(Charecter target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} bites {target.Name} for {AttackPower} damage");
    }
    public override void Attack(Charecter target, int bonusDamage)
    {
        target.TakeDamage((AttackPower * 2) + (bonusDamage / 2));
        Debug.Log($"{Name} Attack {target.Name} for {AttackPower} with {bonusDamage} bonus damage");
    }
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