using UnityEngine;
using System.Collections;

public class JumpScareTrigger : MonoBehaviour
{
     [SerializeField]
     GameObject jumpScareObject; 
     
     [SerializeField]
     float jumpScareDuration = 3f; 
    
    [SerializeField]
    float destroyDelay = 5f; 

     [SerializeField]
     private bool triggered = false;
     
     private void Awake() 
     {
        jumpScareObject.SetActive(false);  
     }

    void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.CompareTag("Player"))
        {
            triggered = true;
            StartCoroutine(DoJumpScare());
        }
    }

    IEnumerator DoJumpScare()
    {


        if (jumpScareObject != null)
        {
            jumpScareObject.SetActive(true); 
            yield return new WaitForSeconds(jumpScareDuration);
            jumpScareObject.SetActive(false); 
        }

        yield return new WaitForSeconds(destroyDelay);
        Destroy(gameObject);
    }
}
