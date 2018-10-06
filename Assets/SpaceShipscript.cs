using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipscript : MonoBehaviour {
    [Range(-720, 720)]
    public float rotationSpeed;
    public bool halfspeed;
   public Transform other;
    public float Timer;
    private float variabel = 1;
   
    // Use this for initialization
    void Start () {
        halfspeed = false;
        


    }
	
	// Update is called once per frame
	void Update () {
        // Objektet åker fram
        transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);

        // Svänger höger
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            
        }
        // Svänger Vänster
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);

        }
       
        // Åker långsammare när man trycker ner S tangenten
        if (Input.GetKey(KeyCode.S))
        {
            halfspeed = true;

            if (halfspeed == true)
            {
                transform.Translate(-2.5f * Time.deltaTime, 0, 0, Space.Self);
            }

        }

        // Timer ökar varenda sekund
        Timer += Time.deltaTime;
        if (Timer > variabel && Timer < variabel + 0.2)
        {
            Debug.Log(string.Format("Timer:"));

            print(Timer);
            variabel = (variabel + 1);
            
        } 
        
    }
}
