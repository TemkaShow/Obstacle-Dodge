//using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction() 
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("To move the player use WASD");
    }

    void MovePlayer() 
    {
        float valueX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float valueY = 0f;
        float valueZ = Input.GetAxis("Vertical") * Time.deltaTime* moveSpeed;
        transform.Translate(valueX, valueY, valueZ);
    }
}
