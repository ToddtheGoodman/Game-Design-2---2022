using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello this a a variable test");
        
        //print("You are diving under the sea, looking for the elusive SeaCat...");
        //print("Do you want to swim by the reef? Is so press the Q key");
        //print("Do you want to explore the sunken ship? Press the W key");
    }

    // Update is called once per frame
    void Update()
    {
        // First option for our game, if you press the Q key
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Oh no! There is a black-tipped reef shark.");
            print("Do you want to swim away? Press the E key");
            print("Go up and pet the shark. Press the R key");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("you die...");
        }
    }
}
