using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;

    private string text; // I could have code like string text {get; private set;}

    private Singleton() //Private Constructor. It prevents create another instance.
    {
        instance = null;
        text = "Hello Github";
    }

    public static Singleton Instance // property for Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("Singleton").AddComponent<Singleton>(); //if this script not exist, we will create it.
            }
            return instance;
        }
    }

    private void OnEnable()
    {
        instance = this; // if this script inside of an object it will not return null.
    }

    public string GetText()
    {
        return text;
    }

}
