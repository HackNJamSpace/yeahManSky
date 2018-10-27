using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCutsceneCrash : MonoBehaviour {

    public GameObject panelIntroduction, satelliteObject;
	

    public void ShowCrash()
    {
        panelIntroduction.SetActive(false);
        satelliteObject.SetActive(true);
    }
}
