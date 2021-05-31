using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance; //Basic singleton
    private Queue<GameObject> pooledObjects; // Queue(Fifo), Stack(Lifo)
    [SerializeField] private GameObject objectPrefab; // desired object to be pooled
    [SerializeField] private int poolSize;//How many object we willing to create

    private void Awake()
    {
        instance = this;
        pooledObjects = new Queue<GameObject>(); //initializing

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab); //instantiate an desired obj
            pooledObjects.Enqueue(obj); // adding instantiated obj to pool
            obj.SetActive(false);
        }
    }

    public GameObject Poolstantiate() //Calls when object needed instantiate from pool ^-^
    {
        GameObject obj;
        if (pooledObjects.Count != 0)
        {
            obj = pooledObjects.Dequeue(); // if there is an object inside pull, get obj
        }
        else
        {
            obj = Instantiate(objectPrefab); //if there is no object inside pull instantiate
        }

        obj.SetActive(true);
        return obj;
    }

    public void Poolstroy(GameObject obj) // Object disappears and goes to pool.like destroy ^-^
    {
        obj.SetActive(false);
        pooledObjects.Enqueue(obj);
    }



}
