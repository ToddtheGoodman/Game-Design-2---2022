using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    public CharacterController charCon;

    public Vector3 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assign input for x and z 
        moveInput.x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        moveInput.z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        //This moves the player
        charCon.Move(moveInput);

    }
}
