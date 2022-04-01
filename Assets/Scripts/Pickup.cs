using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
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
        if (tag == "Coin" && other.tag == "Player")
        {
            // add +1 to my scoreValue
            UIValues.scoreValue += 1;
            Destroy(gameObject);
        }

        if (tag == "Ammo" && other.tag == "Player")
        {
            // add +1 to my scoreValue
            UIValues.ammoValue += 50;
            Destroy(gameObject);
        }
    }

}
