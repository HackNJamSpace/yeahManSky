using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour {

    ObjectPickUpController opController;

	// Use this for initialization
	void Start () {
        opController = GameObject.FindGameObjectWithTag("Controller").GetComponent<ObjectPickUpController>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            opController.PickUpItem();
            Destroy(gameObject);
        }
    }

}
