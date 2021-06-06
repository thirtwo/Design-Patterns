using UnityEngine;
using System.Collections;
public class MoveCommand : Command
{
    private Vector3 _destination;
    private Transform _movingObject;
    public MoveCommand(Vector3 destination, Transform movingObject)
    {
        _destination = destination;
        _movingObject = movingObject;
    }

    public override IEnumerator ExecuterCo()
    {
        while (!isCommandFinished)
        {
            if (Vector3.Distance(_movingObject.position, _destination) > 0.15f)
                _movingObject.position = Vector3.Lerp(_movingObject.position, _destination, 0.005f);
            else
                isCommandFinished = true;
            yield return null;
        }
    }
}

