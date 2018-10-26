using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTriggerCollide : MonoBehaviour {

    public SpaceStationGameController spaceController;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            spaceController.emergency = true;
        }
    }
}
