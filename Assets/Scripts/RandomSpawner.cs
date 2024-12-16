using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject chicken;
    public GameObject obstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 500;
        while (x > 0)
        {
            Vector3 randomSpawnPosition1 = new Vector3(Random.Range(-6, 7), 0, Random.Range(15, 10000));
            Vector3 randomSpawnPosition2 = new Vector3(Random.Range(-6, 7), 0.75f, Random.Range(15, 10000));
            Instantiate(chicken, randomSpawnPosition1, Quaternion.Euler(0f, 180f, 0f));
            Instantiate(obstacle, randomSpawnPosition2, Quaternion.identity);
            x--;
        }
    }
}
