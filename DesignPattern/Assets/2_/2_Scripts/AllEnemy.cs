using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemy : MonoBehaviour
{
    private List<IEnemy> enemies = new List<IEnemy>();

    public void AddEnemy(IEnemy enemy)
    {
        enemies.Add(enemy);
    }

    public void Notify()
    {
        foreach (var enemy in enemies)
        {
            enemy.Damaged();
        }
    }
}
