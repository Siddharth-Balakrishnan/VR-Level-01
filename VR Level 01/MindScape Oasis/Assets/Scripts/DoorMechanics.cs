using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanics : MonoBehaviour
{
    public Animator doorAnimator;
    private bool playerInRange = false;

    private void update()
    {
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            OpenDoor();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            CloseDoor();
        }
    }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            CloseDoor();
        }
    }

    private void OpenDoor()
    {
    
        doorAnimator.SetBool("isOpen", true);
    }

    private void CloseDoor()
    {
        doorAnimator.SetBool("isOpen", false);
    }
}