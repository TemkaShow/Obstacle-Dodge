using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] float xRotate = 0f;
    [SerializeField] float yRotate = 0.8f;
    [SerializeField] float zRotate = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
        
        
    }
}
