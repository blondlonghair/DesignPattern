using UnityEngine;

public class Arm1 : MonoBehaviour, IArmElement
{
    [SerializeField] public GameObject Arm_1;
    public string e = "1";

    public void Accept(IArmVisitor visitor)
    {
        visitor.Visit(this);
        Debug.Log("1");
    }
}
