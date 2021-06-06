using System.Collections;
public abstract class Command
{
    public abstract IEnumerator ExecuterCo();
    public bool isCommandFinished = false;
}
