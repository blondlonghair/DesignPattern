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

    //가방의 인벤토리 창을 여는 멤버함수. 본 예제에서는 내부를 정의하진 않겠다.
    private void OpenSlotWindow()
    {

    }

    //가방에 아이템 넣을때 사용하는 함수
    public void Add(Item item)
    {
        if (itemList.Contains(item))
        {
            Debug.Log(" 버그 : 이미 해당 아이템이 리스트에 존재함.");
            return;
        }
        itemList.Add(item);
    }

    //가방에서 아이템 뺄때 사용하는 함수
    public void Remove(Item item)
    {
        if (!itemList.Contains(item))
        {
            Debug.Log("버그 : 해당 아이템이 리스트에 존재하지 않음.");
            return;
        }
        itemList.Remove(item);
    }
}

public class ItemLeaf : Item
{
    //생성자
    public ItemLeaf(string name, Type type) : base(name, type)
    {

    }

    public override void Operate()
    {

    }
}

//추가 예시. 물약을 만들어보았다.
public class Potion : ItemLeaf
{
    public Potion(string name, Type type) : base(name, type)
    {

    }

    //또 오버라이딩 해준다. 그럼 ItemLeaf의 Operate함수는 실행되지 않을 것이다.
    public override void Operate()
    {
        UsePotion();
    }

    //체력을 채우고, 물약 갯수를 1 감소시켜주는 기능을 함수내부에 만들어주면 될 것이다.
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
