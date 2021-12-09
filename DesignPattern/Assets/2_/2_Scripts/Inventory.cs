using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    public enum Type
    {
        Use,
        Equip,
        Own,
        Main
    }

    public string name;
    public Type type;

    public abstract void Operate();

    public Item(string name, Type type)
    {
        this.name = name;
        this.type = type;
    }
}

public class ItemBag : Item
{
    private List<Item> itemList = new List<Item>();

    public ItemBag(string name, Type type = Type.Use) : base(name, type)
    {

    }

    public override void Operate()
    {
        OpenSlotWindow();
    }

    //������ �κ��丮 â�� ���� ����Լ�. �� ���������� ���θ� �������� �ʰڴ�.
    private void OpenSlotWindow()
    {

    }

    //���濡 ������ ������ ����ϴ� �Լ�
    public void Add(Item item)
    {
        if (itemList.Contains(item))
        {
            Debug.Log(" ���� : �̹� �ش� �������� ����Ʈ�� ������.");
            return;
        }
        itemList.Add(item);
    }

    //���濡�� ������ ���� ����ϴ� �Լ�
    public void Remove(Item item)
    {
        if (!itemList.Contains(item))
        {
            Debug.Log("���� : �ش� �������� ����Ʈ�� �������� ����.");
            return;
        }
        itemList.Remove(item);
    }
}

public class ItemLeaf : Item
{
    //������
    public ItemLeaf(string name, Type type) : base(name, type)
    {

    }

    public override void Operate()
    {

    }
}

//�߰� ����. ������ �����Ҵ�.
public class Potion : ItemLeaf
{
    public Potion(string name, Type type) : base(name, type)
    {

    }

    //�� �������̵� ���ش�. �׷� ItemLeaf�� Operate�Լ��� ������� ���� ���̴�.
    public override void Operate()
    {
        UsePotion();
    }

    //ü���� ä���, ���� ������ 1 ���ҽ����ִ� ����� �Լ����ο� ������ָ� �� ���̴�.
    private void UsePotion()
    {

    }
}

public class Inventory : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
}
