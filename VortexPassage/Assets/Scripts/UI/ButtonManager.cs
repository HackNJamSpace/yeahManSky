using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void GoToFirstFly()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToSecondFly()
    {
        SceneManager.LoadScene(8);
    }

    public void GoToFirstPlanet()
    {
        SceneManager.LoadScene(7);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RetryLevel()
    {
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
