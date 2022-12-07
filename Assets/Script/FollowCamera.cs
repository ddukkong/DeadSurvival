using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

   
    private void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10f);
    }
}
