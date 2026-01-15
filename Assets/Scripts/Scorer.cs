using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
           
            Debug.Log("You've bumped into a thing this many times: " + hits);
            hits++;
            
        }
        
    }
}
