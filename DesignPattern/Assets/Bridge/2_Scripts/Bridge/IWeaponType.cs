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
        Debug.Log("���ū ��");
        TextObject.damage = 200;
        ObjectPooler.instance.Spawn();
    }
}

public class JatKusar : IWeaponType
{
    public override void Atk()
    {
        Debug.Log("�� ��縣");
        TextObject.damage = 400;
        ObjectPooler.instance.Spawn();
    }
}

public class Stropha : IWeaponType
{
    public override void Atk()
    {
        Debug.Log("��Ʈ����");
        TextObject.damage = 1000;
        ObjectPooler.instance.Spawn();
    }
}