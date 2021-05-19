using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class InputController : MonoBehaviour
{
    // -- SYSTEM -- //

    void Awake()
    {
        player = ReInput.players.GetPlayer(0);
    }

    void FixedUpdate()
    {
        FixedUpdateInputs();
    }

    // -- REWIRED -- //

    Player player;

    // -- INPUTS -- //

    public Vector2 movementInput = Vector2.zero;
    public Vector2 cameraInput = Vector2.zero;

    // -- UPDATE INPUTS -- //

    void FixedUpdateInputs ()
    {
        movementInput = new Vector2(player.GetAxis("Move Horizontal"), player.GetAxis("Move Vertical"));
        cameraInput = new Vector2(player.GetAxis("Camera Horizontal"), player.GetAxis("Camera Vertical"));
    }
}
