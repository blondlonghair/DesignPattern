using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IArmElement
{
    void Accept(IArmVisitor visitor);
}


public interface IArmVisitor
{
    void Visit(Arm1 element);
    void Visit(Arm2 element);
    void Visit(Arm3 element);
    //void Visit(AllArm allArm);
}

public class Player : MonoBehaviour
{
    private List<IEnemy> enemies = new List<IEnemy>();

    void Start()
    {
    }

    void Update()
    {
        IArmElement player = GetComponent<AllArm>();
        IArmVisitor visitor = GetComponent<ArmVisitor>();
        player.Accept(visitor);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.LogWarning("fds");

            Notify();
        }
    }

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
