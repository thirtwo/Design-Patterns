using UnityEngine;

public class RandomColorChanger : MonoBehaviour
{
  
    private Material material;
    
    void Start()
    {
        material = GetComponent<Renderer>().material;
        ObserverManager.OnClickButton += ChangeRandomColor;
    }


    void ChangeRandomColor()
    {
        material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void OnDestroy()
    {
        ObserverManager.OnClickButton -= ChangeRandomColor;
    }
}
