using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampGravity : MonoBehaviour
{

    [Range(1f, 10)][SerializeField] private float GravityMax = 1f;

    void FixedUpdate()
    {
        Rigidbody2D gravityObject = this.GetComponent<Rigidbody2D>();
        gravityObject.velocity = Vector3.ClampMagnitude(gravityObject.velocity, GravityMax);
    }
}
