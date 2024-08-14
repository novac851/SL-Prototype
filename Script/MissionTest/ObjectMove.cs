using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {

        transform.position = target.position;
    }
}