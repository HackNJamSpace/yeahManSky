using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTriggerCollide : MonoBehaviour {

    public SpaceStationGameController spaceController;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && spaceController.emergency == true)
        {
            spaceController.crash = true;
        }
    }
}
