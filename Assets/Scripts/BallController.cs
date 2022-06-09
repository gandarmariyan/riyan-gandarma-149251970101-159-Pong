using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        
        // transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
        // transform.Translate(speed * Time.deltaTime);
    }
}
