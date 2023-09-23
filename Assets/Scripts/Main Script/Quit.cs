using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject gameob;
    public GameObject can;

    public void ExistCancle()
    {
        gameob.SetActive(false);
        can.SetActive(false);
        PauseManager.instance.isPause = false;
    }

    public void ExistYes()
    {
        Application.Quit();
    }
}
