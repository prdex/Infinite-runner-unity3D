using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    private CharacterController controller;
    private float speed = 5.0f;
    private float gravity = 12.0f;
    private float movement = 12.0f;
    private Vector3 moveVect;
	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();

	}

    // Update is called once per frame
    void Update()
    {
        moveVect = Vector3.zero;
        moveVect.x = Input.GetAxisRaw("Horizontal")*movement;
        moveVect.y = Input.GetAxisRaw("Vertical")*gravity;
        moveVect.z = speed;
        controller.Move(moveVect * Time.deltaTime);

    }
}
