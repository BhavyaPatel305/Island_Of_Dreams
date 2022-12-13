using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public bool isGrounded;

    public GameObject ground;

    private Vector2 turn;

    Rigidbody rb;

    void Start()
    {   
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 5 * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }


        if(isGrounded && Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(new Vector3(0, 5f, 0) , ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ground)
        {
            isGrounded = true;
        }
    }
    
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == ground)
        {
            isGrounded = false;
        }
    }
}
