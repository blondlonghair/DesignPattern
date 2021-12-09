using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmVisitor : MonoBehaviour, IArmVisitor
{
    public void Visit(Arm1 element)
    {
        element.Arm_1.transform.Rotate(0, 0, 5);
        Debug.Log(element.e);
    }

    public void Visit(Arm2 element)
    {
        element.Arm_2.transform.Rotate(0, 0, 10);
        Debug.Log(element.e);
    }

    public void Visit(Arm3 element)
    {
        element.Arm_3.transform.Rotate(0, 0, 15);
        Debug.Log(element.e);
    }

    //public void Visit(AllArm element)
    //{
    //    Debug.Log(element.e);
    //    Debug.Log("dltl dklafj;dslka;jf");
    //}
}
