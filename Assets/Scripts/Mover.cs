using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float movespeed = 10f;
    
     void Start()
    {
      PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }
void PrintInstruction()
{
    Debug.Log("Welcome to the game!");
    Debug.Log("Move using arrow keys or wasd");
    Debug.Log("Don't bump into objects!");
}

void MovePlayer()
{
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xValue, yValue, zValue);
}
}