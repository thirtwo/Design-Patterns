using UnityEngine;

public class MultiUseSingleton<T> : MonoBehaviour where T : MultiUseSingleton<T>
{
    private static volatile T instance = null;
    private string text;
    public static T MultiInstance //property for T 
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
    }
    private void OnEnable()
    {
        instance = this as T;
        text = "I am learning Singleton";
    }

    public string GetText()
    {
        return text;
    }
}
