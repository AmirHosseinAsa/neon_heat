using System.Collections;
using UnityEngine;

public class KeysTutorial : MonoBehaviour
{
    [SerializeField] GameObject Tutorial;

    [SerializeField] GameObject TextsForGamePad;
    [SerializeField] GameObject TextsForKeyboard;
    
    bool showedKeyBindings = false;
    bool isShowing = false;

    void Update()
    {
        if (showedKeyBindings == false)
        {
            isShowing = true;
            StartCoroutine(HideKeyBindiingsAfterSeccounds());
        }
        else if (PauseMenu.isPused)
            isShowing = true;
        else if (showedKeyBindings)
            isShowing = false;

        Tutorial.SetActive(isShowing);
        TextsForGamePad.SetActive(Input.GetJoystickNames().Length > 0);
        TextsForKeyboard.SetActive(Input.GetJoystickNames().Length == 0);

    }
    IEnumerator HideKeyBindiingsAfterSeccounds()
    {
        yield return new WaitForSeconds(25f);
        Tutorial.SetActive(false);
        showedKeyBindings = true;
    }
}
