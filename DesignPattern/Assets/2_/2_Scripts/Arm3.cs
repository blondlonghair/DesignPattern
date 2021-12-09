using UnityEngine;

public class Arm3 : MonoBehaviour, IArmElement
{
    [SerializeField] public GameObject Arm_3;
    public string e = "3";

    public void Accept(IArmVisitor visitor)
    {
        visitor.Visit(this);
        print("3");
    }
}
