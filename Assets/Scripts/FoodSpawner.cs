using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public GameObject basketPrefab;
    public float spawnRadius = 5f;
    public float basketSpawnRadius=5f;
    public int foodCount = 5;
    void Start()
    {
        for(int i = 0; i < foodCount; i++)
        {
            GameObject randomFood = foodPrefabs[Random.Range(0,foodPrefabs.Length)];
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            spawnPosition.y = 0;
            Instantiate(randomFood, spawnPosition, Quaternion.identity);

        }           
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
