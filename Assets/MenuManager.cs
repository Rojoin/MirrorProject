using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void ApplicationExit()
    {
        Debug.Log("Se cerro :C");
        Application.Quit();
    }
}
