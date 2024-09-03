using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Declare global variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    
    void LateUpdate()
    {
        // Use the in class given formula which just places the camera a certain distance from the player
        transform.position = player.transform.position + offset;
    }
}
