using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamers : MonoBehaviour
{
    [SerializeField]
    GameObject thingToFollow;

    float zAmount = -5;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, zAmount);
    }
}
