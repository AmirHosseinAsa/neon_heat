using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPused = false;
    [SerializeField] GameObject PuseMenu;
    [SerializeField] GameObject ResumeButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            isPused = !isPused;
            PuseMenu.SetActive(isPused);

            //Clear selected object
            EventSystem.current.SetSelectedGameObject(null);

            //set a new selected object
            EventSystem.current.SetSelectedGameObject(ResumeButton);

            Time.timeScale = isPused ? 0f : 1f;
        }
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        PuseMenu.SetActive(false);
        isPused = false;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        isPused = false;
    }
}
