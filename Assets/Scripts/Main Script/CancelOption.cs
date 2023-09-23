using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelOption : MonoBehaviour
{
    public GameObject cancel;
    public GameObject can;
    public void QuitGame()
    {
        if (!PauseManager.instance.isPause)
        {
            PauseManager.instance.isPause = true;
            cancel.SetActive(true);
            can.SetActive(true);
        }
    }
}
