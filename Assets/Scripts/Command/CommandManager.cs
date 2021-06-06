using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CommandManager : MonoBehaviour
{

    public Queue<MoveCommand> _moveCommands = new Queue<MoveCommand>();
    private MoveCommand currentMoveCommand = null;


    private void Update()
    {
        ListenforCommands();
        ExecuteCommands();
    }

    private void ExecuteCommands()
    {
        if(currentMoveCommand != null && currentMoveCommand.isCommandFinished == false)
        {
            return;
        }
        if(_moveCommands.Any() == false)
        {
            return;
        }
        currentMoveCommand = _moveCommands.Dequeue();
        StartCoroutine(currentMoveCommand.ExecuterCo());
    }
    private void ListenforCommands()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hitInfo))
            {
                MoveCommand moveCommand = new MoveCommand(hitInfo.point,transform);
                _moveCommands.Enqueue(moveCommand);
            }
        }
             
    }
}
