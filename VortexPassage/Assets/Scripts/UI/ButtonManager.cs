using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void GoToFirstFly()
    {
        SceneManager.LoadScene(1);
    }
}
