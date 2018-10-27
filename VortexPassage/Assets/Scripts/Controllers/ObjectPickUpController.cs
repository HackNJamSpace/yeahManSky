using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectPickUpController : MonoBehaviour {

    GameObject[] itemsToPick;

    int objectsPicked, totalObjectsCount;

    public Text objectiveText;

	// Use this for initialization
	void Start () {
        itemsToPick = GameObject.FindGameObjectsWithTag("Item");
        totalObjectsCount = itemsToPick.Length;
        objectsPicked = 0;
	}
	
	// Update is called once per frame
	void Update () {
        objectiveText.text = "Recupera los componentes de tu nave.\nObjetos por recuperar : "+ totalObjectsCount;
		if(objectsPicked >= itemsToPick.Length)
        {
            OutOfThePlanet();
        }
	}

    public void PickUpItem()
    {
        objectsPicked++;
        totalObjectsCount--;
    }

    void OutOfThePlanet() {
        SceneManager.LoadScene(8);
    }
}
