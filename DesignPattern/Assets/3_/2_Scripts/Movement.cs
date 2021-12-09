using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

#region Command_Pattern
public class Movement : MonoBehaviour
{
    private List<ACommand> commands = new List<ACommand>();
    //ACommand[] com = new ACommand[4];

    public void AddCommand(ACommand command)
    {
        //for (int i = 0; i < com.Length; i++)
        //{
        //    if (com[i] != null)
        //    {
        //        com[i] = command;
        //        commands.Add(com[i]);
        //    }
        //}

        commands.Add(command);
        print("AddCommand");
    }

    public void RemoveCommand(ACommand command)
    {
        commands.RemoveAt(commands.FindIndex(x => x.Equals(command)));
        print("RemoveCommand");
    }

    public void ExcuteAll()
    {
        print("ExcuteAll");
        StartCoroutine(waitTime());
    }

    IEnumerator waitTime()
    {
        foreach (var item in commands)
        {
            item.SetPlayer(gameObject);
            item.Execute();
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void Update()
    {
        print(commands);
    }
}

public abstract class ACommand
{
    protected GameObject player;
    public void SetPlayer(GameObject _player)
    {
        player = _player;
    }
    public abstract void Execute();
}

class MoveGrid : ACommand
{
    float grid;

    public MoveGrid(int _grid)
    {
        grid = _grid;
    }

    public override void Execute()
    {
        player.transform.Translate(0, grid, 0);
    }
}

enum Type { left = 1, right = 2 }

class TurnRotation : ACommand
{
    Type type;

    public TurnRotation(Type _type)
    {
        type = _type;
    }

    public override void Execute()
    {
        if (type == Type.left)
        {
            player.transform.Rotate(0, 0, -90);
        }

        else if (type == Type.right)
        {
            player.transform.Rotate(0, 0, 90);
        }
    }
}
#endregion

#region State_Pattern
public class Context
{
    public IState Grid1State { get; set; }
    public IState Grid2State { get; set; }
    public IState TurnRightState { get; set; }
    public IState TurnLeftState { get; set; }

    public Context()
    {
        this.TurnRightState = new OnTurnRight();
        this.TurnLeftState = new OnTurnLeft();
        this.Grid1State = new OnGrid1();
        this.Grid2State = new OnGrid2();
    }

    public void RightOperation(Movement movement)
    {
        this.TurnRightState.Operation(this, movement);
    }

    public void LeftOperation(Movement movement)
    {
        this.TurnLeftState.Operation(this, movement);
    }

    public void Grid1Operation(Movement movement)
    {
        this.Grid1State.Operation(this, movement);
    }

    public void Grid2Operation(Movement movement)
    {
        this.Grid2State.Operation(this, movement);
    }
}

public interface IState
{
    public void Operation(Context ctx, Movement movement);
}

public class OnTurnRight : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.AddCommand(new TurnRotation(Type.right));

        context.TurnRightState = new OffTurnRight();
    }
}

public class OffTurnRight : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.RemoveCommand(new TurnRotation(Type.right));

        context.TurnRightState = new OnTurnRight();
    }
}

public class OnTurnLeft : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.AddCommand(new TurnRotation(Type.left));

        context.TurnLeftState = new OffTurnRight();
    }
}

public class OffTurnLeft : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.RemoveCommand(new TurnRotation(Type.left));

        context.TurnLeftState = new OnTurnRight();
    }
}

public class OnGrid1 : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.AddCommand(new MoveGrid(1));

        context.Grid1State = new OffTurnRight();
    }
}

public class OffGrid1 : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.RemoveCommand(new MoveGrid(1));

        context.Grid1State = new OnTurnRight();
    }
}

public class OnGrid2 : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.AddCommand(new MoveGrid(2));

        context.Grid2State = new OffTurnRight();
    }
}

public class OffGrid2 : IState
{
    public void Operation(Context context, Movement movement)
    {
        movement.RemoveCommand(new MoveGrid(2));

        context.Grid2State = new OnTurnRight();
    }
}
#endregion
