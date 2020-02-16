using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float Rotation_Speed;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * Rotation_Speed * Time.fixedDeltaTime);
    }
}
