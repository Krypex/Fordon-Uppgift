using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipscript : MonoBehaviour {
    [Range(-720, 720)]
    public float rotationSpeed;

    
    public Transform other;

    // Use this for initialization
    void Start () {
        



    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);

        }
        transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);









    }
}
