using UnityEngine;
using UnityEngine.EventSystems;

public class DisableCursor : MonoBehaviour
{
    [SerializeField] GameObject DefaultButton;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
       
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Clear selected object
            EventSystem.current.SetSelectedGameObject(null);

            //set a new selected object
            EventSystem.current.SetSelectedGameObject(DefaultButton);
        }
    }
}
