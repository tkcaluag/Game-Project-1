using UnityEngine;

public class PauseInput : MonoBehaviour
{
    public GameObject menu;
    // Update is called once per frame
    void Update()
    {
    
    }

    public void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
