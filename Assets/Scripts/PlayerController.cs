using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed, sprintSpeed, gravityMod, yStore, jumpPower;    

    public CharacterController charCon;

    public Vector3 moveInput;

    public Vector2 mouseInput;

    public Transform camTransform, groundCheck, weaponPos;

    public bool canJump;

    public LayerMask ground;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get our current Y value
        yStore = moveInput.y;

        // Assigns Vector3 variables to input
        Vector3 forwardMove = transform.forward * Input.GetAxisRaw("Vertical");
        Vector3 horizontalMove = transform.right * Input.GetAxisRaw("Horizontal");
        
        // Defines moveInput
        moveInput = forwardMove + horizontalMove;

        //Fixes the subnautica issue
        moveInput.Normalize();     
        
        
        // to sprint or not to sprint, that is the question
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveInput = moveInput * sprintSpeed;           
        }
        else
        {
            moveInput = moveInput * moveSpeed;
        }        

        //Gravity
        moveInput.y = yStore;
        moveInput.y += Physics.gravity.y * gravityMod * Time.deltaTime;

        if (charCon.isGrounded)
        {
            moveInput.y = Physics.gravity.y * gravityMod;
        }

        //Check to see if you are on the ground
        canJump = Physics.OverlapSphere(groundCheck.position, 0.25f, ground).Length > 0;

        //Jump
        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            moveInput.y = jumpPower;
        }

        //This moves the player
        charCon.Move(moveInput * Time.deltaTime);

        Shooting();
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

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectile, weaponPos.position, weaponPos.rotation);
        }
    }

}
