using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    Movement movement;
    Context ctx;

    void Start()
    {
        movement = GetComponent<Movement>();
        ctx = new Context();
    }

    public void OnTurnRight()
    {
        print("Onturnright");
        ctx.RightOperation(movement);
    }

    public void OnTurnLeft()
    {
        print("Onturnright");
        ctx.LeftOperation(movement);
    }

    public void OnMove1Grid()
    {
        print("Onturnright");
        ctx.Grid1Operation(movement);
    }

    public void OnMove2Grid()
    {
        print("Onturnright");
        ctx.Grid2Operation(movement);
    }

    public void StartCommand()
    {
        print("OnstartCommand");
        movement.ExcuteAll();
    }
}
