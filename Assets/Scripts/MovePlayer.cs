using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed = 30.0f;
    public float xRange = 70;
    public float zRange = 25;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Forward");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
       
    }
}
