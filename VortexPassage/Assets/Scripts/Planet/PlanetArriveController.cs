using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetArriveController : MonoBehaviour {

    public bool isInRangeOfInteraction;

	// Use this for initialization
	void Start () {
        isInRangeOfInteraction = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("x"))
        {
            if (isInRangeOfInteraction)
            {
                print("Hell yeah");
            }
        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isInRangeOfInteraction = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInRangeOfInteraction = false;
        }
    }
}
