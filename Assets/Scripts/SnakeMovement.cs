using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 200f;

    float velx = 0f;
    float helx = 0f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        velx = Input.GetAxis("Horizontal");
        // helx = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // for move
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        // for rotate
        transform.Rotate(Vector3.forward * -velx * rotationSpeed * Time.fixedDeltaTime);
        // transform.Rotate(Vector3.forward * helx * rotationSpeed * Time.fixedDeltaTime);

    }
}

