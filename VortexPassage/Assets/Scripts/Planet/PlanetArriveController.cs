using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlanetArriveController : MonoBehaviour {


    public string planetName;
    public int planetIndex;
    public bool isInRangeOfInteraction;
    public GameObject canvasDisplayEnterInstruction;
    public Text enterInstructions;


	// Use this for initialization
	void Start () {
        this.isInRangeOfInteraction = false;
        
    }
	
	// Update is called once per frame
	void Update () {

        if (this.isInRangeOfInteraction == true)
        {
            canvasDisplayEnterInstruction.SetActive(true);
            enterInstructions.text = planetName;
        }
        else if(this.isInRangeOfInteraction == false)
        {
            enterInstructions.text = "";
            canvasDisplayEnterInstruction.SetActive(false);
        }
        if (Input.GetKey("x") && this.isInRangeOfInteraction)
        {
            print(planetIndex);
            SceneManager.LoadScene(planetIndex);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.isInRangeOfInteraction = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            this.isInRangeOfInteraction = false;
        }
    }
}
