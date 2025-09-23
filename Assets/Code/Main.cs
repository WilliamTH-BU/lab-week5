using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /*private List<Monster> monsters = new List<Monster>();*/
    public Player player;
    public List<Monster> monstersPrefabs;

    public Monster currentMonster;

    public List<Monster> monsters = new List<Monster>();
    void Start()
    {
        SpawnMonster(MonsterType.Slime);
        SpawnMonster(MonsterType.HollowShulker);
        SpawnMonster(MonsterType.UndeadKnight);

        //Show monster stat
        foreach (var monster in monsters)
        {
            monster.ShowStat();
        }

        player.Init("Samton", 100, 5);
        player.ShowStat();

        Debug.Log("Fight Start -------------------");

        currentMonster = monsters[0];

        player.Attack(currentMonster, 20);
        currentMonster.Attack(player, 6);

        currentMonster.ShowStat();
        player.ShowStat();

        /*//----------------Spawn Slime----------------
        //Initialization
        currentMonster = Instantiate(monstersPrefabs[0]);

        currentMonster.Init("Slime", 10, 2, 5);

        //Add monster to list
        monsters.Add(currentMonster);


        //----------------Spawn Hollow Shulker----------------
        //Initialization
        currentMonster = Instantiate(monstersPrefabs[1]);

        currentMonster.Init("Hollow Shulker", 30, 15, 10);
 
        //Add monster to list
        monsters.Add(currentMonster);


        //----------------Spawn Undead Knight----------------
        //Initialization
        currentMonster = Instantiate(monstersPrefabs[2]);

        currentMonster.Init("Undead Knight", 45, 20, 15);

        //Add monster to list
        monsters.Add(currentMonster);


        //Show monster stat
        foreach (var monster in monsters)
        {
            monster.ShowStat();
        }

        player.Init("Samton", 100, 0);
        player.ShowStat();

        currentMonster = monsters[0];

        player.Attack(currentMonster, 20);
        currentMonster.Attack(player, 6);

        currentMonster.ShowStat();
        player.ShowStat();*/

    }
    public void SpawnMonster(MonsterType monsterType)
    {
        Monster monsterPrefab = monstersPrefabs[(int)monsterType];

        Monster monsterObj = Instantiate(monsterPrefab);

        monsterObj.Init(monsterType);

        monsters.Add(monsterObj);

    }
}
