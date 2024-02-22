using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Enemy enemy;
    Player player;
    void Start()
    {
        enemy = new Enemy("Voldemort");
        player = new Player("Harry Potter");
    }


    void Update()
    {
        Debug.Log("Nombre: " + enemy.name + ". Vida: " + enemy.getHealthPoints());
        Debug.Log("Nombre: " + player.name + ". Vida: " + player.getHealthPoints());
    }
}
