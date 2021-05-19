using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // -- SYSTEM -- //

    void Awake()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        positionOffset = transform.position;
        rotationOffset = transform.eulerAngles;
    }

    void Update()
    {
        UpdatePosition();
        UpdateRotation();
    }

    // -- CAMERA CONTROL -- // 

    Transform playerTrans;

    public Vector3 positionOffset;
    public Vector3 rotationOffset;

    void UpdatePosition()
    {
        transform.position = playerTrans.position + positionOffset;
    }

    void UpdateRotation ()
    {

    }
}
