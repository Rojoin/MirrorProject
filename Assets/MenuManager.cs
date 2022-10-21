using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void playGame()
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Interface/Selection", this.gameObject);
        SceneManager.LoadScene(1);
    }

    public void CreditsScene()
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Interface/Buttons", this.gameObject);
        SceneManager.LoadScene("CreditsScene");
    }
    public void ApplicationExit()
    {
        Debug.Log("Se cerro :C");
        Application.Quit();
    }
}
