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
        //----------------Spawn Slime----------------
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


        /*currentMonster = Instantiate<>*/
        /*//Create New Avatar
        Player Player1 = new Player("Samton", 100, 0, 15);

        //Create Monster
        Monster monster1 = new Monster("Slime", 10, 2, 5, false);
        Monster monster2 = new Monster("Hollow Shulker", 25, 10, 20, false);
        Monster monster3 = new Monster("Hollow Shulker", 25, 10, 20, false);

        monsters.Add(monster1);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monster("Stray Dog", 15, 10, 10, false));

        //Show Player Stat
        Player1.ShowStat();

        //Show Monster Stat
        foreach (var m in monsters)
        {
            m.ShowStat();
        }
        
        //Take Damage Test
        Player1.TakeDamage(25);
        Debug.Log($"Player Name: {Player1.PlayerName} | Health: {Player1.Health} | Gold: {Player1.Gold}");
        Debug.Log($"Hero is alive: {Player1.IsAlive()} ");

        //Player Attack Monster
        monster1.ShowStat();

        Player1.Attack(monster1);

        monster1.ShowStat();

        //Monster Attack Player
        Player1.ShowStat();

        monster1.Attack(Player1);

        Player1.ShowStat();*/

    }
}
