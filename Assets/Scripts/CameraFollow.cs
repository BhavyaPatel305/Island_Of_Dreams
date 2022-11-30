using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    // The reason why we write this [] is because we want offset to be private so that it is not 
    // accessible by other class but we also wnat to see this variable offset in our inspector window
    // so in order to do that we write this [] with the declaration of variable offset
    [SerializeField]
    private Vector3 offsetPosition;
    // Start is called before the first frame update
    void Awake()
    {
        // We are getting all the transform properties of the 
        // object named "Player" and storing it in variable named target
        target = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
        // Now for this to work we need to have tag attached to the player in the tags field and if not then add it
        // by clicking on the player and then in inspector window there is an option for tags, over there select Player
        // IMP: If name of tag you are selecting is PLayer then in Tags class, you need to write same thing for PLAYER_TAG variable     
    }

    void Update()
    {
        if (Input.GetKey("z"))
        {
            offsetPosition = new Vector3(0, 2, -2);
        }
        if (Input.GetKey("x"))
        {
            offsetPosition = new Vector3(0, 2, 0);
        }
    }

    // Update is called once per frame
    // Update function is called for every frame in a second, so if we have 60 frames per second than it will be called 60 times in a second
    // fixedupdate() on the other hand is called at every fixed interval of time like every 3rd or 4th frame
    // LateUpdate() is immediately called after update() finishes it's task
    // Bcoz we already know poition of the player(as we are calling Move() and Rotate() function in update() fuhnction in PlayerMove Script
    // so we can follow him smoothly
    void LateUpdate()
    {
        FollowPlayer();
    }

    // So that one player can automatically identify another player and follow it
    void FollowPlayer()
    {

        

        // this transform.position is the position for camera
        // So what happens here is target is the current position of the player, so this TransformPoint changes the position of 
        // the player to the world position
        transform.position = target.TransformPoint(offsetPosition); // This transforms camera position from local space to world space
        // Where target is the poition of the player
        // so by calling FollowPlayer() we are setting poisition of camera same as that of the player, so in that ways it keeps 
        // following player after each update() since LateUpdate() is called after Update() function



        // That was just for change in position, but we have still not done anything for player rotation
        // which means that if we rotate the player the camera would not follow it
        // So to fix that we do this

        transform.rotation = target.rotation;

    }
}
