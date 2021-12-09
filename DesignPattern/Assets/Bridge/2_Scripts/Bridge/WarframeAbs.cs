using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarframeAbs : IWarframeAbs
{
    //public IWarframeType Warframe { get; set; }
    public IWeaponType Weapon { get; set; }

    public void Atk()
    {
        this.Weapon.Atk();
    }
}
