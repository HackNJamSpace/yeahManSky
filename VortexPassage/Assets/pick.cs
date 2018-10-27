using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //other.SendMessage("Item1");
            Destroy(this.gameObject);
        }
            

    }
}
