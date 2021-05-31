using System.Collections;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private float spawnTime;
    void Start()
    {
        StartCoroutine(SpawnerCo());
    }

    private IEnumerator SpawnerCo()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            GameObject obj = ObjectPool.instance.Poolstantiate();
            obj.transform.position = Vector3.zero;
        }
    }

}
