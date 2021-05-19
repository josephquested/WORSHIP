using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // -- SYSTEM -- //

    void Awake()
    {
        ic = GameObject.FindGameObjectWithTag("InputController").GetComponent<InputController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        FixedUpdateMovement();
    }

    // -- INPUT -- //

    InputController ic;

    // -- PHYSICS -- //

    Rigidbody rb;

    public float movementSpeed;

    void FixedUpdateMovement()
    {
        Vector3 force = new Vector3 (ic.movementInput.x, 0, ic.movementInput.y) * movementSpeed;
        rb.AddForce(force);
    }
}
