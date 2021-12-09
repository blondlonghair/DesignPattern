using UnityEngine;
using Bridge;

public abstract class IWeaponType
{
    public abstract void Atk();
}

public class BrokenWar : IWeaponType
{
    public override void Atk()
    {
        Debug.Log("브로큰 워");
        TextObject.damage = 200;
        ObjectPooler.instance.Spawn();
    }
}

public class JatKusar : IWeaponType
{
    public override void Atk()
    {
        Debug.Log("젯 쿠사르");
        TextObject.damage = 400;
        ObjectPooler.instance.Spawn();
    }
}

public class Stropha : IWeaponType
{
    public override void Atk()
    {
        Debug.Log("스트로파");
        TextObject.damage = 1000;
        ObjectPooler.instance.Spawn();
    }
}