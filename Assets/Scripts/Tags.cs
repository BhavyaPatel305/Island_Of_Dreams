using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is class is used for verical and horizontal movement(PlayerMove.cs)
public class Axis
{
    // defining constant variable names so that we don't have to write Vertical and Horizontal everywhere
    // and make it more nice and manageble
    public const string VERTICAL_AXIS = "Vertical";
    public const string HORIZONTAL_AXIS = "Horizontal";
}

// This class is used for camera movement (CameraFollow)
public class Tags
{
    public const string PLAYER_TAG = "Player";
}

// This is for CharacterAnimation file for animations

public class AnimationTags
{
    public const string WALK_PARAMETER = "Walk";
    public const string DEFEND_PARAMETER = "Defend";
    public const string ATTACK_TRIGGER_1 = "Attack1";
    public const string ATTACK_TRIGGER_2 = "Attack2";
}
