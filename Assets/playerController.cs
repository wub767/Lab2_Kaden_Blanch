using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //variables
    private Rigidbody rb;
    [SerializeField]
    private float xspeed = 5.0f;
    [SerializeField]
    private float zspeed = 5.0f;


    //movement numbers
    public float horizontalInput;
    public float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalInput * xspeed, 0 ,  verticalInput * zspeed);

    }
}
