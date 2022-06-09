using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {        
        // Ambil Input
        if(Input.GetKey(upKey))
        {
            // Gerakan object ke atas dengan input
           return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey))
        {
            // Gerakan object ke bawah dengan input
           return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rb.velocity = movement;
    }
}
