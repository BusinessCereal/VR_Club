using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Movement : MonoBehaviour
{

    public float speed = 6.0f;
    public float jumpspeed = 8.0f;

    public float gravity = 20f;

    private float mouseinputx, mouseinputy;
    private Vector3 moveDirection = Vector3.zero;

    private CharacterController controller;
        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();

        }

        // Update is called once per frame
        void Update()
        {
            mouseinputx = Input.GetAxis("Mouse X");
            mouseinputy = Input.GetAxis("Mouse Y");
            Vector3 look = new Vector3(mouseinputy,mouseinputx,0);
            transform.Rotate(look);
            
            if (controller.isGrounded) {
                
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection((moveDirection));
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpspeed;
            }
            }

            moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

            controller.Move(moveDirection * Time.deltaTime);
        }
}