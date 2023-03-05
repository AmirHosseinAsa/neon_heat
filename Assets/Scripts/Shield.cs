using System.Collections;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool onOff = false;
    InvertedColor invertedColor;
    GameObject sphere;


    float Stamina = 3f;
    float MaxStamina = 3f;
    float DecayRate = .8f;
    float RefillRate = .45f;

    // Update is called once per frame
    public void Update()
    {
        if (sphere == null)
        {
            sphere = GameObject.FindGameObjectWithTag("ShieldSphere");
        }


        if (invertedColor == null)
        {
            invertedColor = Info.getInvertedColorEffects();
        }
        else
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0) || Input.GetKey(KeyCode.JoystickButton4) || Input.GetKey(KeyCode.JoystickButton5)))
            {
                if (Stamina > 0.1)
                    Stamina = Stamina - DecayRate * Time.deltaTime;

                if (Stamina < 1.5)
                {
                    onOff = false;
                }
                else if (Stamina > 1.5)
                {
                    onOff = true;
                }
            }
            else
            {
                if (Stamina < MaxStamina)
                    Stamina = Stamina + RefillRate * Time.deltaTime;
                onOff = false;
            }

            invertedColor.onOff = onOff;

            if (onOff)
            {
                sphere.SetActive(true);
            }
            else
            {
                sphere.SetActive(false);
            }
        }
    }
}
