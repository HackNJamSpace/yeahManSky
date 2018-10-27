using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceStationGameController : MonoBehaviour {

    public bool emergency, crash;
    public GameObject emergencyLights;
    public GameObject stationObject;

    public Text objectiveText;


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
            objectiveText.text = "Algo anda mal! ESCAPA!";
        }
        else
        {
            objectiveText.text = "Ve al panel de control de la nave.";
        }

        if (crash)
        {
            SceneManager.LoadScene(3);
        }
	}
}
