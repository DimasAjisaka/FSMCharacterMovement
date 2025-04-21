using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public float _runSpeed = 40f;
    float _moveHorizontalCharacter = 0f;

    void Update() {
        _moveHorizontalCharacter = Input.GetAxisRaw("Horizontal") * _runSpeed;
    }

    void FixedUpdate() {
       //move character
       controller.Move(_moveHorizontalCharacter * Time.fixedDeltaTime, false, false);
    }
}
