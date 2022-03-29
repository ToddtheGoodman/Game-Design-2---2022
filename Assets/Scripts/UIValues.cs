using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIValues : MonoBehaviour
{

    public Text score;
    public static int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
