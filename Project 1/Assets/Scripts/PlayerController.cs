using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Variables
    private float speed = 22.0f;
    private float turnSpeed = 19.0f;
    private float horizontalInput;
    private float forwardInput;


    public string inputID;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // move vechile forword
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotate vechinle
        transform.Rotate(Vector3.up , Time.deltaTime * turnSpeed * horizontalInput);
    }
}
