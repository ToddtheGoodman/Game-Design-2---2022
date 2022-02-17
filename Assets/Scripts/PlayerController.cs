using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float sprintSpeed;

    public CharacterController charCon;

    public Vector3 moveInput;

    public Vector2 mouseInput;

    public Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardMove = transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontalMove = transform.right * Input.GetAxis("Horizontal");
        
        // Defines moveInput
        moveInput = forwardMove + horizontalMove;

        //Fixes the subnautica issue
        moveInput.Normalize();

        // Allow us to change speed and slow down for Tim
        moveInput = moveInput * Time.deltaTime * moveSpeed;
        //moveInput *= Time.deltaTime * moveSpeed;
        
        // Sprint
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
         //   moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * sprintSpeed;
         //   moveInput = Input.GetAxis("Vertical") * Time.deltaTime * sprintSpeed;
        //}
        
        //This moves the player
        charCon.Move(moveInput);

        CameraMovement();

    }

    void CameraMovement()
    {
        //Assign input for X and Y on the Mouse
        mouseInput.x = Input.GetAxisRaw("Mouse X");
        mouseInput.y = Input.GetAxisRaw("Mouse Y");

        //stupid 4th dimensions
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);
        camTransform.rotation = Quaternion.Euler(camTransform.rotation.eulerAngles.x + -mouseInput.y, camTransform.rotation.eulerAngles.y, camTransform.rotation.eulerAngles.z);

    }


}
