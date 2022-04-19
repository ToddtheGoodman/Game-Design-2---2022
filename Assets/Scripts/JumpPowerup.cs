using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{

    public MeshRenderer meshRend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(jumpPower());
        }
    }

    IEnumerator jumpPower()
    {
        //turn off Mesh Renderer
        meshRend.enabled = false;
        //make me jump higher
        GameObject.Find("Player").GetComponent<PlayerController>().jumpPower = 14;
        //wait 5 seconds
        yield return new WaitForSeconds(5);
        //go back to regular jump
        GameObject.Find("Player").GetComponent<PlayerController>().jumpPower = 7;
        //destroy powerup
        Destroy(gameObject);
    }

}
