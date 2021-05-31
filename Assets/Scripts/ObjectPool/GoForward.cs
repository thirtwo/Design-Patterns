using UnityEngine;
using System.Collections;

public class GoForward : MonoBehaviour
{
    [SerializeField] private float speed;

    private void OnEnable()
    {
        StartCoroutine(DestroyCo());
    }
    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));//Basic movement
    }

    private IEnumerator DestroyCo()
    {
        yield return new WaitForSeconds(5f);
        ObjectPool.instance.Poolstroy(gameObject);
    }
}
