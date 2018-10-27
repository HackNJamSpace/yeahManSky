using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TimeManager : MonoBehaviour {

    public bool isInPause;
    public GameObject canvasPause;
    GameObject player;
    FirstPersonController fpc;

    // Use this for initialization
    void Start () {
        isInPause = false;
        Time.timeScale = 1;

        fpc = GameObject.FindObjectOfType<FirstPersonController>();
    }
	
	// Update is called once per frame
	void Update () {
        CheckPlayerFPS();
        CheckDeltaTime();

        if (Input.GetKeyDown("p"))
        {
            isInPause = !isInPause;
        }
       
	}
    void CheckDeltaTime()
    {
        if(isInPause == true)
        {
            Time.timeScale = 0;
            canvasPause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            canvasPause.SetActive(false);
        }
    }

    void CheckPlayerFPS()
    {
        
        if(fpc == null)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            return;
        }
        else
        {
            if (isInPause == true)
            {
                fpc.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                fpc.enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
