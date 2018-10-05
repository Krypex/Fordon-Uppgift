using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoronShip : MonoBehaviour {
    public SpriteRenderer rend;
    public Color newcolor;
    bool Blue;
    bool Green;
	// Use this for initialization
	void Start () {
        Blue = false;
        Green = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Blue = true;

            if (Blue == true)
            {
                newcolor = rend.color = new Color(0, 0, 1);

            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            Green = true;

            if (Green == true)
            {
                newcolor = rend.color = new Color(0, 1, 0);

            }

        }
    }
}
