using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    private BoxCollider doorCollider;

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player or any other object you want to trigger the door with
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger is the player or any other object you want to trigger the door with
        if (other.CompareTag("Player"))
        {
            CloseDoor();
        }
    }

    private void OpenDoor()
    {
        // Open the door by disabling its collider
        doorCollider.enabled = false;
        isOpen = true;
        Debug.Log("Door opened");
    }

    private void CloseDoor()
    {
        // Close the door by enabling its collider
        doorCollider.enabled = true;
        isOpen = false;
        Debug.Log("Door closed");
    }
}
