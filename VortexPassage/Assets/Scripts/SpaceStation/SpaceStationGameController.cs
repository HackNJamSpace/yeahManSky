using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceStationGameController : MonoBehaviour {

    public bool emergency, crash;
    public GameObject emergencyLights;
    public GameObject stationObject;


	// Use this for initialization
	void Start () {
        emergency = false;
        crash = false;
        emergencyLights.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (emergency)
        {
            emergencyLights.SetActive(true);
            stationObject.GetComponent<Animator>().SetTrigger("crashed");
        }

        if (crash)
        {
           
        }
	}
}
