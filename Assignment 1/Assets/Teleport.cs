using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerTeleport : MonoBehaviour
{

    public Transform[] towerPoints;                                                                                            
    public Transform startPoint;
    private int currentTeleportIndex = 0;                                                                                       
    private Rigidbody rb;

    // AI HELPED CREATE THIS PIECE OF CODE ABOVE
    // Before the code only supported one tower, AI showed how to add more towers using the inspector
    



    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.position = startPoint.position;

        // AI HELPED CREATE THIS PIECE OF CODE ABOVE
        // This was used to add physics and collisions to both the player and the towers

    }

    void Update()
    {
        // Teleport to the next block when 'E' is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            TeleportToNextBlock();
        }

        // Teleport back to the starting point when 'Q' is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameManager.Instance.ResetPlayerPosition(transform, startPoint.position);                                                           
            ReturnToStart();
        }
    }

    void TeleportToNextBlock()
    {
        rb.position = towerPoints[currentTeleportIndex].position;
        currentTeleportIndex = (currentTeleportIndex + 1);

        // AI HELPED CREATE THIS PIECE OF CODE ABOVE
        // I didnt know how to create the teleportation mechanic
        // So I used AI to help create the entire thing
        // I changed the code to stop the endless teleportation of the player
        // When the player reaches the final tower, they have to press "Q" in order to go back to the biginning
    }

    void ReturnToStart()
    {
        rb.position = startPoint.position;
        currentTeleportIndex = 0;
    }
}


// The singleton manages the state of the game and resetting the player
// The command pattern encapsulates the teleportation
// The observer notofies the game when the "E" and "Q" buttons are pressed
// The factory pattern make teleportation points easier to create and set


