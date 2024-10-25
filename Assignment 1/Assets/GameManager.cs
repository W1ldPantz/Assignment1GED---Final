using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    // Access GameManager via a public static instance
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // Ensure only one instance of GameManager exists
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    // Ensure GameManager persists between scenes
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Example functionality for resetting the game or player
    public void ResetPlayerPosition(Transform player, Vector3 startPosition)
    {
        player.position = startPosition;
    }
}

