using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints; 
    public float speed = 2f; 

    private int currentWaypointIndex = 0; 

    void Update()
    {
        if (waypoints.Length == 0) return;

        
        Transform target = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                
                currentWaypointIndex = 0;
            }
        }
    }
}
