using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyProperties enemyProperties;

    private void Update()
    {
        transform.Translate(Vector3.forward * (enemyProperties.EnemySpeed * Time.deltaTime)); //Flyweighting enemySpeed if we have more than one EnemyController.cs
        //Gaining data space
    }
}
