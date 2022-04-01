using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIValues : MonoBehaviour
{

    public Text score;
    public Text ammo;
    public static int scoreValue;
    public static int ammoValue;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: ";
        ammo.text = "Ammo: ";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
        ammo.text = "Ammo: " + ammoValue;
    }
}
