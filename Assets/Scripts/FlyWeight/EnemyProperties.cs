using UnityEngine;

[CreateAssetMenu(fileName = "EnemyProperties", menuName = "Enemy/EnemyProperties")]
public class EnemyProperties : ScriptableObject
{
    [SerializeField] private float enemySpeed;
    [SerializeField] private float enemyMaxHealth;
    [SerializeField] private Color enemyColor;

    public float EnemySpeed //Encapsulation enemySpeed
    {
        get
        {
            return enemySpeed;
        }
    }
}
