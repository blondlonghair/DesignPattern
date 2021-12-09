using UnityEngine;

public class Arm2 : MonoBehaviour, IArmElement
{
    [SerializeField] public GameObject Arm_2;
    public string e = "2";

    public void Accept(IArmVisitor visitor)
    {
        visitor.Visit(this);
        Debug.Log("2");
    }
}
