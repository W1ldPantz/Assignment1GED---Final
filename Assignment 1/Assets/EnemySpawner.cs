using UnityEngine;

public class EnemySpawnerSpawner : MonoBehaviour
{
    public GameObject circlePrefab; 
    public Transform[] pathWaypoints; 
    public float spawnInterval = 2f; 

    private void Start()
    {
        InvokeRepeating("SpawnCircle", 0f, spawnInterval);
    }

    void SpawnCircle()
    {
        GameObject newCircle = Instantiate(circlePrefab, transform.position, Quaternion.identity);

       
        EnemyMovement circleMovement = newCircle.GetComponent<EnemyMovement>();
        if (circleMovement != null)
        {
            circleMovement.waypoints = pathWaypoints;
        }
    }
}
