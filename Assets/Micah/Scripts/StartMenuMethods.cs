using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuMethods : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void QuitButton()
    {
        Debug.Log("Quit the game!");
        Application.Quit();
    }
}
