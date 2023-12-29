using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefab;

    void Start()
    {
        for (int i = 0; i < 3; i++) 
        {
            Instantiate(enemyPrefab, new Vector3(i *1.85f, 0, 0), Quaternion.identity);
        }
    }
}
