using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer: MonoBehaviour
{
    private CharacterController charController;
    //private CharacterAnimation playerAnimations;
    public float movement_Speed = 3f;
    public float gravity = 9.8f;
    public float rotation_Speed = 0.15f;
    public float rotationDegreesPerSecond = 180f;


    // 1st function that is called
    void Awake()
    {
        charController = GetComponent<CharacterController>();
        //playerAnimations = GetComponent<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();

    }

    // All movements happen with respect to Y-Axis
    void Move()
    {
        /** Just to see ouput of Input.GetAxis("Vertical")
        
        print("The value is " + Input.GetAxis("Vertical")); 

        **/

        // This checks if we have pressed W or up arrow key on keyboard
        // We will use this to move our character forward
        if (Input.GetAxis(Axis.VERTICAL_AXIS) > 0)
        {
            Vector3 moveDirection = transform.forward;
            moveDirection.y -= gravity * Time.deltaTime;

            charController.Move(moveDirection * movement_Speed * Time.deltaTime);

        }
        // This checks if we press S or down key, if we press those key player moves backward
        else if (Input.GetAxis(Axis.VERTICAL_AXIS) < 0)
        {
            Vector3 moveDirection = -transform.forward; // Since there is no function named backward in unity, so we just use - sign
            moveDirection.y -= gravity * Time.deltaTime;

            charController.Move(moveDirection * movement_Speed * Time.deltaTime);
        }
        



    }
    // This function is used to rotate our player
    void Rotate()
    {
        // Vector3.zero is shorthand for writing Vector3(0,0,0)
        Vector3 rotation_Direction = Vector3.zero; // This is the default one

        // Here we are gonna detect the movement
        // If it is lower than zero than we are pressing A key, here we are just following a simple coordinate system
        if (Input.GetAxis(Axis.HORIZONTAL_AXIS) < 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.left); // It will turn our game object to the left side of world space
            // Vector3.left = (-1,0,0)
        }
        // If it is lower than zero than we are pressing D key, here we are just following a simple coordinate system
        if (Input.GetAxis(Axis.HORIZONTAL_AXIS) > 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.right); // It will turn out game object to the right side of the world space
            // // Vector3.right = (1,0,0)
        }

        // Now here we are actually roatating out game object
        // We check that now if rotation is not the default one(Vector3.zero)
        // And that is the reason why everytime we call Rotate() function we are resetting value of rotation_Direction to 0
        // other wise it's value will always remain same once assigned
        if (rotation_Direction != Vector3.zero)
        {
            // So this function basically rotates from initial rotation(transform.rotation) to 
            // rotation_Direction value using Quaternion.LookRotation(rotation_Direction)
            // in the given degrees given by rotateDegreesPerSecond(variable that we declared above)
            // Multiplied by Time.deltaTime so that we can see smooth rotations
            transform.rotation = Quaternion.RotateTowards(
                // transform.rotation gives the initial rotation of our object/player
                // Quaternion.LookRotation(rotation_Direction)
                transform.rotation, Quaternion.LookRotation(rotation_Direction), rotationDegreesPerSecond * Time.deltaTime);

        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Collision Enter");
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log("Collision Exit");
    }
    
}
