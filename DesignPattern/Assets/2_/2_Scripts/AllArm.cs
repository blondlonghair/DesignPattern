using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllArm : MonoBehaviour, IArmElement
{
    public string e => "All";
    private List<IArmElement> element;

    public void Awake()
    {
        element = new List<IArmElement>
        {
            GetComponent<Arm1>(),
            GetComponent<Arm2>(),
            GetComponent<Arm3>()
        };
    }

    public void Accept(IArmVisitor visitor)
    {
        foreach (var elem in element)
        {
            elem.Accept(visitor);
        }

        //visitor.Visit(this);
    }
}
