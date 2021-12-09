using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IEnemy
{
    void Damaged();
}

public class Enemy : MonoBehaviour, IEnemy
{
    [SerializeField] Slider hpBar;
    Player player;

    public void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        player.AddEnemy(this);
    }

    public void Damaged()
    {
        hpBar.value -= 0.2f;
    }
}
