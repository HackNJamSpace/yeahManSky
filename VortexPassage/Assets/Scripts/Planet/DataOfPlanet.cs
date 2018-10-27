using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataOfPlanet : MonoBehaviour {

    GameObject canvas;
    DisplayData displayData;


    public string title;
    [TextArea(15, 20)]
    public string description;
    // Use this for initialization
    void Start () {
        canvas = GameObject.FindGameObjectWithTag("CanvasDataDisplay");
        displayData = canvas.GetComponent<DisplayData>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            displayData.title.text = title;
            displayData.description.text = description;
            displayData.showCanvas = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            displayData.title.text = "";
            displayData.description.text = "";
            displayData.showCanvas = false;
        }
    }
}
