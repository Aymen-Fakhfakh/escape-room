using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void how_to_play()
    {
        SceneManager.LoadScene(5);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
