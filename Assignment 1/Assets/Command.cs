using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public interface ICommand
    {
        void Execute();
    }
    public class TeleportCommand : ICommand
    {
        private Transform player;
        private Vector3 targetPosition;

        public TeleportCommand(Transform player, Vector3 targetPosition)
        {
            this.player = player;
            this.targetPosition = targetPosition;
        }

        public void Execute()
        {
            player.position = targetPosition;
        }
    }

}
