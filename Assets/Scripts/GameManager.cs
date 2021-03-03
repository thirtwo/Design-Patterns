using UnityEngine;

public class GameManager : MultiUseSingleton<GameManager>
{

    void Start()
    {
        Debug.Log(Singleton.Instance.GetText());
        Debug.Log(MultiInstance.GetText());
    }

    void Update()
    {

    }
}
