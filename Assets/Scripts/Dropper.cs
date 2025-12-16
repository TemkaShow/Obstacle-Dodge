using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    void Start()
    {
        
    }

    void Update()
    {
       if (Time.time > timeToWait)
        {
            Debug.Log("Oh no, lookout below!");
        }
    }
}
