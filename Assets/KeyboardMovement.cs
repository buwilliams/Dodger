using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    [Range(0.001f, 1)][SerializeField] private float MoveSpeed = 1f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(1 * MoveSpeed, 0, 0);

        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-1 * MoveSpeed, 0, 0);
    }
}
