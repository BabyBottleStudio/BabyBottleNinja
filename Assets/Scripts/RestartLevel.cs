using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

    public void restartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log(sceneName);
    }

    public void exitApp()
    {
        Application.Quit();

    }
}
