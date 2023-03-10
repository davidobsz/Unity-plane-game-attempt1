using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 offset = new Vector3(5, 2, -0);
    public Transform player;
    public float speed = 5f;
    public float distance = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame, LateUpdate makes camera less jittery because it updates AFTER the vehicle moves.
    void LateUpdate()
    {
        // Get the cameras current transform position and make it == the GameObject player which is referencing the Vehicle position.
        //transform.position = player.transform.position;

        // Offset the cameras position by adding players position
        //transform.position = player.transform.position + offset;  <-- works but no roatation


        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), speed * Time.deltaTime);

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), speed * Time.deltaTime);

        // Move the object towards the player
        //transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        transform.position = player.position + offset;

        // Look at the target
        transform.LookAt(player);
    }
}
