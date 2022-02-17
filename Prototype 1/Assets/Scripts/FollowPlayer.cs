//Emily Padavick, FollowPlayer, 2.17.2022, instructs any camera to follow the designated vehicle as it moves

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    //etablish variables
    public GameObject player;
    public Vector3 offset = new Vector3(0, 4.5f, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //the camera follows the vehicle from a certain position
        transform.position = player.transform.position + offset;

    }
}
