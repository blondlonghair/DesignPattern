using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operater : MonoBehaviour
{
    [SerializeField] float baseAtkSpeedStats;
    [SerializeField] float baseCriticalStats;

    enum Type { JatKusar, Stropha, BrokenWar }
    Type type = Type.JatKusar;

    IWarframeAbs weapon = new WarframeAbs();
    float time1 = 0;
    float time2 = 2;

    public static Operater instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        weapon.Weapon = GetWeapon();
        Atk();
    }

    void Update()
    {
        weapon.Weapon = GetWeapon();

        if (Input.GetKeyDown(KeyCode.Q)) type = Type.JatKusar;
        if (Input.GetKeyDown(KeyCode.W)) type = Type.Stropha;
        if (Input.GetKeyDown(KeyCode.E)) type = Type.BrokenWar;

        time1 += Time.deltaTime;
        if (time2 <= time1)
        {
            weapon.Atk();
            time1 = 0;
        }
    }


    public void Atk()
    {
        weapon.Atk();
    }

    public IWeaponType GetWeapon()
    {
        if (type == Type.JatKusar)
        {
            return new JatKusar();
        }

        if (type == Type.Stropha)
        {
            return new Stropha();
        }

        if (type == Type.BrokenWar)
        {
            return new BrokenWar();
        }

        else return null;
    }
}
